using AutoService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
