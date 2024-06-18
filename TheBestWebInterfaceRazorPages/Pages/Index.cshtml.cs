using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheBestWebInterfaceRazorPages.ML;
using TheBestWebInterfaceRazorPages.Services;
using TheBestWebInterfaceRazorPages.ViewModels;

namespace TheBestWebInterfaceRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPredictService _predictService;

        public IndexModel(ILogger<IndexModel> logger, IPredictService predictService)
        {
            _logger = logger;
            _predictService = predictService;
        }

        [BindProperty]
        public DataForModelViewModel DataForModelViewModel { get; set; }

        public void OnGet()
        {
            DataForModelViewModel = new DataForModelViewModel();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid) return;
            var predicts = _predictService.GetPredicts(MapModelInput(DataForModelViewModel));
            DataForModelViewModel.Result = predicts.Select(MapPredictViewModel).ToArray();
        }

        private ModelInput MapModelInput(DataForModelViewModel data)
        {
            return new ModelInput
            {
                Gender = (int)data.Gender,
                Age = (int)(data.Age / 10),
                Varikoz = data.Complaints.Varikoz,
                Uplotnenie = data.Complaints.Uplotnenie,
                Potemnenie = data.Complaints.Potemnenie,
                ZazhivshayaYazva = data.Complaints.ZazhivshayaYazva,
                OtkritayaYazva = data.Complaints.OtkritayaYazva,
                OtekiEst = data.Localizations.OtekiEst,
                GlubokieVeniProhodimi = data.Localizations.GlubokieVeniProhodimi,
                Tromboflebit = data.Localizations.Tromboflebit,
                Boleznennost = data.Localizations.Boleznennost,
                Bedro = data.Localizations.VarikozLocalization.Bedro,
                Golen = data.Localizations.VarikozLocalization.Golen,
                Stopa = data.Localizations.VarikozLocalization.Stopa,
                Bedro2 = data.Localizations.TeleoangioektaziiLocalization.Bedro,
                Golen2 = data.Localizations.TeleoangioektaziiLocalization.Golen,
                Stopa2 = data.Localizations.TeleoangioektaziiLocalization.Stopa,
                NesostVeni = data.Uzi.NesostVeni,
                Reflux = data.Uzi.Sfs.Reflux,
                Diameter = data.Uzi.Sfs.Value,
                Reflux2 = data.Uzi.Bpv.Reflux,
                PredostSegment = data.Uzi.Bpv.PredostSegment,
                SredTretBedra = data.Uzi.Bpv.SredTretBedra,
                UrovenKolena = data.Uzi.Bpv.UrovenKolena,
                VerhSredTretGoleni = data.Uzi.Bpv.VerhSredTretGoleni,
                Reflux3 = data.Uzi.Sps.Reflux,
                Diameter2 = data.Uzi.Sps.Value,
                Reflux4 = data.Uzi.Mpv.Reflux,
                Diameter3 = data.Uzi.Mpv.Value,
            };
        }

        private PredictViewModel MapPredictViewModel(PredictDto predict)
        {
            return new PredictViewModel
            {
                Name = predict.Name,
                Probability = predict.Probability
            };
        }
    }
}