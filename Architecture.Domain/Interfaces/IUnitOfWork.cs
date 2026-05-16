using Architecture.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<T> Repository<T>() where T : class;

        // Save everything in one transaction
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
