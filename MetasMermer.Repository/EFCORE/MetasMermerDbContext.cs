using MetasMermer.Repositories.EFCORE.Contacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace MetasMermer.Repositories.EFCORE
{
    public class MetasMermerDbContext(DbContextOptions<MetasMermerDbContext> options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(BaseEntity<int>)))
                    .ToList()
                    .ForEach(type => modelBuilder.Entity(type));

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MetasMermerDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
