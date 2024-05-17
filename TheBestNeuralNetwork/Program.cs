using Microsoft.ML;
using TheBestDomain;

namespace TheBestNeuralNetwork
{
    internal static class Program
    {
        private static async Task Main()
        {
            //var mlContext = new MLContext();
            ////var dataView = mlContext.Data.LoadFromEnumerable<DataForModel>(data);
            //var dataView = mlContext.Data.LoadFromTextFile<DataForModel>("Resource\\Result.csv", hasHeader: true, separatorChar: ',');
            //var dataSplit = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

            ////var textEstimator = mlContext.Transforms.Text.FeaturizeText("Description");

            ////Step 3. Build your data processing and training pipeline
            //var pipeline = mlContext.Transforms.Text
            //    .FeaturizeText("Features", nameof(SentimentIssue.Text))
            //    .Append(mlContext.BinaryClassification.Trainers
            //        .LbfgsLogisticRegression("Label", "Features"));

            ////Step 4. Train your model
            //var trainedModel = pipeline.Fit(dataSplit.TrainSet);

            ////Step 5. Make predictions using your trained model
            //var predictionEngine = ctx.Model
            //    .CreatePredictionEngine<ModelInput, ModelOutput>(trainedModel);

            //var sampleStatement = new ModelInput() { Text = "This is a horrible movie" };

            //var prediction = predictionEngine.Predict(sampleStatement);
        }
    }
}