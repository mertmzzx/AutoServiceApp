using AutoService.Data;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using ClosedXML.Excel;

namespace AutoService.Services
{
    class ExportService : IExportService
    {
        private readonly GarageDbContext _db;

        public ExportService(GarageDbContext db)
        {
            _db = db;
        }

        public async Task<byte[]> ExportServiceRecordAsync(int recordId)
        {
            var r = await _db.ServiceRecords
                             .Include(x => x.Car)
                             .Include(x => x.Mechanic)
                             .FirstOrDefaultAsync(x => x.Id == recordId);
            if (r == null) return Array.Empty<byte>();

            var doc = Document.Create(d =>
            {
                d.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);

                    // HEADER with container styling before text
                    page.Header().Element(header =>
                    {
                        header
                          .PaddingBottom(10)
                          .BorderBottom(2)
                          .BorderColor(Colors.Grey.Lighten2)
                          .AlignCenter();

                        header.Text("Service Record")
                              .FontSize(24)
                              .Bold()
                              .FontColor(Colors.Blue.Medium);
                    });

                    // CONTENT table
                    page.Content().Element(content =>
                    {
                        content.PaddingVertical(10);

                        content.Table(table =>
                        {
                            // two columns: label | value
                            table.ColumnsDefinition(cd =>
                            {
                                cd.RelativeColumn(1);
                                cd.RelativeColumn(2);
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().Element(CellStyle).Text(label).SemiBold();
                                table.Cell().Element(CellStyle).Text(value);
                            }

                            AddRow("Car:", $"{r.Car.Make} {r.Car.Model} ({r.Car.LicensePlate})");
                            AddRow("VIN:", r.Car.VIN);
                            AddRow("Date:", r.Date.ToString("dd.MM.yyyy"));
                            AddRow("Mechanic:", r.Mechanic.Name);
                            AddRow("Description:", r.Description);
                            AddRow("Cost:", r.Cost.ToString("C"));
                        });

                        static IContainer CellStyle(IContainer c) =>
                            c.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
                    });

                    // FOOTER
                    page.Footer().Element(footer =>
                    {
                        footer.AlignCenter();
                        footer.Text($"Generated: {DateTime.Now:dd.MM.yyyy HH:mm}")
                              .FontSize(10)
                              .FontColor(Colors.Grey.Darken1);
                    });
                });
            });

            return doc.GeneratePdf();
        }

        public async Task<byte[]> ExportServiceHistoryAsync(int carId)
        {
            var car = await _db.Cars
                .Include(c => c.ServiceRecords)
                    .ThenInclude(r => r.Mechanic)
                .FirstOrDefaultAsync(c => c.Id == carId);

            if (car == null)
                return Array.Empty<byte>();

            var records = car.ServiceRecords.OrderBy(r => r.Date).ToList();

            var doc = Document.Create(d =>
            {
                d.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);

                    // HEADER
                    page.Header()
                        .PaddingBottom(10)
                        .BorderBottom(2)
                        .BorderColor(Colors.Grey.Lighten2)
                        .AlignCenter()
                        .Text("Service History")
                          .FontSize(24)
                          .Bold()
                          .FontColor(Colors.Blue.Medium);

                    // SINGLE Content call
                    page.Content().Column(column =>
                    {
                        // 1) Car info
                        column.Item()
                              .PaddingVertical(5)
                              .Text($"{car.LicensePlate} – {car.Make} {car.Model} ({car.Year})")
                              .FontSize(14)
                              .Bold();

                        // 2) History table
                        column.Item().Element(tableWrapper =>
                        {
                            tableWrapper.Table(table =>
                            {
                                // define columns
                                table.ColumnsDefinition(cd =>
                                {
                                    cd.ConstantColumn(60);
                                    cd.RelativeColumn();
                                    cd.ConstantColumn(80);
                                    cd.RelativeColumn();
                                });

                                // header row
                                table.Header(header =>
                                {
                                    header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Date").SemiBold();
                                    header.Cell().Background(Colors.Grey.Lighten2).Padding(5).Text("Description").SemiBold();
                                    header.Cell().Background(Colors.Grey.Lighten2).Padding(5).AlignRight().Text("Cost").SemiBold();
                                    header.Cell().Background(Colors.Grey.Lighten2).Padding(5).PaddingLeft(30).Text("Mechanic").SemiBold();
                                });

                                // data rows
                                bool shade = false;
                                foreach (var r in records)
                                {
                                    var bg = shade ? Colors.Grey.Lighten4 : Colors.White;
                                    shade = !shade;

                                    table.Cell().Background(bg).Padding(5).Text(r.Date.ToString("dd.MM.yyyy"));
                                    table.Cell().Background(bg).Padding(5).Text(r.Description);
                                    table.Cell().Background(bg).Padding(5).AlignRight().Text(r.Cost.ToString("C"));
                                    table.Cell().Background(bg).Padding(5).PaddingLeft(30).Text(r.Mechanic.Name);
                                }
                            });
                        });
                    });

                    // FOOTER
                    page.Footer()
                        .AlignCenter()
                        .Text($"Total Records: {records.Count}   Generated: {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(10)
                        .FontColor(Colors.Grey.Darken1);
                });
            });

            return doc.GeneratePdf();
        }

        public async Task<byte[]> ExportServiceRecordExcelAsync(int carId)
        {
            var car = await _db.Cars
        .Include(c => c.ServiceRecords)
            .ThenInclude(r => r.Mechanic)
        .FirstOrDefaultAsync(c => c.Id == carId);

            if (car == null) return Array.Empty<byte>();

            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("History");

            // Header row
            ws.Cell(1, 1).Value = "Date";
            ws.Cell(1, 2).Value = "Description";
            ws.Cell(1, 3).Value = "Cost";
            ws.Cell(1, 4).Value = "Mechanic";
            ws.Range("A1:D1").Style.Font.SetBold();

            // Data rows
            var row = 2;
            foreach (var r in car.ServiceRecords.OrderBy(r => r.Date))
            {
                ws.Cell(row, 1).Value = r.Date;
                ws.Cell(row, 1).Style.DateFormat.Format = "dd.MM.yyyy";
                ws.Cell(row, 2).Value = r.Description;
                ws.Cell(row, 3).Value = r.Cost;
                ws.Cell(row, 3).Style.NumberFormat.Format = "#,##0.00";
                ws.Cell(row, 4).Value = r.Mechanic.Name;
                row++;
            }

            ws.Columns().AdjustToContents();

            using var ms = new MemoryStream();
            wb.SaveAs(ms);
            return ms.ToArray();
        }
    }
}
