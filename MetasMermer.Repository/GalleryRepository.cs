using MetasMermer.Repositories.EFCORE;
using MetasMermer.Repositories.EFCORE.Galleries;

namespace MetasMermer.Repositories
{
    public class GalleryRepository(MetasMermerDbContext context) : GenericRepository<Gallery>(context), IGalleryRepository
    {
        public async ValueTask Add(Gallery entity)
        {
            await context.AddAsync(entity);
        }

        public void Delete(int id)
        {
            var gallery = context.Set<Gallery>().Find(id);
            context.Remove(gallery);
        }
    }
}
