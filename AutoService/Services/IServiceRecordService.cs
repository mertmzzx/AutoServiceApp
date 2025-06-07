using AutoService.Models;

namespace AutoService.Services
{
    public interface IServiceRecordService
    {
        /// <summary>
        /// Returns all service records (no related data included).
        /// </summary>
        Task<List<ServiceRecord>> GetAllAsync();

        /// <summary>
        /// Returns all service records, including related Car and Mechanic entities.
        /// </summary>
        Task<List<ServiceRecord>> GetAllWithRelatedAsync();

        Task<List<ServiceRecord>> GetByCarIdAsync(int carId);
        Task<ServiceRecord?> GetByIdAsync(int id);
        Task AddAsync(ServiceRecord record);
        Task DeleteAsync(int id);
    }
}
