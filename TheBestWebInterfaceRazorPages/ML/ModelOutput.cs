using Microsoft.ML.Data;

namespace TheBestWebInterfaceRazorPages.ML
{
    public class ModelOutput
    {
        [ColumnName(@"Features")]
        public float[] Features { get; set; }

        [ColumnName(@"PredictedLabel")]
        public bool PredictedLabel { get; set; }

        [ColumnName(@"Score")]
        public float Score { get; set; }

        [ColumnName(@"Probability")]
        public float Probability { get; set; }
    }
}