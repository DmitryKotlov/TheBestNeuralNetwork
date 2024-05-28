using System.ComponentModel;

namespace TheBestDomain
{
    public class DataForModel
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

        // Общие

        public int? perv_localis_VarikoznieVeni { get; set; }
        public int? perv_localis_Teleangioektazii { get; set; }
        public bool? perv_localis_GlubokieVeniProhodimi { get; set; }
        public bool? perv_localis_Tromboflebit { get; set; }
        public bool? perv_localis_Boleznennost { get; set; }

        //

        public int? perv_n3goleni { get; set; }
        public int? perv_n3bedra { get; set; }
        public int? perv_s3goleni { get; set; }
        public int? perv_s3bedra { get; set; }
        public int? perv_v3goleni { get; set; }
        public int? perv_v3bedra { get; set; }

        public int? perv_localis_OtekiEst { get; set; }
        public int? perv_localis_LokalizaciaVarikozVen { get; set; }
        public int? perv_localis_LokalizaciaVarikozVenBedro { get; set; }
        public int? perv_localis_LokalizaciaVarikozVenGolen { get; set; }
        public int? perv_localis_LokalizaciaVarikozVenStopa { get; set; }

        public int? perv_localis_LokalizaciaTeleoangioektazii { get; set; }
        public int? perv_localis_LokalizaciaTeleoangioektaziiBedro { get; set; }
        public int? perv_localis_LokalizaciaTeleoangioektaziiGolen { get; set; }
        public int? perv_localis_LokalizaciaTeleoangioektaziiStopa { get; set; }

        public int? perv_complains_varikoz { get; set; }
        public int? perv_complains_uplotnenie { get; set; }
        public int? perv_complains_potemnenie { get; set; }
        public int? perv_complains_zazhivshayaYazva { get; set; }
        public int? perv_complains_otkritayaYazva { get; set; }

        public string uzi_SfsDiameter { get; set; }
        public bool? uzi_SfsReflux { get; set; }
        public string uzi_BpvDiameter { get; set; }
        public bool? uzi_BpvReflux { get; set; }
        public string uzi_SpsDiameter { get; set; }
        public bool? uzi_SpsReflux { get; set; }
        public string uzi_MpvDiameter { get; set; }
        public bool? uzi_MpvReflux { get; set; }
        public int? uzi_NesostVeni { get; set; }
    }
}