namespace MetasMermer.Repositories.EFCORE.Galleries;

public interface IGalleryRepository : IGenericRepository<Gallery>
{  
    ValueTask Add(Gallery entity);

    void Delete(int id);
}
