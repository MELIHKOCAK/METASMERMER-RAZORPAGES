using MetasMermer.Repositories.EFCORE;
using Microsoft.EntityFrameworkCore;

namespace MetasMermer.Repositories;

public class GenericRepository<T>(MetasMermerDbContext context) : IGenericRepository<T> where T : class
{
    private readonly DbSet<T> _dbset = context.Set<T>();

    public IQueryable<T> GetAll(bool isChangeTrackerActive) => isChangeTrackerActive ? _dbset.AsQueryable() : _dbset.AsQueryable().AsNoTracking() ;

    public ValueTask<T> GetByIdAsync(int id) => _dbset.FindAsync(id);

    public void Update(T entity) => _dbset.Update(entity);
}
