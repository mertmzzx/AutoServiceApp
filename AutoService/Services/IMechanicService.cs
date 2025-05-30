using AutoService.Models;

namespace AutoService.Services
{
    public interface IMechanicService
    {
        Task<List<Mechanic>> GetAllAsync();
        Task<Mechanic?> GetByIdAsync(int id);
        Task AddAsync(Mechanic mech);
        Task UpdateAsync(Mechanic mech);
        Task DeleteAsync(int id);
    }
}
