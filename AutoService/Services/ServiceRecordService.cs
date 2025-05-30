using AutoService.Data;
using AutoService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Services
{
    class ServiceRecordService : IServiceRecordService
    {
        private readonly GarageDbContext _db;

        public ServiceRecordService(GarageDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(ServiceRecord record)
        {
            _db.ServiceRecords.Add(record);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var rec = await _db.ServiceRecords.FindAsync(id);
            if (rec != null)
            {
                _db.ServiceRecords.Remove(rec);
                await _db.SaveChangesAsync();
            }    
        }

        public Task<List<ServiceRecord>> GetByCarIdAsync(int carId) =>
            _db.ServiceRecords
                .Include(r => r.Mechanic)
                .Where(r => r.CarId == carId)
                .OrderByDescending(r => r.Date)
                .ToListAsync();


        public Task<ServiceRecord?> GetByIdAsync(int id) => 
            _db.ServiceRecords.Include(r => r.Mechanic).FirstOrDefaultAsync(r => r.Id == id);
    }
}
