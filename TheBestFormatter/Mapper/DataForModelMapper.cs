using System.Text.RegularExpressions;
using TheBestDomain;
using TheBestNeuralNetwork.Model;

namespace TheBestFormatter.Mapper
{
    public static class DataForModelMapper
    {
        public static (DataForModel, DataForModel) Map(ParamStr perv, ParamStr uzi)
        {
            var leftDataForModel = new DataForModel
            {
                perv_n3goleni = perv.MEDSPINEDIT14.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT14.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_n3bedra = perv.MEDSPINEDIT15.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT15.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_s3goleni = perv.MEDSPINEDIT16.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT16.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_s3bedra = perv.MEDSPINEDIT17.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT17.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_v3goleni = perv.MEDSPINEDIT18.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT18.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_v3bedra = perv.MEDSPINEDIT19.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT19.MEDPARAMSTR.ParamStr.VALUE
                    : null,

                perv_localis_OtekiEst = perv.MEDCHECKBOX53.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVen = perv.MEDCHECKBOX75.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenBedro = perv.MEDCHECKBOX76.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenGolen = perv.MEDCHECKBOX77.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenStopa = perv.MEDCHECKBOX80.MEDPARAMSTR.ParamStr.CHECKED,

                perv_localis_LokalizaciaTeleoangioektazii = perv.MEDCHECKBOX83.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiBedro = perv.MEDCHECKBOX87.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiGolen = perv.MEDCHECKBOX88.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiStopa = perv.MEDCHECKBOX89.MEDPARAMSTR.ParamStr.CHECKED,

                perv_complains_varikoz = perv.MEDCHECKBOX55.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_uplotnenie = perv.MEDCHECKBOX20.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_potemnenie = perv.MEDCHECKBOX21.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_zazhivshayaYazva = perv.MEDCHECKBOX22.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_otkritayaYazva = perv.MEDCHECKBOX23.MEDPARAMSTR.ParamStr.CHECKED,

                uzi_NesostVeni = uzi.MEDCHECKBOX11.MEDPARAMSTR.ParamStr.CHECKED
            };

            var leftSfs = MapUzi(uzi.MEDMEMO3.MEDPARAMSTR.ParamStr.LINES);
            leftDataForModel.uzi_SfsDiameter = leftSfs.Item1;
            leftDataForModel.uzi_SfsReflux = leftSfs.Item2;

            var leftBpv = MapUzi(uzi.MEDMEMO5.MEDPARAMSTR.ParamStr.LINES);
            leftDataForModel.uzi_BpvDiameter = leftBpv.Item1;
            leftDataForModel.uzi_BpvReflux = leftBpv.Item2;

            var leftSps = MapUzi(uzi.MEDMEMO7.MEDPARAMSTR.ParamStr.LINES);
            leftDataForModel.uzi_SpsDiameter = leftSps.Item1;
            leftDataForModel.uzi_SpsReflux = leftSps.Item2;

            var leftMpv = MapUzi(uzi.MEDMEMO9.MEDPARAMSTR.ParamStr.LINES);
            leftDataForModel.uzi_MpvDiameter = leftMpv.Item1;
            leftDataForModel.uzi_MpvReflux = leftMpv.Item2;

            var rightDataForModel = new DataForModel
            {
                perv_n3goleni = perv.MEDSPINEDIT7.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT7.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_n3bedra = perv.MEDSPINEDIT8.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT8.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_s3goleni = perv.MEDSPINEDIT9.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT9.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_s3bedra = perv.MEDSPINEDIT10.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT10.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_v3goleni = perv.MEDSPINEDIT11.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT11.MEDPARAMSTR.ParamStr.VALUE
                    : null,
                perv_v3bedra = perv.MEDSPINEDIT12.MEDPARAMSTR.ParamStr.VALUE != 0
                    ? perv.MEDSPINEDIT12.MEDPARAMSTR.ParamStr.VALUE
                    : null,

                perv_localis_OtekiEst = perv.MEDCHECKBOX49.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVen = perv.MEDCHECKBOX74.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenBedro = perv.MEDCHECKBOX78.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenGolen = perv.MEDCHECKBOX79.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenStopa = perv.MEDCHECKBOX81.MEDPARAMSTR.ParamStr.CHECKED,

                perv_localis_LokalizaciaTeleoangioektazii = perv.MEDCHECKBOX82.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiBedro = perv.MEDCHECKBOX84.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiGolen = perv.MEDCHECKBOX85.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiStopa = perv.MEDCHECKBOX86.MEDPARAMSTR.ParamStr.CHECKED,

                perv_complains_varikoz = perv.MEDCHECKBOX54.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_uplotnenie = perv.MEDCHECKBOX9.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_potemnenie = perv.MEDCHECKBOX10.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_zazhivshayaYazva = perv.MEDCHECKBOX11.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_otkritayaYazva = perv.MEDCHECKBOX12.MEDPARAMSTR.ParamStr.CHECKED,

                uzi_NesostVeni = uzi.MEDCHECKBOX10.MEDPARAMSTR.ParamStr.CHECKED,
            };

            var rightSfs = MapUzi(uzi.MEDMEMO2.MEDPARAMSTR.ParamStr.LINES);
            rightDataForModel.uzi_SfsDiameter = rightSfs.Item1;
            rightDataForModel.uzi_SfsReflux = rightSfs.Item2;

            var rightBpv = MapUzi(uzi.MEDMEMO4.MEDPARAMSTR.ParamStr.LINES);
            rightDataForModel.uzi_BpvDiameter = rightBpv.Item1;
            rightDataForModel.uzi_BpvReflux = rightBpv.Item2;

            var rightSps = MapUzi(uzi.MEDMEMO6.MEDPARAMSTR.ParamStr.LINES);
            rightDataForModel.uzi_SpsDiameter = rightSps.Item1;
            rightDataForModel.uzi_SpsReflux = rightSps.Item2;

            var rightMpv = MapUzi(uzi.MEDMEMO8.MEDPARAMSTR.ParamStr.LINES);
            rightDataForModel.uzi_MpvDiameter = rightMpv.Item1;
            rightDataForModel.uzi_MpvReflux = rightMpv.Item2;

            FillCommonProperty(leftDataForModel, rightDataForModel, perv);
            FillOperationData(perv.MEDMEMO27.MEDPARAMSTR.ParamStr.LINES, leftDataForModel, rightDataForModel);

            return (leftDataForModel, rightDataForModel);
        }

