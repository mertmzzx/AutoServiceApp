namespace AutoService.Services
{
    public interface IExportService
    {
        Task<byte[]> ExportServiceRecordAsync(int recordId);
        Task<byte[]> ExportServiceHistoryAsync(int carId);
        Task<byte[]> ExportServiceRecordExcelAsync(int carId);
    }
}
