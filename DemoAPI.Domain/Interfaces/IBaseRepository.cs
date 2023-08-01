﻿
using DemoAPI.Domain.Entities;

namespace DemoAPI.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T document);
    }
}
