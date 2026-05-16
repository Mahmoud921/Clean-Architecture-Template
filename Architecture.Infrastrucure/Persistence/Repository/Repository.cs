using Architecture.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
namespace Architecture.Infrastrucure.Persistence.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext context)
        {
            _context = context;
             _dbSet = _context.Set<T>();
        }
        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }
        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.AsNoTracking().ToListAsync(cancellationToken);
        }
        public async Task<T?> GetDetailsAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }
        public async Task AddAsync(T entity, CancellationToken cancellationToken = default) { await _dbSet.AddAsync(entity, cancellationToken); }
        public void Update(T entity) { _dbSet.Update(entity); }
        public void Delete(Guid id) {
            var entity = _dbSet.Find(id);
            if (entity != null) { _dbSet.Remove(entity); }
        }
    }
}
