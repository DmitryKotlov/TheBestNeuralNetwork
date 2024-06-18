using Microsoft.ML.Data;

namespace TheBestWebInterfaceRazorPages.ML
{
    public class ModelInput
    {
        [LoadColumn(0)]
        [ColumnName(@"Gender")]
        public float Gender { get; set; }

        [LoadColumn(1)]
        [ColumnName(@"Age")]
        public float Age { get; set; }

        [LoadColumn(2)]
        [ColumnName(@"Varikoz")]
        public bool Varikoz { get; set; }

        [LoadColumn(3)]
        [ColumnName(@"Uplotnenie")]
        public bool Uplotnenie { get; set; }

        [LoadColumn(4)]
        [ColumnName(@"Potemnenie")]
        public bool Potemnenie { get; set; }

        [LoadColumn(5)]
        [ColumnName(@"ZazhivshayaYazva")]
        public bool ZazhivshayaYazva { get; set; }

        [LoadColumn(6)]
        [ColumnName(@"OtkritayaYazva")]
        public bool OtkritayaYazva { get; set; }

        [LoadColumn(7)]
        [ColumnName(@"OtekiEst")]
        public bool OtekiEst { get; set; }

        [LoadColumn(8)]
        [ColumnName(@"GlubokieVeniProhodimi")]
        public bool GlubokieVeniProhodimi { get; set; }

        [LoadColumn(9)]
        [ColumnName(@"Tromboflebit")]
        public bool Tromboflebit { get; set; }

        [LoadColumn(10)]
        [ColumnName(@"Boleznennost")]
        public bool Boleznennost { get; set; }

        [LoadColumn(12)]
        [ColumnName(@"Bedro")]
        public bool Bedro { get; set; }

        [LoadColumn(13)]
        [ColumnName(@"Golen")]
        public bool Golen { get; set; }

        [LoadColumn(14)]
        [ColumnName(@"Stopa")]
        public bool Stopa { get; set; }

        [LoadColumn(16)]
        [ColumnName(@"Bedro2")]
        public bool Bedro2 { get; set; }

        [LoadColumn(17)]
        [ColumnName(@"Golen2")]
        public bool Golen2 { get; set; }

        [LoadColumn(18)]
        [ColumnName(@"Stopa2")]
        public bool Stopa2 { get; set; }

        [LoadColumn(19)]
        [ColumnName(@"NesostVeni")]
        public bool NesostVeni { get; set; }

        [LoadColumn(20)]
        [ColumnName(@"Reflux")]
        public bool Reflux { get; set; }

        [LoadColumn(21)]
        [ColumnName(@"Diameter")]
        public float Diameter { get; set; }

        [LoadColumn(22)]
        [ColumnName(@"Reflux2")]
        public bool Reflux2 { get; set; }

        [LoadColumn(23)]
        [ColumnName(@"PredostSegment")]
        public float PredostSegment { get; set; }

        [LoadColumn(24)]
        [ColumnName(@"SredTretBedra")]
        public float SredTretBedra { get; set; }

        [LoadColumn(25)]
        [ColumnName(@"UrovenKolena")]
        public float UrovenKolena { get; set; }

        [LoadColumn(26)]
        [ColumnName(@"VerhSredTretGoleni")]
        public float VerhSredTretGoleni { get; set; }

        [LoadColumn(27)]
        [ColumnName(@"Reflux3")]
        public bool Reflux3 { get; set; }

        [LoadColumn(28)]
        [ColumnName(@"Diameter2")]
        public float Diameter2 { get; set; }

        [LoadColumn(29)]
        [ColumnName(@"Reflux4")]
        public bool Reflux4 { get; set; }

        [LoadColumn(30)]
        [ColumnName(@"Diameter3")]
        public float Diameter3 { get; set; }
    }
}