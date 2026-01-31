using MetasMermer.Services.Footers;
using MetasMermer.Services.Whatsapps;
using Microsoft.Extensions.DependencyInjection;

namespace MetasMermer.Services.Extensition
{
    public static class ServiceExtensition
    {
        public static IServiceCollection AddServiceExtensition(this IServiceCollection services)
        {
            services.AddScoped<IWhatsappService, WhatsappService>();
            services.AddScoped<IFooterService, FooterService>();
            return services;
        }
    }
}
