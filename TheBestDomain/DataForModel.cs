namespace TheBestDomain
{
    public class DataForModel
    {
        // Первичный осмотр
        // medMemos
        public string perv_Taktika { get; set; } // Берется из xml_epmz, medMemo27.lines

        //Состоит из 3 блоков, в котором весь текст в одном поле: 
        //- общие рекомендации, которые даются всем пациентам с варикозной болезнью
        //- манипуляции(операция) на стволовых(внутренних) венах БПВ(большой подкожной вены), МПВ(малой подкожной вены), перфорантных венах.Чаще всего назначается ЭВЛК (эндовенозная лазерная коагуляция) как золотой стандарт
        //- убирание внешних вен.Склеротерапия, трансдермальная лазерная коагуляция
        //Инвазивные операции делаются крайне редко из-за тяжести восстановления пациента, затрат и их эффективности
        //Как принимается решение: врач смотрит на количество больных вен и на этой основе набирает операции.В идеале из этого поля выделить операции на внутренних венах т.к.это уже медицинское показание, операции на внешние вены по большей части желание пациента
        //Иногда прописывается в комбинациях, например, ЭВЛК(на внутренние вены) + Склеротерапия(на внешние) 10 сеансов или ЭВЛК+Локальная флебэктомия

        // medSpinEdits
        public int? perv_n3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit7.value
        public int? perv_n3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit8.value
        public int? perv_s3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit9.value
        public int? perv_s3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit10.value
        public int? perv_v3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit11.value
        public int? perv_v3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit12.value
        public int? perv_n3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit14.value
        public int? perv_n3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit15.value
        public int? perv_s3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit16.value
        public int? perv_s3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit17.value
        public int? perv_v3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit18.value
        public int? perv_v3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit19.value

        // medCheckBoxes
        public int? perv_localis_OtekiSpravaEst { get; set; } // Берется из xml_epmz, medCheckBox49.checked
        public int? perv_localis_OtekiSlevaEst { get; set; } // Берется из xml_epmz, medCheckBox53.checked
        public int? perv_localis_VarikoznieVeni { get; set; } // Берется из xml_epmz, medCheckBox50.checked
        public int? perv_localis_Teleangioektazii { get; set; } // Берется из xml_epmz, medCheckBox51.checked
        public int? perv_localis_LokalizaciaVarikozVenSprava { get; set; } // Берется из xml_epmz, medCheckBox74.checked
        public int? perv_localis_LokalizaciaVarikozVenSleva { get; set; } // Берется из xml_epmz, medCheckBox75.checked
        public int? perv_localis_LokalizaciaVarikozVenSpravaBedro { get; set; } // Берется из xml_epmz, medCheckBox78.checked
        public int? perv_localis_LokalizaciaVarikozVenSlevaBedro { get; set; } // Берется из xml_epmz, medCheckBox76.checked
        public int? perv_localis_LokalizaciaVarikozVenSpravaGolen { get; set; } // Берется из xml_epmz, medCheckBox79.checked
        public int? perv_localis_LokalizaciaVarikozVenSlevaGolen { get; set; } // Берется из xml_epmz, medCheckBox77.checked
        public int? perv_localis_LokalizaciaVarikozVenSpravaStopa { get; set; } // Берется из xml_epmz, medCheckBox81.checked
        public int? perv_localis_LokalizaciaVarikozVenSlevaStopa { get; set; } // Берется из xml_epmz, medCheckBox80.checked //FIX

        public int? perv_localis_LokalizaciaTeleoangioektaziiSprava { get; set; } // Берется из xml_epmz, medCheckBox82.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSleva { get; set; } // Берется из xml_epmz, medCheckBox83.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSpravaBedro { get; set; } // Берется из xml_epmz, medCheckBox84.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSlevaBedro { get; set; } // Берется из xml_epmz, medCheckBox87.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSpravaGolen { get; set; } // Берется из xml_epmz, medCheckBox85.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSlevaGolen { get; set; } // Берется из xml_epmz, medCheckBox88.checked //FIX
        public int? perv_localis_LokalizaciaTeleoangioektaziiSpravaStopa { get; set; } // Берется из xml_epmz, medCheckBox86.checked
        public int? perv_localis_LokalizaciaTeleoangioektaziiSlevaStopa { get; set; } // Берется из xml_epmz, medCheckBox89.checked

        public int? perv_localis_GlubokieVeniProhodimiYes { get; set; } // Берется из xml_epmz, medCheckBox34.checked
        public int? perv_localis_GlubokieVeniProhodimiNo { get; set; } // Берется из xml_epmz, medCheckBox35.checked
        public int? perv_localis_TromboflebitYes { get; set; } // Берется из xml_epmz, medCheckBox38.checked
        public int? perv_localis_TromboflebitNo { get; set; } // Берется из xml_epmz, medCheckBox39.checked
        public int? perv_localis_BoleznennostYes { get; set; } // Берется из xml_epmz, medCheckBox40.checked
        public int? perv_localis_BoleznennostNo { get; set; } // Берется из xml_epmz, medCheckBox41.checked

        public int? perv_complains_varikozSprava { get; set; } // Берется из xml_epmz, medCheckbox54.checked
        public int? perv_complains_varikozSleva { get; set; } // Берется из xml_epmz, medCheckbox55.checked
        public int? perv_complains_uplotnenieSprava { get; set; } // Берется из xml_epmz, medCheckbox9.checked
        public int? perv_complains_potemnenieSprava { get; set; } // Берется из xml_epmz, medCheckbox10.checked
        public int? perv_complains_zazhivshayaYazvaSprava { get; set; } // Берется из xml_epmz, medCheckbox11.checked
        public int? perv_complains_otkritayaYazvaSprava { get; set; } // Берется из xml_epmz, medCheckbox12.checked
        public int? perv_complains_uplotnenieSleva { get; set; } // Берется из xml_epmz, medCheckbox20.checked
        public int? perv_complains_potemnenieSleva { get; set; } // Берется из xml_epmz, medCheckbox21.checked
        public int? perv_complains_zazhivshayaYazvaSleva { get; set; } // Берется из xml_epmz, medCheckbox22.checked
        public int? perv_complains_otkritayaYazvaSleva { get; set; } // Берется из xml_epmz, medCheckbox23.checked


        // Форма УЗИ
        // medMemos
        // СФС - из поля важны два значения: Диаметр и рЕфлюкс (обратный ток крови). Рефлюкс отрицательный (-) - вена здоровая, положительный (+) - признак наличия варикоза. Меняют вручную врачи и потенциально могут что-то дописать.
        public string uzi_SFSMemoPravaya { get; set; } // Берется из xml_uzi, medMemo2.lines
        public string uzi_SFSMemoLevaya { get; set; } // Берется из xml_uzi, medMemo3.lines

        // БПВ (большая подкожная вена) - такая же история, как с СФС. Оставить в тексте только строчки с диаметром и рЕфлюксом (потом уточню у врача)
        public string uzi_BPVMemoPravaya { get; set; } // Берется из xml_uzi, medMemo4.lines
        public string uzi_BPVMemoLevaya { get; set; } // Берется из xml_uzi, medMemo5.lines

        // СПС - такая же история, как с СФС.
        public string uzi_SPSMemoPravaya { get; set; } // Берется из xml_uzi, medMemo6.lines
        public string uzi_SPSMemoLevaya { get; set; } // Берется из xml_uzi, medMemo7.lines

        // МПВ (малая подкожная вена) - такая же история, как с СФС. Оставить в тексте только строчки с диаметром и рЕфлюксом (потом уточню у врача)
        public string uzi_MPVMemoPravaya { get; set; } // Берется из xml_uzi, medMemo8.lines
        public string uzi_MPVMemoLevaya { get; set; } // Берется из xml_uzi, medMemo9.lines

        // Несостоятельные перфорантные вены - сложное для анализа поле, нужно будет отдельно посмотреть, что в нём и как печатают врачи
        public string uzi_perfVeniPravaya { get; set; } // Берется из xml_uzi, medMemo13.lines
        public string uzi_perfVeniLevaya { get; set; } // Берется из xml_uzi, medMemo14.lines

        // medCheckBoxes
        // Если нет галочки, врач наверняка не трогал это поле, поэтому uzi_perfVeniPravaya или uzi_perfVeniLevaya можно делать пустым
        public int? uzi_NesostVeniCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox10.checked
        public int? uzi_NesostVeniCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox11.checked
    }

    //public class DataForModel
    //{
    //    // perv
    //    // medMemos
    //    public string perv_Taktika { get; set; } // Берется из xml_epmz, medMemo27.lines

    //    // medComboBoxes
    //    public string perv_OtekSleva { get; set; } // Берется из xml_epmz, medComboBox28.text
    //    public string perv_OtekSprava { get; set; } // Берется из xml_epmz, medComboBox59.text
    //    public string perv_Kozha1 { get; set; } // Берется из xml_epmz, medComboBox52.text
    //    public string perv_Kozha2 { get; set; } // Берется из xml_epmz, medComboBox53.text
    //    public string perv_DvizheniyaNK { get; set; } // Берется из xml_epmz, medComboBox55.text
    //    public string perv_ChuvstvitelnostNK { get; set; } // Берется из xml_epmz, medComboBox57.text
    //    public string perv_OPA_NPA { get; set; } // Берется из xml_epmz, medComboBox66.text
    //    public string perv_OBA { get; set; } // Берется из xml_epmz, medComboBox67.text
    //    public string perv_PkA { get; set; } // Берется из xml_epmz, medComboBox68.text
    //    public string perv_ZBBA { get; set; } // Берется из xml_epmz, medComboBox69.text
    //    public string perv_PBBA { get; set; } // Берется из xml_epmz, medComboBox70.text
    //    public string perv_ADorsalisPedis { get; set; } // Берется из xml_epmz, medComboBox71.text

    //    // medSpinEdits
    //    public int? perv_n3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit7.value
    //    public int? perv_n3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit8.value
    //    public int? perv_s3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit9.value
    //    public int? perv_s3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit10.value
    //    public int? perv_v3goleniSprava { get; set; } // Берется из xml_epmz, medSpinEdit11.value
    //    public int? perv_v3bedraSprava { get; set; } // Берется из xml_epmz, medSpinEdit12.value
    //    public int? perv_n3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit14.value
    //    public int? perv_n3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit15.value
    //    public int? perv_s3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit16.value
    //    public int? perv_s3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit17.value
    //    public int? perv_v3goleniSleva { get; set; } // Берется из xml_epmz, medSpinEdit18.value
    //    public int? perv_v3bedraSleva { get; set; } // Берется из xml_epmz, medSpinEdit19.value

    //    // medCheckBoxes
    //    public int? perv_OtekiSpravaEst { get; set; } // Берется из xml_epmz, medCheckBox49.checked
    //    public int? perv_OtekiSlevaEst { get; set; } // Берется из xml_epmz, medCheckBox53.checked
    //    public int? perv_VarikoznieVeni { get; set; } // Берется из xml_epmz, medCheckBox50.checked
    //    public int? perv_Teleangioektazii { get; set; } // Берется из xml_epmz, medCheckBox51.checked
    //    public int? perv_LokalizaciaVarikozVenSprava { get; set; } // Берется из xml_epmz, medCheckBox74.checked
    //    public int? perv_LokalizaciaVarikozVenSleva { get; set; } // Берется из xml_epmz, medCheckBox75.checked
    //    public int? perv_LokalizaciaVarikozVenSpravaBedro { get; set; } // Берется из xml_epmz, medCheckBox78.checked
    //    public int? perv_LokalizaciaVarikozVenSlevaBedro { get; set; } // Берется из xml_epmz, medCheckBox76.checked
    //    public int? perv_LokalizaciaVarikozVenSpravaGolen { get; set; } // Берется из xml_epmz, medCheckBox79.checked
    //    public int? perv_LokalizaciaVarikozVenSlevaGolen { get; set; } // Берется из xml_epmz, medCheckBox77.checked
    //    public int? perv_LokalizaciaVarikozVenSpravaStopa { get; set; } // Берется из xml_epmz, medCheckBox81.checked
    //    public int? perv_LokalizaciaVarikozVenSlevaBedro2 { get; set; } // Берется из xml_epmz, medCheckBox80.checked //TODO ошибка

    //    public int? perv_LokalizaciaTeleoangioektaziiSprava { get; set; } // Берется из xml_epmz, medCheckBox82.checked
    //    public int? perv_LokalizaciaTeleoangioektaziiSleva { get; set; } // Берется из xml_epmz, medCheckBox83.checked

    //    public int? perv_LokalizaciaTeleoangioektaziiSpravaBedro { get; set; } // Берется из xml_epmz, medCheckBox84.checked

    //    public int? perv_LokalizaciaTeleoangioektaziiSlevaBedro { get; set; } // Берется из xml_epmz, medCheckBox87.checked

    //    public int? perv_LokalizaciaTeleoangioektaziiSpravaGolen { get; set; } // Берется из xml_epmz, medCheckBox85.checked

    //    public int? perv_LokalizaciaTeleoangioektaziiSlevaBedro2 { get; set; } // Берется из xml_epmz, medCheckBox88.checked //TODO ошибка

    //    public int? perv_LokalizaciaTeleoangioektaziiSpravaStopa { get; set; } // Берется из xml_epmz, medCheckBox86.checked

    //    public int? perv_LokalizaciaTeleoangioektaziiSlevaStopa { get; set; } // Берется из xml_epmz, medCheckBox89.checked

    //    public int? perv_GlubokieVeniProhodimiYes { get; set; } // Берется из xml_epmz, medCheckBox34.checked
    //    public int? perv_GlubokieVeniProhodimiNo { get; set; } // Берется из xml_epmz, medCheckBox35.checked
    //    public int? perv_TromboflebitYes { get; set; } // Берется из xml_epmz, medCheckBox38.checked
    //    public int? perv_TromboflebitNo { get; set; } // Берется из xml_epmz, medCheckBox39.checked
    //    public int? perv_BoleznennostYes { get; set; } // Берется из xml_epmz, medCheckBox40.checked
    //    public int? perv_BoleznennostNo { get; set; } // Берется из xml_epmz, medCheckBox41.checked

    //    // uzi
    //    // medMemos
    //    public string uzi_obshayaInfPravaya { get; set; } // Берется из xml_uzi, medMemo10.lines
    //    public string uzi_obshayaInfLevaya { get; set; } // Берется из xml_uzi, medMemo11.lines
    //    public string uzi_SFSMemoPravaya { get; set; } // Берется из xml_uzi, medMemo2.lines
    //    public string uzi_SFSMemoLevaya { get; set; } // Берется из xml_uzi, medMemo3.lines
    //    public string uzi_BPVMemoPravaya { get; set; } // Берется из xml_uzi, medMemo4.lines
    //    public string uzi_BPVMemoLevaya { get; set; } // Берется из xml_uzi, medMemo5.lines
    //    public string uzi_SPSMemoPravaya { get; set; } // Берется из xml_uzi, medMemo6.lines
    //    public string uzi_SPSMemoLevaya { get; set; } // Берется из xml_uzi, medMemo7.lines
    //    public string uzi_MPVMemoPravaya { get; set; } // Берется из xml_uzi, medMemo8.lines
    //    public string uzi_MPVMemoLevaya { get; set; } // Берется из xml_uzi, medMemo9.lines

    //    // medCheckBoxes
    //    public int? uzi_SFSCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox2.checked
    //    public int? uzi_BPVCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox3.checked
    //    public int? uzi_SPSCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox4.checked
    //    public int? uzi_MPBCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox5.checked
    //    public int? uzi_SFSCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox6.checked
    //    public int? uzi_BPVCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox7.checked
    //    public int? uzi_SPSCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox8.checked
    //    public int? uzi_MPBCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox9.checked
    //    public int? uzi_NesostVeniCheckBoxPravaya { get; set; } // Берется из xml_uzi, medCheckBox10.checked
    //    public int? uzi_NesostVeniCheckBoxLevaya { get; set; } // Берется из xml_uzi, medCheckBox11.checked
    //    public int? uzi_LimfostazPravaya { get; set; } // Берется из xml_uzi, medCheckBox12.checked
    //    public int? uzi_LimfostazLevaya { get; set; } // Берется из xml_uzi, medCheckBox13.checked
    //    public int? uzi_KistaBakeraPravaya { get; set; } // Берется из xml_uzi, medCheckBox16.checked
    //    public int? uzi_KistaBakeraLevaya { get; set; } // Берется из xml_uzi, medCheckBox17.checked
    //}
}