using Microsoft.Extensions.ML;
using static TheBestWebInterface.MLModel;

namespace TheBestWebInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddPredictionEnginePool<ModelInput, ModelOutput>()
                .FromFile("Ml/MLModel.mlnet");
            //builder.Services.AddPredictionEnginePool<ModelInput, ModelOutput>()
            //    .FromFile("SentimentAnalysis.zip");
            //builder.Services.AddPredictionEnginePool<ModelInput, ModelOutput>()
            //    .FromFile("SentimentAnalysis.zip");
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            
            //app.Swagg

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
