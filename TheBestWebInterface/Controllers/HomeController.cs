using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheBestWebInterface.Models;
using Microsoft.Extensions.ML;
using static TheBestWebInterface.MLModel;
using Microsoft.ML;

namespace TheBestWebInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _test;

        public HomeController(ILogger<HomeController> logger, PredictionEnginePool<ModelInput, ModelOutput> test)
        {
            _logger = logger;
            _test = test;
        }

        public async Task<IActionResult> Index(DataForModelViewModel data)
        {
            if (data.Age == 0)
            {
                return View();
            }

            var z = new ModelInput();
            var a = _test.Predict(z);


            MLContext mlContext = new MLContext();

            // Load Trained Model
            DataViewSchema predictionPipelineSchema;
            ITransformer predictionPipeline = mlContext.Model.Load("Ml/MLModel.mlnet", out predictionPipelineSchema);
            // Create PredictionEngines
            var predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(predictionPipeline);

            data.Result += data.Result + "dwa";
            return View(data);
        }

        //public IActionResult GetOperations(DataForModelViewModel data)
        //{
        //    //ViewData["comment"] = "DWADWA";
        //    return View();
        //    //return new ActionResult().;
        //}
        //[HttpPost]
        //public IActionResult GetOperations(DataForModelViewModel data)
        //{
        //    ViewData["Result"] = "Hello ";
        //    //ViewData["NumTimes"] = numTimes;
        //    return RedirectToAction(nameof(Index));
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
