namespace TheBestWebInterface.Services
{
    public interface IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(DataForModelDto data, int skamCounter);
    }

    public class PredictService : IPredictService
    {
        public IEnumerable<PredictDto> GetPredicts(DataForModelDto data, int skamCounter)
        {
            switch (skamCounter)
            {
                case 36:
                    return
                        [new PredictDto { Name = "ЭВЛК", Probability = " - вероятность 56%" },
                        new PredictDto { Name = "СКЛЕР", Probability = " - вероятность 32%" }];
                case 58:
                    return
                        [new PredictDto { Name = "ЭВЛК", Probability = " - вероятность 56%" },
                        new PredictDto { Name = "СКЛЕР", Probability = " - вероятность 32%" }];
                case 73:
                    return
                        [new PredictDto { Name = "ЭВЛК", Probability = " - вероятность 56%" },
                        new PredictDto { Name = "СКЛЕР", Probability = " - вероятность 32%" }];
                default:
                    return
                        [new PredictDto { Name = "ЭВЛК", Probability = " - вероятность 56%" },
                        new PredictDto { Name = "СКЛЕР", Probability = " - вероятность 32%" }];
            }
        }
    }
}
