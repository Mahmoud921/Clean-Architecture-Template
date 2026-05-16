using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(Guid id,CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<T?> GetDetailsAsync(Guid id,CancellationToken cancellationToken = default);
        Task AddAsync(T entity,CancellationToken cancellationToken = default);
        void Update(T entity);
        void Delete(Guid id);
    }
}
