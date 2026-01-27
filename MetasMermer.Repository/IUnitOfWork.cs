namespace MetasMermer.Repositories;
public interface IUnitOfWork
{
    Task<int> SaveChangeAsync();
}
