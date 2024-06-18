using System.ComponentModel.DataAnnotations;

namespace TheBestWebInterfaceRazorPages.ViewModels
{
    public class DataForModelViewModel
    {
        //[Required(ErrorMessage = "Поле обязательно для заполнения")]
        //[Range(0, 150, ErrorMessage = "Значение должно быть в диапазоне от 0 до 150")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Пол")]
        public Gender Gender { get; set; }

        public ComplaintsViewModel Complaints { get; set; }
        public LocalizationsViewModel Localizations { get; set; }
        public UziViewModel Uzi { get; set; }
        public ICollection<PredictViewModel> Result { get; set; } = new List<PredictViewModel>();
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
        [Display(Name = "Варикозные вены")]
        public bool Varikoz { get; set; }

        [Display(Name = "Уплотнение кожи на голени")]
        public bool Uplotnenie { get; set; }

        [Display(Name = "Потемнение кожи на голени")]
        public bool Potemnenie { get; set; }

        [Display(Name = "Зажившая трофическая язва")]
        public bool ZazhivshayaYazva { get; set; }

        [Display(Name = "Открытая трофическая язва")]
        public bool OtkritayaYazva { get; set; }
    }

    public class LocalizationsViewModel
    {
        [Display(Name = "Отеки")]
        public bool OtekiEst { get; set; }

        [Display(Name = "Глубокие вены проходимы")]
        public bool GlubokieVeniProhodimi { get; set; }

        [Display(Name = "Тромбофлебит")]
        public bool Tromboflebit { get; set; }

        [Display(Name = "Болезненность")]
        public bool Boleznennost { get; set; }

        public required LocalizationViewModel VarikozLocalization { get; set; }
        public required LocalizationViewModel TeleoangioektaziiLocalization { get; set; }
    }

    public class LocalizationViewModel
    {
        [Display(Name = "Бедро")]
        public bool Bedro { get; set; }

        [Display(Name = "Голень")]
        public bool Golen { get; set; }

        [Display(Name = "Стопа")]
        public bool Stopa { get; set; }
    }

    public class UziViewModel
    {
        [Display(Name = "Несостоятельные вены")]
        public bool NesostVeni { get; set; }

        public required UziData Sfs { get; set; }
        public required UziDataExtended Bpv { get; set; }
        public required UziData Sps { get; set; }
        public required UziData Mpv { get; set; }
    }

    public class UziData
    {
        [Display(Name = "Рефлюкс")]
        public bool Reflux { get; set; }

        // [Required]
        // [Range(0, 35, ErrorMessage = "Значение должно быть в диапазоне от 0 до 35")]
        // [Required]
        // [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        [Display(Name = "Диаметр(мм)")]
        public float Value { get; set; }
    }

    public class UziDataExtended
    {
        [Required]
        [Display(Name = "Рефлюкс")]
        public bool Reflux { get; set; }

        // [Required]
        // [Range(0, 35, ErrorMessage = "Значение должно быть в диапазоне от 0 до 35")]
        [Display(Name = "Преостьевой")]
        public float PredostSegment { get; set; }

        // [Required]
        // [Range(0, 35, ErrorMessage = "Значение должно быть в диапазоне от 0 до 35")]
        [Display(Name = "Ср. треть бедра")]
        public float SredTretBedra { get; set; }
        //
        // [Required]
        // [Range(0, 35, ErrorMessage = "Значение должно быть в диапазоне от 0 до 35")]
        [Display(Name = "Уровень колена")]
        public float UrovenKolena { get; set; }

        // [Required]
        // [Range(0, 35, ErrorMessage = "Значение должно быть в диапазоне от 0 до 35")]
        [Display(Name = "Верх. ср. треть голени")]
        public float VerhSredTretGoleni { get; set; }
    }
}
