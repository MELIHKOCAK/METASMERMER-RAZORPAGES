using MetasMermer.Repositories.EFCORE.Galleries;

namespace MetasMermer.Repositories.Gallery;

public interface IGalleryRepository : IGenericRepository<EFCORE.Galleries.Gallery>
{
    ValueTask Add(EFCORE.Galleries.Gallery entity);

    void Delete(int id);
}
