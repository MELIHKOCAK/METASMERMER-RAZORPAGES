using MetasMermer.Services.Abouts;
using MetasMermer.Services.Contacts;
using MetasMermer.Services.Footers;
using MetasMermer.Services.Galleries;
using MetasMermer.Services.Heroes;
using MetasMermer.Services.Solutions;
using MetasMermer.Services.Users;
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
            services.AddScoped<ISolutionService, SolutionService>();
            services.AddScoped<IHeroService, HeroService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IGalleryService, GalleryService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
