using AutoService.Data;
using AutoService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Services
{
    class MechanicService : IMechanicService
    {
        private readonly GarageDbContext _db;
        public MechanicService(GarageDbContext db)
        {
            _db = db;
        }


        public async Task AddAsync(Mechanic mech)
        {
            _db.Mechanics.Add(mech);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var mech = await _db.Mechanics.FindAsync(id);

            if (mech != null)
            {
                _db.Mechanics.Remove(mech);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Mechanic mech)
        {
            _db.Mechanics.Update(mech);
            await _db.SaveChangesAsync();
        }

        public Task<List<Mechanic>> GetAllAsync() => _db.Mechanics.ToListAsync();

        public Task<Mechanic?> GetByIdAsync(int id) => _db.Mechanics.FindAsync(id).AsTask();

    }
}
