using MetasMermer.Repositories.EFCORE;
using MetasMermer.Repositories.EFCORE.Galleries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MetasMermer.Repositories.Extensition;

public static class RepositoryExtensition
{
    public static IServiceCollection AddRepositoryConfiguration(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<MetasMermerDbContext>(options =>
         configuration.GetConnectionString("DefaultConnectionString")
        );
        service.AddScoped<IGalleryRepository, GalleryRepository>();
        service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        return service;
    }
}
