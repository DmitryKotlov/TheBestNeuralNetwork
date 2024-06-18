using TheBestDomain;
using TheBestFormatter.Model;

namespace TheBestFormatter.Mapper
{
    public static class DataForModelMapper
    {
        public static IEnumerable<DataForModel> Map(PARAM_STR perv, PARAM_STR uzi, int age, int gender)
        {
            var dataForModels = new[]
            {
                MapDataForLeftLeg(perv, uzi),
                MapDataForRightLeg(perv, uzi)
            };

            FillCommonProperties(dataForModels, perv, age, gender);

            return dataForModels;
        }

        private static DataForModel MapDataForLeftLeg(PARAM_STR perv, PARAM_STR uzi)
        {
            var leftDataForModel = new DataForModel
            {
                Complaints = new Complaints
                {
                    Varikoz = perv.Medcheckbox55.Medparamstr.ParamStr.Checked,
                    Uplotnenie = perv.Medcheckbox20.Medparamstr.ParamStr.Checked,
                    Potemnenie = perv.Medcheckbox21.Medparamstr.ParamStr.Checked,
                    ZazhivshayaYazva = perv.Medcheckbox22.Medparamstr.ParamStr.Checked,
                    OtkritayaYazva = perv.Medcheckbox23.Medparamstr.ParamStr.Checked
                },
                Localizations = new Localizations
                {
                    OtekiEst = perv.Medcheckbox53.Medparamstr.ParamStr.Checked,
                    VarikozLocalization = new Localization
                    {
                        IsAny = perv.Medcheckbox75.Medparamstr.ParamStr.Checked,
                        Bedro = perv.Medcheckbox76.Medparamstr.ParamStr.Checked,
                        Golen = perv.Medcheckbox77.Medparamstr.ParamStr.Checked,
                        Stopa = perv.Medcheckbox80.Medparamstr.ParamStr.Checked
                    },
                    TeleoangioektaziiLocalization = new Localization
                    {
                        IsAny = perv.Medcheckbox83.Medparamstr.ParamStr.Checked,
                        Bedro = perv.Medcheckbox87.Medparamstr.ParamStr.Checked,
                        Golen = perv.Medcheckbox88.Medparamstr.ParamStr.Checked,
                        Stopa = perv.Medcheckbox89.Medparamstr.ParamStr.Checked
                    }
                },
                Uzi = new Uzi
                {
                    NesostVeni = uzi.Medcheckbox11.Medparamstr.ParamStr.Checked,
                    Sfs = UziMapper.Map(uzi.Medmemo3.Medparamstr.ParamStr.Lines),
                    Bpv = UziMapper.Map(uzi.Medmemo5.Medparamstr.ParamStr.Lines, true),
                    Sps = UziMapper.Map(uzi.Medmemo7.Medparamstr.ParamStr.Lines),
                    Mpv = UziMapper.Map(uzi.Medmemo9.Medparamstr.ParamStr.Lines)
                },
                Operations = OperationsMapper.Map(perv.Medmemo27.Medparamstr.ParamStr.Lines, true)
            };

            return leftDataForModel;
        }

        private static DataForModel MapDataForRightLeg(PARAM_STR perv, PARAM_STR uzi)
        {
            var rightDataForModel = new DataForModel
            {
                Complaints = new Complaints
                {
                    Varikoz = perv.Medcheckbox54.Medparamstr.ParamStr.Checked,
                    Uplotnenie = perv.Medcheckbox9.Medparamstr.ParamStr.Checked,
                    Potemnenie = perv.Medcheckbox10.Medparamstr.ParamStr.Checked,
                    ZazhivshayaYazva = perv.Medcheckbox11.Medparamstr.ParamStr.Checked,
                    OtkritayaYazva = perv.Medcheckbox12.Medparamstr.ParamStr.Checked
                },
                Localizations = new Localizations
                {
                    OtekiEst = perv.Medcheckbox49.Medparamstr.ParamStr.Checked,
                    VarikozLocalization = new Localization
                    {
                        IsAny = perv.Medcheckbox74.Medparamstr.ParamStr.Checked,
                        Bedro = perv.Medcheckbox78.Medparamstr.ParamStr.Checked,
                        Golen = perv.Medcheckbox79.Medparamstr.ParamStr.Checked,
                        Stopa = perv.Medcheckbox81.Medparamstr.ParamStr.Checked
                    },
                    TeleoangioektaziiLocalization = new Localization
                    {
                        IsAny = perv.Medcheckbox82.Medparamstr.ParamStr.Checked,
                        Bedro = perv.Medcheckbox84.Medparamstr.ParamStr.Checked,
                        Golen = perv.Medcheckbox85.Medparamstr.ParamStr.Checked,
                        Stopa = perv.Medcheckbox86.Medparamstr.ParamStr.Checked
                    }
                },
                Uzi = new Uzi
                {
                    NesostVeni = uzi.Medcheckbox10.Medparamstr.ParamStr.Checked,
                    Sfs = UziMapper.Map(uzi.Medmemo2.Medparamstr.ParamStr.Lines),
                    Bpv = UziMapper.Map(uzi.Medmemo4.Medparamstr.ParamStr.Lines, true),
                    Sps = UziMapper.Map(uzi.Medmemo6.Medparamstr.ParamStr.Lines),
                    Mpv = UziMapper.Map(uzi.Medmemo8.Medparamstr.ParamStr.Lines)
                },
                Operations = OperationsMapper.Map(perv.Medmemo27.Medparamstr.ParamStr.Lines, false)
            };

            return rightDataForModel;
        }

        private static void FillCommonProperties(IEnumerable<DataForModel> dataForModels, PARAM_STR perv, int age,
            int gender)
        {
            foreach (var dataForModel in dataForModels)
            {
                dataForModel.Age = age / 10;
                dataForModel.Gender = gender;

                dataForModel.Localizations.GlubokieVeniProhodimi = MapBoolProperty(
                    perv.Medcheckbox34.Medparamstr.ParamStr.Checked,
                    perv.Medcheckbox35.Medparamstr.ParamStr.Checked);

                dataForModel.Localizations.Tromboflebit = MapBoolProperty(
                    perv.Medcheckbox38.Medparamstr.ParamStr.Checked,
                    perv.Medcheckbox39.Medparamstr.ParamStr.Checked);

                dataForModel.Localizations.Boleznennost = MapBoolProperty(
                    perv.Medcheckbox40.Medparamstr.ParamStr.Checked,
                    perv.Medcheckbox41.Medparamstr.ParamStr.Checked);
            }
        }

        private static bool? MapBoolProperty(bool yes, bool no)
        {
            if (yes) return true;

            if (no) return false;

            return null;
        }
    }
}