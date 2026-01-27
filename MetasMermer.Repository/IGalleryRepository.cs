using MetasMermer.Repositories.EFCORE.Galleries;

namespace MetasMermer.Repositories;

public interface IGalleryRepository : IGenericRepository<Gallery>
{
    ValueTask Add(Gallery entity);

    void Delete(int id);
}
