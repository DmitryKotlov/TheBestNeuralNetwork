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
            return [new PredictDto { Name = "ЭВЛК", Probability = 0.78F }, new PredictDto { Name = "СКЛЕР", Probability = 0.99F }];
        }
    }
}
