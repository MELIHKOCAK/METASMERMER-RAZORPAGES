using MetasMermer.Repositories.EFCORE;

namespace MetasMermer.Repositories.EFCORE.Galleries
{
    public class GalleryRepository(MetasMermerDbContext context) : GenericRepository<Gallery>(context), IGalleryRepository
    {
        public async ValueTask Add(Gallery entity) => await context.AddAsync(entity);

        public void Delete(int id)
        {
            var gallery = context.Set<Gallery>().Find(id);
            context.Remove(gallery);
        }
    }
}
