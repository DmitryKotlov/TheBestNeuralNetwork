using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheBestWebInterface.Models;
using TheBestWebInterface.Services;

namespace TheBestWebInterface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPredictService _predictService;

        public HomeController(ILogger<HomeController> logger, IPredictService predictService)
        {
            _logger = logger;
            _predictService = predictService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new DataForModelViewModel());
        }

        // public IActionResult GetResult(DataForModelViewModel data)
        // {
        //     //var dto = data.ToDto();
        //
        //     var predicts = _predictService.GetPredicts(data);
        //     ViewData["Result"] = predicts;
        //     return View("Index");
        // }

        [HttpPost]
        public IActionResult Index(DataForModelViewModel data)
        {
            if (ModelState.IsValid)
            {
                data.Result2 = 1;
                data.Result = _predictService.GetPredicts(data).ToArray();
            }

            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}