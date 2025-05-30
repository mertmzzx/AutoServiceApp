using AutoService.Models;

namespace AutoService.Services
{
    public interface IServiceRecordService
    {
        Task<List<ServiceRecord>> GetByCarIdAsync(int carId);
        Task<ServiceRecord?> GetByIdAsync(int id);
        Task AddAsync(ServiceRecord record);
        Task DeleteAsync(int id);
    }
}
