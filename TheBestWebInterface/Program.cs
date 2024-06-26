using Microsoft.AspNetCore.Localization;
using System.Globalization;
using TheBestWebInterface.Services;

namespace TheBestWebInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IPredictService, PredictService>();

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"), // Используйте нужную вам культуру
                    new CultureInfo("ru-RU")
                };

                options.DefaultRequestCulture = new RequestCulture("ru-RU"); // Установите нужную вам культуру
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Home/Error");
            app.UseStaticFiles();

            //app.Swagg

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                "default",
                "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}