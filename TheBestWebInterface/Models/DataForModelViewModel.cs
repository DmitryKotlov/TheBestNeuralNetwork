using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TheBestWebInterface.Models
{
    public class DataForModelViewModel
    {
        //[System.ComponentModel.DataAnnotations.]
        [Required]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Пол")]
        public Gender Gender { get; set; }
        public required ComplaintsViewModel Complaints { get; set; }
        public required LocalizationsViewModel Localizations { get; set; }
        public required UziViewModel Uzi { get; set; }

        //[BindProperty]
        public string Result { get; set; }
    }

    public enum Gender
    {
        [Display(Name = "Мужской")]
        Male = 0,
        [Display(Name = "Женский")]
        Female = 1
    }

    public class ComplaintsViewModel
    {
        [Required]
        [Display(Name = "Варикозные вены")]
        public bool Varikoz { get; set; }
        [Required]
        [Display(Name = "Уплотнение кожи на голени")]
        public bool Uplotnenie { get; set; }
        [Required]
        [Display(Name = "Потемнение кожи на голени")]
        public bool Potemnenie { get; set; }
        [Required]
        [Display(Name = "Зажившая трофическая язва")]
        public bool ZazhivshayaYazva { get; set; }
        [Required]
        [Display(Name = "Открытая трофическая язва")]
        public bool OtkritayaYazva { get; set; }
    }

    public class LocalizationsViewModel
    {
        [Required]
        [Display(Name = "Отеки")]
        public bool OtekiEst { get; set; }
        [Required]
        [Display(Name = "Глубокие вены проходимы")]
        public bool GlubokieVeniProhodimi { get; set; }
        [Required]
        [Display(Name = "Тромбофлебит")]
        public bool Tromboflebit { get; set; }
        [Required]
        [Display(Name = "Болезненность")]
        public bool Boleznennost { get; set; }

        public required LocalizationViewModel VarikozLocalization { get; set; }
        public required LocalizationViewModel TeleoangioektaziiLocalization { get; set; }
    }

    public class LocalizationViewModel
    {
        public bool IsAny { get; set; }
        [Required]
        [Display(Name = "Бедро")]
        public bool Bedro { get; set; }
        [Required]
        [Display(Name = "Голень")]
        public bool Golen { get; set; }
        [Required]
        [Display(Name = "Стопа")]
        public bool Stopa { get; set; }
    }

    public class UziViewModel
    {
        [Required]
        [Display(Name = "Несостоятельные вены")]
        public bool NesostVeni { get; set; }
        public required UziData Sfs { get; set; }
        public required UziDataExtended Bpv { get; set; }
        public required UziData Sps { get; set; }
        public required UziData Mpv { get; set; }
    }

    public class UziData
    {
        [Required]
        [Display(Name = "Рефлюкс")]
        public bool Reflux { get; set; }
        [Required]
        [Display(Name = "Диаметр(мм)")]
        public float Value { get; set; }
    }

    public class UziDataExtended
    {
        [Required]
        [Display(Name = "Рефлюкс")]
        public bool Reflux { get; set; }
        [Required]
        [Display(Name = "Преостьевой")]
        public float PredostSegment { get; set; }
        [Required]
        [Display(Name = "Ср. треть бедра")]
        public float SredTretBedra { get; set; }
        [Required]
        [Display(Name = "Уровень колена")]
        public float UrovenKolena { get; set; }
        [Required]
        [Display(Name = "Верх. ср. треть голени")]
        public float VerhSredTretGoleni { get; set; }
    }

    //public class OperationsViewModel
    //{
    //    [Description("ЭВЛК МПВ")]
    //    public bool EvlkMpv { get; set; }
    //    [Description("ЭВЛК БПВ")]
    //    public bool EvlkBpv { get; set; }
    //    [Description("РЧО")]
    //    public bool Rho { get; set; }
    //    [Description("ЛОКАЛЬНАЯ ФЛЕБЭКТОМИЯ")]
    //    public bool LocalFleb { get; set; }
    //    [Description("ФЛЕБЭКТОМИЯ")]
    //    public bool Fleb { get; set; }
    //    [Description("КРОССЭКТОМИЯ")]
    //    public bool Cross { get; set; }
    //    [Description("СКЛЕРОТЕРАПИЯ")]
    //    public bool Scler { get; set; }
    //    public bool IsNeedAnyOperation { get; set; }
    //}
}
