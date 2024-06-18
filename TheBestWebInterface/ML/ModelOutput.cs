using Microsoft.ML.Data;

namespace TheBestWebInterface.ML
{
    public class ModelOutput
    {
        // [ColumnName(@"Gender")]
        // public float Gender { get; set; }
        //
        // [ColumnName(@"Age")]
        // public float Age { get; set; }
        //
        // [ColumnName(@"Varikoz")]
        // public float[] Varikoz { get; set; }
        //
        // [ColumnName(@"Uplotnenie")]
        // public float[] Uplotnenie { get; set; }
        //
        // [ColumnName(@"Potemnenie")]
        // public float[] Potemnenie { get; set; }
        //
        // [ColumnName(@"ZazhivshayaYazva")]
        // public float[] ZazhivshayaYazva { get; set; }
        //
        // [ColumnName(@"OtkritayaYazva")]
        // public float[] OtkritayaYazva { get; set; }
        //
        // [ColumnName(@"OtekiEst")]
        // public float[] OtekiEst { get; set; }
        //
        // [ColumnName(@"GlubokieVeniProhodimi")]
        // public float[] GlubokieVeniProhodimi { get; set; }
        //
        // [ColumnName(@"Tromboflebit")]
        // public float[] Tromboflebit { get; set; }
        //
        // [ColumnName(@"Boleznennost")]
        // public float[] Boleznennost { get; set; }
        //
        // [ColumnName(@"Bedro")]
        // public float[] Bedro { get; set; }
        //
        // [ColumnName(@"Golen")]
        // public float[] Golen { get; set; }
        //
        // [ColumnName(@"Stopa")]
        // public float[] Stopa { get; set; }
        //
        // [ColumnName(@"Bedro2")]
        // public float[] Bedro2 { get; set; }
        //
        // [ColumnName(@"Golen2")]
        // public float[] Golen2 { get; set; }
        //
        // [ColumnName(@"Stopa2")]
        // public float[] Stopa2 { get; set; }
        //
        // [ColumnName(@"NesostVeni")]
        // public float[] NesostVeni { get; set; }
        //
        // [ColumnName(@"Reflux")]
        // public float[] Reflux { get; set; }
        //
        // [ColumnName(@"Diameter")]
        // public float Diameter { get; set; }
        //
        // [ColumnName(@"Reflux2")]
        // public float[] Reflux2 { get; set; }
        //
        // [ColumnName(@"PredostSegment")]
        // public float PredostSegment { get; set; }
        //
        // [ColumnName(@"SredTretBedra")]
        // public float SredTretBedra { get; set; }
        //
        // [ColumnName(@"UrovenKolena")]
        // public float UrovenKolena { get; set; }
        //
        // [ColumnName(@"VerhSredTretGoleni")]
        // public float VerhSredTretGoleni { get; set; }
        //
        // [ColumnName(@"Reflux3")]
        // public float[] Reflux3 { get; set; }
        //
        // [ColumnName(@"Diameter2")]
        // public float Diameter2 { get; set; }
        //
        // [ColumnName(@"Reflux4")]
        // public float[] Reflux4 { get; set; }
        //
        // [ColumnName(@"Diameter3")]
        // public float Diameter3 { get; set; }
        //
        // [ColumnName(@"EvlkBpv")]
        // public bool EvlkBpv { get; set; }
        //
        // [ColumnName(@"Scler")]
        // public bool Scler { get; set; }
        //
        // [ColumnName(@"EvlkMpv")]
        // public bool EvlkMpv { get; set; }

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