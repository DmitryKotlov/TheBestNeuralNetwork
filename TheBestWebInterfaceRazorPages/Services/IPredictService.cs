using Microsoft.ML;
using TheBestWebInterfaceRazorPages.ML;

namespace TheBestWebInterfaceRazorPages.Services
{
    public interface IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(ModelInput data); //TODO Dto
    }

    public class PredictService : IPredictService
    {
        private const string BpvModelName = "EVLK_BPV.mlnet";
        private const string MpvModelName = "EVLK_MPV.mlnet";
        private const string SclerModelName = "SCLER.mlnet";

        public IEnumerable<PredictDto> GetPredicts(ModelInput data)
        {
            var result = new List<PredictDto>
            {
                MapPredictDto(Predict(data, BpvModelName), "ЭВЛК БПВ"),
                MapPredictDto(Predict(data, MpvModelName), "ЭВЛК МПВ"),
                MapPredictDto(Predict(data, SclerModelName), "Склеротерапия")
            };

            return result;
        }

        private PredictDto MapPredictDto(ModelOutput modelOutput, string name)
        {
            var probability = (float)Math.Round(modelOutput.Probability * 100, 2);
            return new PredictDto
            {
                Name = name,
                Description = GetDescription(probability),
                Probability = probability
            };
        }

        private string GetDescription(float probability)
        {
            return probability switch
            {
                >= 76 => "Требуется операция",
                >= 41 => "Потенциально назначить операцию",
                _ => "Операция не требуется"
            };
        }

        private static ModelOutput Predict(ModelInput input, string modelName)
        {
            var predEngine = CreatePredictEngine(modelName);
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine(string modelName)
        {
            var mlContext = new MLContext();
            var mlModel = mlContext.Model.Load(Path.GetFullPath($"ML/{modelName}"), out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}