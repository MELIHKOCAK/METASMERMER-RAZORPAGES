using MetasMermer.Repositories.EFCORE;

namespace MetasMermer.Repositories;

public class UnitOfWork(MetasMermerDbContext context) : IUnitOfWork
{
    public Task<int> SaveChangeAsync() => context.SaveChangesAsync();
}
