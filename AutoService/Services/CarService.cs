using AutoService.Data;
using AutoService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Services
{
    class CarService : ICarService
    {
        private readonly GarageDbContext _db;
        public CarService(GarageDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Car car)
        {
            _db.Cars.Add(car);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var car = await _db.Cars.FindAsync(id);

            if (car != null)
            {
                _db.Cars.Remove(car);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Car car)
        {
            _db.Cars.Update(car);
            await _db.SaveChangesAsync();
        }
        public Task<List<Car>> GetAllAsync() => _db.Cars.ToListAsync();


        public Task<Car?> GetByIdAsync(int id) => _db.Cars.FindAsync(id).AsTask();

    }
}
