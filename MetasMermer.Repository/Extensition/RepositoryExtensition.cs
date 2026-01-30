using MetasMermer.Repositories.EFCORE;
using MetasMermer.Repositories.EFCORE.Galleries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MetasMermer.Repositories.Extensition;

public static class RepositoryExtensition
{
    public static IServiceCollection AddRepositoryConfiguration(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<MetasMermerDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlite(connectionString);
        });
        
        service.AddScoped<IGalleryRepository, GalleryRepository>(); 
        service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        service.AddScoped<IUnitOfWork, UnitOfWork>();
        return service;
    }
}
