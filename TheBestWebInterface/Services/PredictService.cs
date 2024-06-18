using Microsoft.ML;
using TheBestWebInterface.ML;
using TheBestWebInterface.Models;

namespace TheBestWebInterface.Services
{
    public interface IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(DataForModelViewModel data); //TODO Dto
    }

    public class PredictService : IPredictService
    {
        private static string BpvModelName = "EVLK_BPV.mlnet";
        private static string MpvModelName = "EVLK_MPV.mlnet";
        private static string SclerModelName = "SCLER.mlnet";

        public IEnumerable<PredictDto> GetPredicts(DataForModelViewModel data)
        {
            var result = new List<PredictDto>();
            var modelInput = MapModelInput(data);

            result.Add(MapPredictDto(Predict(modelInput, BpvModelName), "ЭВЛК БПВ"));
            result.Add(MapPredictDto(Predict(modelInput, MpvModelName), "ЭВЛК МПВ"));
            result.Add(MapPredictDto(Predict(modelInput, SclerModelName), "СКЛЕР"));

            return result;
        }

        private static ModelOutput Predict(ModelInput input, string modelName)
        {
            var predEngine = CreatePredictEngine(modelName);
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine(string modelName)
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(Path.GetFullPath($"ML/{modelName}"), out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
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

        private PredictDto MapPredictDto(ModelOutput modelOutput, string name)
        {
            return new PredictDto
            {
                Name = name,
                Probability = $"{(float)Math.Round(modelOutput.Probability * 100, 2)}%"
            };
        }
    }
}