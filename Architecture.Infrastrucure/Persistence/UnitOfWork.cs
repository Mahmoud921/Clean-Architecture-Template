using Architecture.Domain.Interfaces;
using Architecture.Domain.Interfaces.Repository;
using Architecture.Infrastrucure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Infrastrucure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IRepository<T> Repository<T>() where T : class
        {
            var type = typeof(T);

            // Already created before? Return the cached one
            if (_repositories.ContainsKey(type))
                return (IRepository<T>)_repositories[type];

            // First time? Create it, cache it, return it
            var repository = new Repository<T>(_context);
            _repositories[type] = repository;

            return repository;
        }
        public async Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        // Cleanup the DbContext when done
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
