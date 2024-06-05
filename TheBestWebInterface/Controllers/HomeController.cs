using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetResult(DataForModelViewModel data)
        {
            //var dto = data.ToDto();
            var predicts = _predictService.GetPredicts(null);

            return View("Index", data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
