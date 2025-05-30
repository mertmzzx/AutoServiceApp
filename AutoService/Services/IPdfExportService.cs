namespace AutoService.Services
{
    public interface IPdfExportService
    {
        Task<byte[]> ExportServiceRecordAsync(int recordId);
        Task<byte[]> ExportServiceHistoryAsync(int carId);
    }
}
