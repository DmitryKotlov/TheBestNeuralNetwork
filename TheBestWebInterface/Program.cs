using TheBestWebInterface.Services;

namespace TheBestWebInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IPredictService, PredictService>();

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