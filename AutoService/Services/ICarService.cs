﻿using AutoService.Models;

namespace AutoService.Services
{
    public interface ICarService
    {
        Task<List<Car>> GetAllAsync();
        Task<Car?> GetByIdAsync(int id);
        Task AddAsync(Car car);
        Task UpdateAsync(Car car);
        Task DeleteAsync(int id);
    }
}
