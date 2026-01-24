using Microsoft.AspNetCore.Http.Features;

namespace RazorPages.Deneme
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Admin", "AdminPolicy");
            });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy",
                    policy => policy.RequireRole("Admin"));
            });



            builder.Services.AddAuthentication("Cookies")
                            .AddCookie("Cookies", options =>
            {
                options.LoginPath = "/AdminIndex";
                options.AccessDeniedPath = "/Error";
            });



            builder.Services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 20 * 1024 * 1024; // 20 MB
            });

            builder.WebHost.ConfigureKestrel(options =>
            {
                options.Limits.MaxRequestBodySize = 20 * 1024 * 1024;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles(new StaticFileOptions
            {
                OnPrepareResponse = ctx =>
                {
                    const int durationInSeconds = 86400;
                    ctx.Context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.CacheControl] =
                        "public,max-age=" + durationInSeconds;
                }
            });
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}
