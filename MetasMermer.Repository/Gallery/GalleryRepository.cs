using MetasMermer.Repositories.EFCORE;
using MetasMermer.Repositories.EFCORE.Galleries;

namespace MetasMermer.Repositories.Gallery
{
    public class GalleryRepository(MetasMermerDbContext context) : GenericRepository<EFCORE.Galleries.Gallery>(context), IGalleryRepository
    {
        public async ValueTask Add(EFCORE.Galleries.Gallery entity)
        {
            await context.AddAsync(entity);
            
        }

        public void Delete(int id)
        {
            var gallery = context.Set<EFCORE.Galleries.Gallery>().Find(id);
            context.Remove(gallery);
        }
    }
}
