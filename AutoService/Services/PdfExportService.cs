using AutoService.Data;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Services
{
    class PdfExportService : IPdfExportService
    {
        private readonly GarageDbContext _db;

        public PdfExportService(GarageDbContext db)
        {
            _db = db;
        }

        public async Task<byte[]> ExportServiceHistoryAsync(int carId)
        {
            var car = await _db.Cars
                              .Include(c => c.ServiceRecords)
                                .ThenInclude(r => r.Mechanic)
                              .FirstOrDefaultAsync(c => c.Id == carId);
            if (car == null) return Array.Empty<byte>();

            var records = car.ServiceRecords
                             .OrderBy(r => r.Date)
                             .ToList();

            var doc = Document.Create(d =>
            {
                d.Page(page =>
                {
                    page.Margin(30);
                    page.Header().Text("Service History").Bold().FontSize(18).AlignCenter();

                    page.Content().Column(col =>
                    {
                        col.Item().Text($"{car.LicensePlate} — {car.Make} {car.Model} ({car.Year})").Bold();
                        col.Item().LineHorizontal(1, Unit.Point);

                        // Simple table: Date | Description | Cost | Mechanic
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(cd =>
                            {
                                cd.ConstantColumn(60);  // Date
                                cd.RelativeColumn();    // Description
                                cd.ConstantColumn(60);  // Cost
                                cd.RelativeColumn();    // Mechanic
                            });

                            // Header row
                            table.Header(header =>
                            {
                                header.Cell().Text("Date");
                                header.Cell().Text("Description");
                                header.Cell().Text("Cost");
                                header.Cell().Text("Mechanic");
                            });

                            // Data rows
                            foreach (var r in records)
                            {
                                table.Cell().Text(r.Date.ToString("d"));
                                table.Cell().Text(r.Description);
                                table.Cell().AlignRight().Text(r.Cost.ToString("C"));
                                table.Cell().Text(r.Mechanic.Name);
                            }
                        });
                    });

                    page.Footer().AlignRight()
                                .Text($"Total records: {records.Count}   Generated: {DateTime.Now:g}");
                });
            });

            return doc.GeneratePdf();
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
                    page.Margin(30);
                    page.Header().Text("Service Record").Bold().FontSize(18).AlignCenter();

                    page.Content().Column(col =>
                    {
                        col.Item().Text($"Car: {r.Car.LicensePlate} ({r.Car.Make} {r.Car.Model})");
                        col.Item().Text($"VIN: {r.Car.VIN}");
                        col.Item().Text($"Date: {r.Date:d}");
                        col.Item().Text($"Mechanic: {r.Mechanic.Name}");
                        col.Item().Text($"Description: {r.Description}");
                        col.Item().Text($"Cost: {r.Cost:C}");
                    });

                    page.Footer().AlignRight()
                                .Text($"Generated: {DateTime.Now:g}");
                });
            });

            return doc.GeneratePdf();   
        }
    }
}