        private static (string?, bool?) MapUzi(string memo)
        {
            var strings = memo.Trim().ToUpper().Replace(".", ",").Replace(" ", "").Replace("/", "-").Split(@"\R\N");

            string? diameter = null;
            bool? reflux = null;

            foreach (var subString in strings)
            {
                if (reflux is null)
                {
                    if (subString.Contains("ДИАМЕТР"))
                    {
                        var index = subString.IndexOf("ДИАМЕТР");
                        diameter = subString.Substring(index);

                        diameter = Regex.Replace(diameter, "[^0-9,-]", "");
                    }
                }

                if (subString.Contains("РЕФЛЮКС"))
                {
                    if (subString.Contains("+"))
                    {
                        reflux = true;
                    }
                    else if (subString.Contains("-"))
                    {
                        reflux = false;
                    }
                }
            }

            return (diameter, reflux);
        }

        private static void FillCommonProperty(DataForModel leftDataForModel, DataForModel rightDataForModel,
            ParamStr perv)
        {
            leftDataForModel.perv_localis_VarikoznieVeni = rightDataForModel.perv_localis_VarikoznieVeni =
                perv.MEDCHECKBOX50.MEDPARAMSTR.ParamStr.CHECKED;
            leftDataForModel.perv_localis_Teleangioektazii = rightDataForModel.perv_localis_Teleangioektazii =
                perv.MEDCHECKBOX51.MEDPARAMSTR.ParamStr.CHECKED;

            leftDataForModel.perv_localis_GlubokieVeniProhodimi = rightDataForModel.perv_localis_GlubokieVeniProhodimi =
                MapBoolProperty(perv.MEDCHECKBOX34.MEDPARAMSTR.ParamStr.CHECKED,
                    perv.MEDCHECKBOX35.MEDPARAMSTR.ParamStr.CHECKED);
            leftDataForModel.perv_localis_Tromboflebit = rightDataForModel.perv_localis_Tromboflebit =
                MapBoolProperty(perv.MEDCHECKBOX38.MEDPARAMSTR.ParamStr.CHECKED,
                    perv.MEDCHECKBOX39.MEDPARAMSTR.ParamStr.CHECKED);
            leftDataForModel.perv_localis_Boleznennost = rightDataForModel.perv_localis_Boleznennost =
                MapBoolProperty(perv.MEDCHECKBOX40.MEDPARAMSTR.ParamStr.CHECKED,
                    perv.MEDCHECKBOX41.MEDPARAMSTR.ParamStr.CHECKED);
        }

        private static bool? MapBoolProperty(int? yes, int? no)
        {
            if (yes == 1)
            {
                return true;
            }
            else if (no == 1)
            {
                return false;
            }

            return null;
        }

        private static void FillOperationData(string tactics, DataForModel leftDataForModel,
            DataForModel rightDataForModel)
        {
            var regexTactics = Regex.Replace(tactics, "[^A-Za-zA-Яа-я]", "");
            var strings = regexTactics.Trim().ToUpper().Split(@"\R\N");

            foreach (var subString in strings)
            {
                if (subString.Contains("СЛЕВА"))
                {
                    FillOperationData(subString, leftDataForModel);
                }

                if (subString.Contains("СПРАВА"))
                {
                    FillOperationData(subString, rightDataForModel);
                }
            }
        }

        private static void FillOperationData(string tactic, DataForModel dataForModel)
        {
            if (tactic.Contains("ЭВЛК"))
            {
                if (tactic.Contains("МПВ"))
                {
                    dataForModel.EvlkMpv = true;
                }

                if (tactic.Contains("БПВ"))
                {
                    dataForModel.EvlkBpv = true;
                }
            }

            if (tactic.Contains("РЧО"))
            {
                dataForModel.Rho = true;
            }

            if (tactic.Contains("ЛОКАЛЬНАЯФЛЕБЭКТОМИЯ"))
            {
                dataForModel.LocalFleb = true;
                tactic = tactic.Replace("ЛОКАЛЬНАЯФЛЕБЭКТОМИЯ", "");
            }

            if (tactic.Contains("ФЛЕБЭКТОМИЯ"))
            {
                dataForModel.Fleb = true;
            }

            if (tactic.Contains("КРОССЭКТОМИЯ"))
            {
                dataForModel.Cross = true;
            }

            if (tactic.Contains("СКЛЕРОТЕРАПИЯ"))
            {
                dataForModel.Scler = true;
            }
        }
    }
}