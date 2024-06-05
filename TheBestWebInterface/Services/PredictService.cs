namespace TheBestWebInterface.Services
{
    public interface IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(DataForModelDto data);
    }

    public class PredictService : IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(DataForModelDto data)
        {
            return [
                new PredictDto { Name = "ЭВЛК", Probability = " - вероятность 56%" },
                new PredictDto { Name = "СКЛЕР", Probability = " - вероятность 32%" }
                ];
        }
    }
}
