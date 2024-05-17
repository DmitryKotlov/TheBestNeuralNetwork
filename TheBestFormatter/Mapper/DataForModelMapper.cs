using TheBestDomain;
using TheBestNeuralNetwork.Model;

namespace TheBestFormatter.Mapper
{
    public static class DataForModelMapper
    {
        public static DataForModel Map(ParamStr perv, ParamStr uzi)
        {
            return new DataForModel
            {
                perv_Taktika = perv.MEDMEMO27.MEDPARAMSTR.ParamStr.LINES,

                perv_n3goleniSprava = perv.MEDSPINEDIT7.MEDPARAMSTR.ParamStr.VALUE,
                perv_n3bedraSprava = perv.MEDSPINEDIT8.MEDPARAMSTR.ParamStr.VALUE,
                perv_s3goleniSprava = perv.MEDSPINEDIT9.MEDPARAMSTR.ParamStr.VALUE,
                perv_s3bedraSprava = perv.MEDSPINEDIT10.MEDPARAMSTR.ParamStr.VALUE,
                perv_v3goleniSprava = perv.MEDSPINEDIT11.MEDPARAMSTR.ParamStr.VALUE,
                perv_v3bedraSprava = perv.MEDSPINEDIT12.MEDPARAMSTR.ParamStr.VALUE, //Где 13?
                perv_n3goleniSleva = perv.MEDSPINEDIT14.MEDPARAMSTR.ParamStr.VALUE,
                perv_n3bedraSleva = perv.MEDSPINEDIT15.MEDPARAMSTR.ParamStr.VALUE,
                perv_s3goleniSleva = perv.MEDSPINEDIT16.MEDPARAMSTR.ParamStr.VALUE,
                perv_s3bedraSleva = perv.MEDSPINEDIT17.MEDPARAMSTR.ParamStr.VALUE,
                perv_v3goleniSleva = perv.MEDSPINEDIT18.MEDPARAMSTR.ParamStr.VALUE,
                perv_v3bedraSleva = perv.MEDSPINEDIT19.MEDPARAMSTR.ParamStr.VALUE,

                perv_localis_OtekiSpravaEst = perv.MEDCHECKBOX49.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_OtekiSlevaEst = perv.MEDCHECKBOX53.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_VarikoznieVeni = perv.MEDCHECKBOX50.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_Teleangioektazii = perv.MEDCHECKBOX51.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSprava = perv.MEDCHECKBOX74.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSleva = perv.MEDCHECKBOX75.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSpravaBedro = perv.MEDCHECKBOX78.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSlevaBedro = perv.MEDCHECKBOX76.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSpravaGolen = perv.MEDCHECKBOX79.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSlevaGolen = perv.MEDCHECKBOX77.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSpravaStopa = perv.MEDCHECKBOX81.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaVarikozVenSlevaStopa = perv.MEDCHECKBOX80.MEDPARAMSTR.ParamStr.CHECKED,

                perv_localis_LokalizaciaTeleoangioektaziiSprava = perv.MEDCHECKBOX82.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSleva = perv.MEDCHECKBOX83.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSpravaBedro = perv.MEDCHECKBOX84.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSlevaBedro = perv.MEDCHECKBOX87.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSpravaGolen = perv.MEDCHECKBOX85.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSlevaGolen = perv.MEDCHECKBOX88.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSpravaStopa = perv.MEDCHECKBOX86.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_LokalizaciaTeleoangioektaziiSlevaStopa = perv.MEDCHECKBOX89.MEDPARAMSTR.ParamStr.CHECKED,

                perv_localis_GlubokieVeniProhodimiYes = perv.MEDCHECKBOX34.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_GlubokieVeniProhodimiNo = perv.MEDCHECKBOX35.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_TromboflebitYes = perv.MEDCHECKBOX38.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_TromboflebitNo = perv.MEDCHECKBOX39.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_BoleznennostYes = perv.MEDCHECKBOX40.MEDPARAMSTR.ParamStr.CHECKED,
                perv_localis_BoleznennostNo = perv.MEDCHECKBOX41.MEDPARAMSTR.ParamStr.CHECKED,

                perv_complains_varikozSprava = perv.MEDCHECKBOX54.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_varikozSleva = perv.MEDCHECKBOX55.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_uplotnenieSprava = perv.MEDCHECKBOX9.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_potemnenieSprava = perv.MEDCHECKBOX10.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_zazhivshayaYazvaSprava = perv.MEDCHECKBOX11.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_otkritayaYazvaSprava = perv.MEDCHECKBOX12.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_uplotnenieSleva = perv.MEDCHECKBOX20.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_potemnenieSleva = perv.MEDCHECKBOX21.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_zazhivshayaYazvaSleva = perv.MEDCHECKBOX22.MEDPARAMSTR.ParamStr.CHECKED,
                perv_complains_otkritayaYazvaSleva = perv.MEDCHECKBOX23.MEDPARAMSTR.ParamStr.CHECKED,

                uzi_SFSMemoPravaya = uzi.MEDMEMO2.MEDPARAMSTR.ParamStr.LINES,
                uzi_SFSMemoLevaya = uzi.MEDMEMO3.MEDPARAMSTR.ParamStr.LINES,

                uzi_BPVMemoPravaya = uzi.MEDMEMO4.MEDPARAMSTR.ParamStr.LINES,
                uzi_BPVMemoLevaya = uzi.MEDMEMO5.MEDPARAMSTR.ParamStr.LINES,

                uzi_SPSMemoPravaya = uzi.MEDMEMO6.MEDPARAMSTR.ParamStr.LINES,
                uzi_SPSMemoLevaya = uzi.MEDMEMO7.MEDPARAMSTR.ParamStr.LINES,

                uzi_MPVMemoPravaya = uzi.MEDMEMO8.MEDPARAMSTR.ParamStr.LINES,
                uzi_MPVMemoLevaya = uzi.MEDMEMO9.MEDPARAMSTR.ParamStr.LINES,

                uzi_perfVeniPravaya = uzi.MEDMEMO13.MEDPARAMSTR.ParamStr.LINES,
                uzi_perfVeniLevaya = uzi.MEDMEMO14.MEDPARAMSTR.ParamStr.LINES,

                uzi_NesostVeniCheckBoxPravaya = uzi.MEDCHECKBOX10.MEDPARAMSTR.ParamStr.CHECKED,
                uzi_NesostVeniCheckBoxLevaya = uzi.MEDCHECKBOX11.MEDPARAMSTR.ParamStr.CHECKED
            };
        }
    }
}
