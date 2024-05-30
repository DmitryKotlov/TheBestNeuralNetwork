using System.ComponentModel;

namespace TheBestDomain
{
    public class DataForModel
    {
        public int Gender { get; set; }
        public int Age { get; set; }

        public required Complaints Complaints { get; set; }
        public required Localizations Localizations { get; set; }
        public required Uzi Uzi { get; set; }
        public required Operations Operations { get; set; }
    }

    public class Complaints
    {
        public bool Varikoz { get; set; }
        public bool Uplotnenie { get; set; }
        public bool Potemnenie { get; set; }
        public bool ZazhivshayaYazva { get; set; }
        public bool OtkritayaYazva { get; set; }
    }

    public class Localizations
    {
        public bool OtekiEst { get; set; }
        public bool? GlubokieVeniProhodimi { get; set; }
        public bool? Tromboflebit { get; set; }
        public bool? Boleznennost { get; set; }

        public required Localization VarikozLocalization { get; set; }
        public required Localization TeleoangioektaziiLocalization { get; set; }
    }

    public class Localization
    {
        public bool IsAny { get; set; }
        public bool Bedro { get; set; }
        public bool Golen { get; set; }
        public bool Stopa { get; set; }
    }

    public class Uzi
    {
        public bool NesostVeni { get; set; }
        public required UziData Sfs { get; set; }
        public required UziDataExtended Bpv { get; set; }
        public required UziData Sps { get; set; }
        public required UziData Mpv { get; set; }
    }

    public class UziData
    {
        public bool Reflux { get; set; }
        public float? Diameter { get; set; }
    }

    //public class Diameter
    //{
    //    public float? Value { get; set; }
    //}

    public class UziDataExtended
    {
        public bool Reflux { get; set; }
        public float? PredostSegment { get; set; }
        public float? SredTretBedra { get; set; }
        public float? UrovenKolena { get; set; }
        public float? VerhSredTretGoleni { get; set; }
    }

    public class Operations
    {
        [Description("ЭВЛК МПВ")]
        public bool EvlkMpv { get; set; }
        [Description("ЭВЛК БПВ")]
        public bool EvlkBpv { get; set; }
        [Description("РЧО")]
        public bool Rho { get; set; }
        [Description("ЛОКАЛЬНАЯ ФЛЕБЭКТОМИЯ")]
        public bool LocalFleb { get; set; }
        [Description("ФЛЕБЭКТОМИЯ")]
        public bool Fleb { get; set; }
        [Description("КРОССЭКТОМИЯ")]
        public bool Cross { get; set; }
        [Description("СКЛЕРОТЕРАПИЯ")]
        public bool Scler { get; set; }
        public bool IsNeedAnyOperation { get; set; }
    }
}