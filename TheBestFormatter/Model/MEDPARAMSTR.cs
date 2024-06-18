using System.Xml.Serialization;

namespace TheBestFormatter.Model
{
    [XmlRoot(ElementName = "MEDPARAMSTR")]
    public class MEDPARAMSTR
    {
        [XmlElement(ElementName = "paramStr")]
        public PARAM_STR ParamStr { get; set; }
    }

    [XmlRoot(ElementName = "paramStr")]
    public class PARAM_STR
    {
        //public bool IsEmpty()
        //{
        //    return this.GetHashCode() == new PARAM_STR().GetHashCode();
        //}

        [XmlElement(ElementName = "CAPTION")]
        public string? Caption { get; set; }

        [XmlElement(ElementName = "DEFFIELDNAME")]
        public string? Deffieldname { get; set; }

        [XmlElement(ElementName = "TEXT")]
        public string? Text { get; set; }

        [XmlElement(ElementName = "ITEMINDEX")]
        public int? Itemindex { get; set; }

        [XmlElement(ElementName = "MEDDESCRIPTION")]
        public object? Meddescription { get; set; }

        [XmlElement(ElementName = "DATEDOUBLE")]
        public double? Datedouble { get; set; }

        [XmlElement(ElementName = "DATESTR")]
        public string? Datestr { get; set; }

        [XmlElement(ElementName = "DATETIMESTR")]
        public string? Datetimestr { get; set; }

        [XmlElement(ElementName = "LINES")]
        public string? Lines { get; set; }

        [XmlElement(ElementName = "CHECKED")]
        public bool Checked { get; set; }

        [XmlElement(ElementName = "CHECKEDNAME")]
        public string? Checkedname { get; set; }

        [XmlElement(ElementName = "VALUE")]
        public int? Value { get; set; }

        [XmlElement(ElementName = "ASSIGNEDQUOTES_MAXQUOTEVALUE")]
        public int? Assignedquotesmaxquotevalue { get; set; }

        [XmlElement(ElementName = "ASSIGNEDQUOTES_MINQUOTEVALUE")]
        public int? Assignedquotesminquotevalue { get; set; }

        [XmlElement(ElementName = "MINQUOTEVALUE")]
        public int? Minquotevalue { get; set; }

        [XmlElement(ElementName = "MAXQUOTEVALUE")]
        public int Maxquotevalue { get; set; }

        [XmlElement(ElementName = "LESSMINCOLOR")]
        public int Lessmincolor { get; set; }

        [XmlElement(ElementName = "MOREMAXCOLOR")]
        public int Moremaxcolor { get; set; }

        [XmlElement(ElementName = "ACTIVECOLOR")]
        public int Activecolor { get; set; }

        [XmlElement(ElementName = "HTMLACTIVECOLOR")]
        public string Htmlactivecolor { get; set; }

        [XmlElement(ElementName = "ID")]
        public int Id { get; set; }

        [XmlElement(ElementName = "CODE")]
        public string Code { get; set; }

        [XmlElement(ElementName = "NAME")]
        public string Name { get; set; }

        [XmlElement(ElementName = "MEDLABEL1")]
        public MEDLABEL1 Medlabel1 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX1")]
        public MEDCOMBOBOX1 Medcombobox1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL2")]
        public MEDLABEL2 Medlabel2 { get; set; }

        [XmlElement(ElementName = "MEDDATEEDIT1")]
        public MEDDATEEDIT1 Meddateedit1 { get; set; }

        [XmlElement(ElementName = "MEDMEMO1")]
        public MEDMEMO1 Medmemo1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL4")]
        public MEDLABEL4 Medlabel4 { get; set; }

        [XmlElement(ElementName = "MEDMEMO2")]
        public MEDMEMO2 Medmemo2 { get; set; }

        [XmlElement(ElementName = "MEDMEMO3")]
        public MEDMEMO3 Medmemo3 { get; set; }

        [XmlElement(ElementName = "MEDMEMO4")]
        public MEDMEMO3 Medmemo4 { get; set; }

        [XmlElement(ElementName = "MEDMEMO5")]
        public MEDMEMO3 Medmemo5 { get; set; }

        [XmlElement(ElementName = "MEDMEMO6")]
        public MEDMEMO3 Medmemo6 { get; set; }

        [XmlElement(ElementName = "MEDMEMO7")]
        public MEDMEMO3 Medmemo7 { get; set; }

        [XmlElement(ElementName = "MEDMEMO8")]
        public MEDMEMO3 Medmemo8 { get; set; }

        [XmlElement(ElementName = "MEDMEMO9")]
        public MEDMEMO3 Medmemo9 { get; set; }

        [XmlElement(ElementName = "MEDMEMO13")]
        public MEDMEMO3 Medmemo13 { get; set; }

        [XmlElement(ElementName = "MEDMEMO14")]
        public MEDMEMO3 Medmemo14 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX1")]
        public MEDCHECKBOX1 Medcheckbox1 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX2")]
        public MEDCHECKBOX2 Medcheckbox2 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX3")]
        public MEDCHECKBOX3 Medcheckbox3 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX4")]
        public MEDCHECKBOX4 Medcheckbox4 { get; set; }

        [XmlElement(ElementName = "MEDLABEL11")]
        public MEDLABEL11 Medlabel11 { get; set; }

        [XmlElement(ElementName = "MEDLABEL12")]
        public MEDLABEL12 Medlabel12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL15")]
        public MEDLABEL15 Medlabel15 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX6")]
        public MEDCOMBOBOX6 Medcombobox6 { get; set; }

        [XmlElement(ElementName = "MEDLABEL19")]
        public MEDLABEL19 Medlabel19 { get; set; }

        [XmlElement(ElementName = "MEDLABEL20")]
        public MEDLABEL20 Medlabel20 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX6")]
        public MEDCHECKBOX6 Medcheckbox6 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX7")]
        public MEDCHECKBOX7 Medcheckbox7 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX8")]
        public MEDCHECKBOX8 Medcheckbox8 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX9")]
        public MEDCHECKBOX9 Medcheckbox9 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX10")]
        public MEDCHECKBOX10 Medcheckbox10 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX11")]
        public MEDCHECKBOX11 Medcheckbox11 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX12")]
        public MEDCHECKBOX12 Medcheckbox12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL25")]
        public MEDLABEL25 Medlabel25 { get; set; }

        [XmlElement(ElementName = "MEDLABEL26")]
        public MEDLABEL26 Medlabel26 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX13")]
        public MEDCHECKBOX13 Medcheckbox13 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX14")]
        public MEDCHECKBOX14 Medcheckbox14 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX15")]
        public MEDCHECKBOX15 Medcheckbox15 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX16")]
        public MEDCHECKBOX16 Medcheckbox16 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX17")]
        public MEDCHECKBOX17 Medcheckbox17 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX18")]
        public MEDCHECKBOX18 Medcheckbox18 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX19")]
        public MEDCHECKBOX19 Medcheckbox19 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX20")]
        public MEDCHECKBOX20 Medcheckbox20 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX21")]
        public MEDCHECKBOX21 Medcheckbox21 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX22")]
        public MEDCHECKBOX22 Medcheckbox22 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX23")]
        public MEDCHECKBOX23 Medcheckbox23 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX27")]
        public MEDCHECKBOX27 Medcheckbox27 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX28")]
        public MEDCHECKBOX28 Medcheckbox28 { get; set; }

        [XmlElement(ElementName = "MEDLABEL32")]
        public MEDLABEL32 Medlabel32 { get; set; }

        [XmlElement(ElementName = "MEDLABEL35")]
        public MEDLABEL35 Medlabel35 { get; set; }

        [XmlElement(ElementName = "MEDMEMO21")]
        public MEDMEMO21 Medmemo21 { get; set; }

        [XmlElement(ElementName = "MEDLABEL72")]
        public MEDLABEL72 Medlabel72 { get; set; }

        [XmlElement(ElementName = "MEDLABEL73")]
        public MEDLABEL73 Medlabel73 { get; set; }

        [XmlElement(ElementName = "MEDLABEL74")]
        public MEDLABEL74 Medlabel74 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX25")]
        public MEDCOMBOBOX25 Medcombobox25 { get; set; }

        [XmlElement(ElementName = "MEDLABEL75")]
        public MEDLABEL75 Medlabel75 { get; set; }

        [XmlElement(ElementName = "MEDLABEL76")]
        public MEDLABEL76 Medlabel76 { get; set; }

        [XmlElement(ElementName = "MEDLABEL77")]
        public MEDLABEL77 Medlabel77 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX26")]
        public MEDCOMBOBOX26 Medcombobox26 { get; set; }

        [XmlElement(ElementName = "MEDLABEL78")]
        public MEDLABEL78 Medlabel78 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX27")]
        public MEDCOMBOBOX27 Medcombobox27 { get; set; }

        [XmlElement(ElementName = "MEDLABEL79")]
        public MEDLABEL79 Medlabel79 { get; set; }

        [XmlElement(ElementName = "MEDLABEL85")]
        public MEDLABEL85 Medlabel85 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX30")]
        public MEDCOMBOBOX30 Medcombobox30 { get; set; }

        [XmlElement(ElementName = "MEDLABEL86")]
        public MEDLABEL86 Medlabel86 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX31")]
        public MEDCOMBOBOX31 Medcombobox31 { get; set; }

        [XmlElement(ElementName = "MEDLABEL90")]
        public MEDLABEL90 Medlabel90 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX34")]
        public MEDCOMBOBOX34 Medcombobox34 { get; set; }

        [XmlElement(ElementName = "MEDLABEL91")]
        public MEDLABEL91 Medlabel91 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX35")]
        public MEDCOMBOBOX35 Medcombobox35 { get; set; }

        [XmlElement(ElementName = "MEDLABEL92")]
        public MEDLABEL92 Medlabel92 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX36")]
        public MEDCOMBOBOX36 Medcombobox36 { get; set; }

        [XmlElement(ElementName = "MEDLABEL93")]
        public MEDLABEL93 Medlabel93 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT1")]
        public MEDSPINEDIT1 Medspinedit1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL94")]
        public MEDLABEL94 Medlabel94 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT3")]
        public MEDSPINEDIT3 Medspinedit3 { get; set; }

        [XmlElement(ElementName = "MEDLABEL95")]
        public MEDLABEL95 Medlabel95 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT4")]
        public MEDSPINEDIT4 Medspinedit4 { get; set; }

        [XmlElement(ElementName = "MEDLABEL99")]
        public MEDLABEL99 Medlabel99 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX37")]
        public MEDCOMBOBOX37 Medcombobox37 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX38")]
        public MEDCOMBOBOX38 Medcombobox38 { get; set; }

        [XmlElement(ElementName = "MEDLABEL100")]
        public MEDLABEL100 Medlabel100 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX42")]
        public MEDCOMBOBOX42 Medcombobox42 { get; set; }

        [XmlElement(ElementName = "MEDLABEL108")]
        public MEDLABEL108 Medlabel108 { get; set; }

        [XmlElement(ElementName = "MEDLABEL109")]
        public MEDLABEL109 Medlabel109 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT5")]
        public MEDSPINEDIT5 Medspinedit5 { get; set; }

        [XmlElement(ElementName = "MEDLABEL119")]
        public MEDLABEL119 Medlabel119 { get; set; }

        [XmlElement(ElementName = "MEDMEMO48")]
        public MEDMEMO48 Medmemo48 { get; set; }

        [XmlElement(ElementName = "MEDLABEL120")]
        public MEDLABEL120 Medlabel120 { get; set; }

        [XmlElement(ElementName = "MEDLABEL122")]
        public MEDLABEL122 Medlabel122 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX52")]
        public MEDCOMBOBOX52 Medcombobox52 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX53")]
        public MEDCOMBOBOX53 Medcombobox53 { get; set; }

        [XmlElement(ElementName = "MEDLABEL124")]
        public MEDLABEL124 Medlabel124 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX55")]
        public MEDCOMBOBOX55 Medcombobox55 { get; set; }

        [XmlElement(ElementName = "MEDLABEL127")]
        public MEDLABEL127 Medlabel127 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX57")]
        public MEDCOMBOBOX57 Medcombobox57 { get; set; }

        [XmlElement(ElementName = "MEDLABEL129")]
        public MEDLABEL129 Medlabel129 { get; set; }

        [XmlElement(ElementName = "MEDLABEL130")]
        public MEDLABEL130 Medlabel130 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT7")]
        public MEDSPINEDIT7 Medspinedit7 { get; set; }

        [XmlElement(ElementName = "MEDLABEL131")]
        public MEDLABEL131 Medlabel131 { get; set; }

        [XmlElement(ElementName = "MEDLABEL132")]
        public MEDLABEL132 Medlabel132 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT8")]
        public MEDSPINEDIT8 Medspinedit8 { get; set; }

        [XmlElement(ElementName = "MEDLABEL133")]
        public MEDLABEL133 Medlabel133 { get; set; }

        [XmlElement(ElementName = "MEDLABEL134")]
        public MEDLABEL134 Medlabel134 { get; set; }

        [XmlElement(ElementName = "MEDLABEL135")]
        public MEDLABEL135 Medlabel135 { get; set; }

        [XmlElement(ElementName = "MEDLABEL136")]
        public MEDLABEL136 Medlabel136 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT9")]
        public MEDSPINEDIT9 Medspinedit9 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT10")]
        public MEDSPINEDIT10 Medspinedit10 { get; set; }

        [XmlElement(ElementName = "MEDLABEL137")]
        public MEDLABEL137 Medlabel137 { get; set; }

        [XmlElement(ElementName = "MEDLABEL138")]
        public MEDLABEL138 Medlabel138 { get; set; }

        [XmlElement(ElementName = "MEDLABEL139")]
        public MEDLABEL139 Medlabel139 { get; set; }

        [XmlElement(ElementName = "MEDLABEL140")]
        public MEDLABEL140 Medlabel140 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT11")]
        public MEDSPINEDIT11 Medspinedit11 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT12")]
        public MEDSPINEDIT12 Medspinedit12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL141")]
        public MEDLABEL141 Medlabel141 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX59")]
        public MEDCOMBOBOX59 Medcombobox59 { get; set; }

        [XmlElement(ElementName = "MEDLABEL159")]
        public MEDLABEL159 Medlabel159 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX34")]
        public MEDCHECKBOX34 Medcheckbox34 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX35")]
        public MEDCHECKBOX35 Medcheckbox35 { get; set; }

        [XmlElement(ElementName = "MEDLABEL165")]
        public MEDLABEL165 Medlabel165 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX38")]
        public MEDCHECKBOX38 Medcheckbox38 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX39")]
        public MEDCHECKBOX39 Medcheckbox39 { get; set; }

        [XmlElement(ElementName = "MEDLABEL167")]
        public MEDLABEL167 Medlabel167 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX40")]
        public MEDCHECKBOX40 Medcheckbox40 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX41")]
        public MEDCHECKBOX41 Medcheckbox41 { get; set; }

        [XmlElement(ElementName = "MEDLABEL178")]
        public MEDLABEL178 Medlabel178 { get; set; }

        [XmlElement(ElementName = "MEDLABEL179")]
        public MEDLABEL179 Medlabel179 { get; set; }

        [XmlElement(ElementName = "MEDLABEL180")]
        public MEDLABEL180 Medlabel180 { get; set; }

        [XmlElement(ElementName = "MEDLABEL183")]
        public MEDLABEL183 Medlabel183 { get; set; }

        [XmlElement(ElementName = "MEDLABEL184")]
        public MEDLABEL184 Medlabel184 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX66")]
        public MEDCOMBOBOX66 Medcombobox66 { get; set; }

        [XmlElement(ElementName = "MEDLABEL185")]
        public MEDLABEL185 Medlabel185 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX67")]
        public MEDCOMBOBOX67 Medcombobox67 { get; set; }

        [XmlElement(ElementName = "MEDLABEL186")]
        public MEDLABEL186 Medlabel186 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX68")]
        public MEDCOMBOBOX68 Medcombobox68 { get; set; }

        [XmlElement(ElementName = "MEDLABEL187")]
        public MEDLABEL187 Medlabel187 { get; set; }

        [XmlElement(ElementName = "MEDLABEL188")]
        public MEDLABEL188 Medlabel188 { get; set; }

        [XmlElement(ElementName = "MEDLABEL189")]
        public MEDLABEL189 Medlabel189 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX69")]
        public MEDCOMBOBOX69 Medcombobox69 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX70")]
        public MEDCOMBOBOX70 Medcombobox70 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX71")]
        public MEDCOMBOBOX71 Medcombobox71 { get; set; }

        [XmlElement(ElementName = "MEDLABEL190")]
        public MEDLABEL190 Medlabel190 { get; set; }

        [XmlElement(ElementName = "MEDMEMO63")]
        public MEDMEMO63 Medmemo63 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX92")]
        public MEDCOMBOBOX92 Medcombobox92 { get; set; }

        [XmlElement(ElementName = "MEDLABEL258")]
        public MEDLABEL258 Medlabel258 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT31")]
        public MEDSPINEDIT31 Medspinedit31 { get; set; }

        [XmlElement(ElementName = "MEDLABEL259")]
        public MEDLABEL259 Medlabel259 { get; set; }

        [XmlElement(ElementName = "MEDLABEL261")]
        public MEDLABEL261 Medlabel261 { get; set; }

        [XmlElement(ElementName = "MEDLABEL262")]
        public MEDLABEL262 Medlabel262 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT32")]
        public MEDSPINEDIT32 Medspinedit32 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX74")]
        public MEDCHECKBOX74 Medcheckbox74 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX75")]
        public MEDCHECKBOX75 Medcheckbox75 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX78")]
        public MEDCHECKBOX78 Medcheckbox78 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX79")]
        public MEDCHECKBOX79 Medcheckbox79 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX81")]
        public MEDCHECKBOX81 Medcheckbox81 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX76")]
        public MEDCHECKBOX76 Medcheckbox76 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX77")]
        public MEDCHECKBOX77 Medcheckbox77 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX80")]
        public MEDCHECKBOX80 Medcheckbox80 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX82")]
        public MEDCHECKBOX82 Medcheckbox82 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX83")]
        public MEDCHECKBOX83 Medcheckbox83 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX84")]
        public MEDCHECKBOX84 Medcheckbox84 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX85")]
        public MEDCHECKBOX85 Medcheckbox85 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX86")]
        public MEDCHECKBOX86 Medcheckbox86 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX87")]
        public MEDCHECKBOX87 Medcheckbox87 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX88")]
        public MEDCHECKBOX88 Medcheckbox88 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX89")]
        public MEDCHECKBOX89 Medcheckbox89 { get; set; }

        [XmlElement(ElementName = "MEDMEMO25")]
        public MEDMEMO25 Medmemo25 { get; set; }

        [XmlElement(ElementName = "MEDMEMO27")]
        public MEDMEMO27 Medmemo27 { get; set; }

        [XmlElement(ElementName = "MEDLABEL145")]
        public MEDLABEL145 Medlabel145 { get; set; }

        [XmlElement(ElementName = "MEDLABEL147")]
        public MEDLABEL147 Medlabel147 { get; set; }

        [XmlElement(ElementName = "MEDLABEL148")]
        public MEDLABEL148 Medlabel148 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX47")]
        public MEDCHECKBOX47 Medcheckbox47 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX48")]
        public MEDCHECKBOX48 Medcheckbox48 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX49")]
        public MEDCHECKBOX49 Medcheckbox49 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX50")]
        public MEDCHECKBOX50 Medcheckbox50 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX51")]
        public MEDCHECKBOX51 Medcheckbox51 { get; set; }

        [XmlElement(ElementName = "MEDLABEL80")]
        public MEDLABEL80 Medlabel80 { get; set; }

        [XmlElement(ElementName = "MEDLABEL81")]
        public MEDLABEL81 Medlabel81 { get; set; }

        [XmlElement(ElementName = "MEDLABEL82")]
        public MEDLABEL82 Medlabel82 { get; set; }

        [XmlElement(ElementName = "MEDLABEL83")]
        public MEDLABEL83 Medlabel83 { get; set; }

        [XmlElement(ElementName = "MEDLABEL84")]
        public MEDLABEL84 Medlabel84 { get; set; }

        [XmlElement(ElementName = "MEDLABEL87")]
        public MEDLABEL87 Medlabel87 { get; set; }

        [XmlElement(ElementName = "MEDLABEL88")]
        public MEDLABEL88 Medlabel88 { get; set; }

        [XmlElement(ElementName = "MEDLABEL89")]
        public MEDLABEL89 Medlabel89 { get; set; }

        [XmlElement(ElementName = "MEDLABEL96")]
        public MEDLABEL96 Medlabel96 { get; set; }

        [XmlElement(ElementName = "MEDLABEL97")]
        public MEDLABEL97 Medlabel97 { get; set; }

        [XmlElement(ElementName = "MEDLABEL98")]
        public MEDLABEL98 Medlabel98 { get; set; }

        [XmlElement(ElementName = "MEDLABEL101")]
        public MEDLABEL101 Medlabel101 { get; set; }

        [XmlElement(ElementName = "MEDLABEL102")]
        public MEDLABEL102 Medlabel102 { get; set; }

        [XmlElement(ElementName = "MEDLABEL103")]
        public MEDLABEL103 Medlabel103 { get; set; }

        [XmlElement(ElementName = "MEDLABEL104")]
        public MEDLABEL104 Medlabel104 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT14")]
        public MEDSPINEDIT14 Medspinedit14 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT15")]
        public MEDSPINEDIT15 Medspinedit15 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT16")]
        public MEDSPINEDIT16 Medspinedit16 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT17")]
        public MEDSPINEDIT17 Medspinedit17 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT18")]
        public MEDSPINEDIT18 Medspinedit18 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT19")]
        public MEDSPINEDIT19 Medspinedit19 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX28")]
        public MEDCOMBOBOX28 Medcombobox28 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX53")]
        public MEDCHECKBOX53 Medcheckbox53 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX54")]
        public MEDCHECKBOX54 Medcheckbox54 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX55")]
        public MEDCHECKBOX55 Medcheckbox55 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT1")]
        public MEDDBMKB10_EDIT1 Meddbmkb10Edit1 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX56")]
        public MEDCHECKBOX56 Medcheckbox56 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT3")]
        public MEDDBMKB10_EDIT3 Meddbmkb10Edit3 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX57")]
        public MEDCHECKBOX57 Medcheckbox57 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT4")]
        public MEDDBMKB10_EDIT4 Meddbmkb10Edit4 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX58")]
        public MEDCHECKBOX58 Medcheckbox58 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT5")]
        public MEDDBMKB10_EDIT5 Meddbmkb10Edit5 { get; set; }

        [XmlElement(ElementName = "MEDLABEL105")]
        public MEDLABEL105 Medlabel105 { get; set; }

        [XmlElement(ElementName = "MEDLABEL106")]
        public MEDLABEL106 Medlabel106 { get; set; }

        [XmlElement(ElementName = "MEDLABEL107")]
        public MEDLABEL107 Medlabel107 { get; set; }

        [XmlElement(ElementName = "MEDLABEL110")]
        public MEDLABEL110 Medlabel110 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX59")]
        public MEDCHECKBOX59 Medcheckbox59 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX60")]
        public MEDCHECKBOX60 Medcheckbox60 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX29")]
        public MEDCOMBOBOX29 Medcombobox29 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX32")]
        public MEDCOMBOBOX32 Medcombobox32 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX33")]
        public MEDCOMBOBOX33 Medcombobox33 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX61")]
        public MEDCHECKBOX61 Medcheckbox61 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX62")]
        public MEDCHECKBOX62 Medcheckbox62 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX39")]
        public MEDCOMBOBOX39 Medcombobox39 { get; set; }

        [XmlElement(ElementName = "PERV")]
        public PERV Perv { get; set; }

        [XmlElement(ElementName = "MEDLABEL111")]
        public MEDLABEL111 Medlabel111 { get; set; }

        [XmlElement(ElementName = "POVT")]
        public POVT Povt { get; set; }

        [XmlElement(ElementName = "VARIKOZ")]
        public VARIKOZ Varikoz { get; set; }

        [XmlElement(ElementName = "NESOSUD")]
        public NESOSUD Nesosud { get; set; }

        [XmlElement(ElementName = "OSNOVNOE")]
        public OSNOVNOE Osnovnoe { get; set; }

        [XmlElement(ElementName = "SOPUTST")]
        public SOPUTST Soputst { get; set; }

        [XmlElement(ElementName = "OPERACIYA")]
        public OPERACIYA Operaciya { get; set; }

        [XmlElement(ElementName = "MANIPULYACIYA")]
        public MANIPULYACIYA Manipulyaciya { get; set; }

        [XmlElement(ElementName = "LECHENIE")]
        public LECHENIE Lechenie { get; set; }

        [XmlElement(ElementName = "ZAPISALSYA")]
        public ZAPISALSYA Zapisalsya { get; set; }

        [XmlElement(ElementName = "NEZAPISALSYA")]
        public NEZAPISALSYA Nezapisalsya { get; set; }

        [XmlElement(ElementName = "OTLOZHIL")]
        public OTLOZHIL Otlozhil { get; set; }

        [XmlElement(ElementName = "OTOLOZHILDO")]
        public OTOLOZHILDO Otolozhildo { get; set; }

        [XmlElement(ElementName = "SOPUTNEVROPATOLOG")]
        public SOPUTNEVROPATOLOG Soputnevropatolog { get; set; }

        [XmlElement(ElementName = "SOPUTTRAVMOTOLOG")]
        public SOPUTTRAVMOTOLOG Soputtravmotolog { get; set; }

        [XmlElement(ElementName = "SOPUTREVMATOLOG")]
        public SOPUTREVMATOLOG Soputrevmatolog { get; set; }

        [XmlElement(ElementName = "SOPUTGEMOSTAZIOLOG")]
        public SOPUTGEMOSTAZIOLOG Soputgemostaziolog { get; set; }

        [XmlElement(ElementName = "SOPUTTERAPEVT")]
        public SOPUTTERAPEVT Soputterapevt { get; set; }

        [XmlElement(ElementName = "SOPUTKARDIOLOG")]
        public SOPUTKARDIOLOG Soputkardiolog { get; set; }

        [XmlElement(ElementName = "SOPUTENDOKRINOLOG")]
        public SOPUTENDOKRINOLOG Soputendokrinolog { get; set; }

        [XmlElement(ElementName = "SOPUTGINEKOLOG")]
        public SOPUTGINEKOLOG Soputginekolog { get; set; }

        [XmlElement(ElementName = "SOPUTUROLOG")]
        public SOPUTUROLOG Soputurolog { get; set; }

        [XmlElement(ElementName = "SOPUTHIRURG")]
        public SOPUTHIRURG Soputhirurg { get; set; }

        [XmlElement(ElementName = "SOPUTDRUGOI")]
        public SOPUTDRUGOI Soputdrugoi { get; set; }

        [XmlElement(ElementName = "SOPUTNETREBUETSYA")]
        public SOPUTNETREBUETSYA Soputnetrebuetsya { get; set; }

        [XmlElement(ElementName = "NZSAMOZAP")]
        public NZSAMOZAP Nzsamozap { get; set; }

        [XmlElement(ElementName = "NZDOROGO")]
        public NZDOROGO Nzdorogo { get; set; }

        [XmlElement(ElementName = "NZBOITSYA")]
        public NZBOITSYA Nzboitsya { get; set; }

        [XmlElement(ElementName = "NZZANYAT")]
        public NZZANYAT Nzzanyat { get; set; }

        [XmlElement(ElementName = "NZNENASTROEN")]
        public NZNENASTROEN Nznenastroen { get; set; }

        [XmlElement(ElementName = "NZOZHIDALDRUGOI")]
        public NZOZHIDALDRUGOI Nzozhidaldrugoi { get; set; }

        [XmlElement(ElementName = "NSNETTEHNOLOGII")]
        public NSNETTEHNOLOGII Nsnettehnologii { get; set; }

        [XmlElement(ElementName = "CENTR")]
        public CENTR Centr { get; set; }

        [XmlElement(ElementName = "MEDLABEL112")]
        public MEDLABEL112 Medlabel112 { get; set; }

        [XmlElement(ElementName = "MEDLABEL113")]
        public MEDLABEL113 Medlabel113 { get; set; }

        [XmlElement(ElementName = "NUZHNASPRAVKA")]
        public NUZHNASPRAVKA Nuzhnaspravka { get; set; }

        [XmlElement(ElementName = "TRIKOTAZH1KL")]
        public TRIKOTAZH1_KL Trikotazh1Kl { get; set; }

        [XmlElement(ElementName = "TRIKOTAZH")]
        public TRIKOTAZH Trikotazh { get; set; }

        [XmlElement(ElementName = "TDLK")]
        public TDLK Tdlk { get; set; }

        [XmlElement(ElementName = "ZAPISALSYATDLK")]
        public ZAPISALSYATDLK Zapisalsyatdlk { get; set; }

        [XmlElement(ElementName = "NEZAPISALSYATDLK")]
        public NEZAPISALSYATDLK Nezapisalsyatdlk { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL1")]
    public class MEDLABEL1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX1")]
    public class MEDCOMBOBOX1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL2")]
    public class MEDLABEL2
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDDATEEDIT1")]
    public class MEDDATEEDIT1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO1")]
    public class MEDMEMO1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL4")]
    public class MEDLABEL4
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO2")]
    public class MEDMEMO2
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO3")]
    public class MEDMEMO3
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO4")]
    public class MEDMEMO4
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO5")]
    public class MEDMEMO5
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO6")]
    public class MEDMEMO6
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO7")]
    public class MEDMEMO7
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO8")]
    public class MEDMEMO8
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO9")]
    public class MEDMEMO9
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO13")]
    public class MEDMEMO13
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO14")]
    public class MEDMEMO14
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX1")]
    public class MEDCHECKBOX1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX2")]
    public class MEDCHECKBOX2
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX3")]
    public class MEDCHECKBOX3
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX4")]
    public class MEDCHECKBOX4
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL11")]
    public class MEDLABEL11
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL12")]
    public class MEDLABEL12
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL15")]
    public class MEDLABEL15
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX6")]
    public class MEDCOMBOBOX6
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL19")]
    public class MEDLABEL19
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL20")]
    public class MEDLABEL20
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX6")]
    public class MEDCHECKBOX6
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX7")]
    public class MEDCHECKBOX7
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX8")]
    public class MEDCHECKBOX8
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX9")]
    public class MEDCHECKBOX9
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX10")]
    public class MEDCHECKBOX10
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX11")]
    public class MEDCHECKBOX11
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX12")]
    public class MEDCHECKBOX12
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL25")]
    public class MEDLABEL25
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL26")]
    public class MEDLABEL26
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX13")]
    public class MEDCHECKBOX13
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX14")]
    public class MEDCHECKBOX14
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX15")]
    public class MEDCHECKBOX15
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX16")]
    public class MEDCHECKBOX16
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX17")]
    public class MEDCHECKBOX17
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX18")]
    public class MEDCHECKBOX18
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX19")]
    public class MEDCHECKBOX19
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX20")]
    public class MEDCHECKBOX20
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX21")]
    public class MEDCHECKBOX21
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX22")]
    public class MEDCHECKBOX22
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX23")]
    public class MEDCHECKBOX23
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX27")]
    public class MEDCHECKBOX27
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX28")]
    public class MEDCHECKBOX28
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL32")]
    public class MEDLABEL32
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL35")]
    public class MEDLABEL35
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO21")]
    public class MEDMEMO21
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL72")]
    public class MEDLABEL72
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL73")]
    public class MEDLABEL73
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL74")]
    public class MEDLABEL74
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX25")]
    public class MEDCOMBOBOX25
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL75")]
    public class MEDLABEL75
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL76")]
    public class MEDLABEL76
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL77")]
    public class MEDLABEL77
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX26")]
    public class MEDCOMBOBOX26
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL78")]
    public class MEDLABEL78
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX27")]
    public class MEDCOMBOBOX27
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL79")]
    public class MEDLABEL79
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL85")]
    public class MEDLABEL85
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX30")]
    public class MEDCOMBOBOX30
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL86")]
    public class MEDLABEL86
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX31")]
    public class MEDCOMBOBOX31
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL90")]
    public class MEDLABEL90
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX34")]
    public class MEDCOMBOBOX34
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL91")]
    public class MEDLABEL91
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX35")]
    public class MEDCOMBOBOX35
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL92")]
    public class MEDLABEL92
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX36")]
    public class MEDCOMBOBOX36
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL93")]
    public class MEDLABEL93
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT1")]
    public class MEDSPINEDIT1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL94")]
    public class MEDLABEL94
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT3")]
    public class MEDSPINEDIT3
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL95")]
    public class MEDLABEL95
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT4")]
    public class MEDSPINEDIT4
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL99")]
    public class MEDLABEL99
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX37")]
    public class MEDCOMBOBOX37
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX38")]
    public class MEDCOMBOBOX38
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL100")]
    public class MEDLABEL100
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX42")]
    public class MEDCOMBOBOX42
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL108")]
    public class MEDLABEL108
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL109")]
    public class MEDLABEL109
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT5")]
    public class MEDSPINEDIT5
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL119")]
    public class MEDLABEL119
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO48")]
    public class MEDMEMO48
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL120")]
    public class MEDLABEL120
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL122")]
    public class MEDLABEL122
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX52")]
    public class MEDCOMBOBOX52
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX53")]
    public class MEDCOMBOBOX53
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL124")]
    public class MEDLABEL124
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX55")]
    public class MEDCOMBOBOX55
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL127")]
    public class MEDLABEL127
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX57")]
    public class MEDCOMBOBOX57
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL129")]
    public class MEDLABEL129
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL130")]
    public class MEDLABEL130
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT7")]
    public class MEDSPINEDIT7
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL131")]
    public class MEDLABEL131
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL132")]
    public class MEDLABEL132
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT8")]
    public class MEDSPINEDIT8
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL133")]
    public class MEDLABEL133
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL134")]
    public class MEDLABEL134
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL135")]
    public class MEDLABEL135
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL136")]
    public class MEDLABEL136
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT9")]
    public class MEDSPINEDIT9
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT10")]
    public class MEDSPINEDIT10
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL137")]
    public class MEDLABEL137
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL138")]
    public class MEDLABEL138
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL139")]
    public class MEDLABEL139
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL140")]
    public class MEDLABEL140
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT11")]
    public class MEDSPINEDIT11
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT12")]
    public class MEDSPINEDIT12
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL141")]
    public class MEDLABEL141
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX59")]
    public class MEDCOMBOBOX59
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL159")]
    public class MEDLABEL159
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX34")]
    public class MEDCHECKBOX34
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX35")]
    public class MEDCHECKBOX35
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL165")]
    public class MEDLABEL165
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX38")]
    public class MEDCHECKBOX38
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX39")]
    public class MEDCHECKBOX39
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL167")]
    public class MEDLABEL167
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX40")]
    public class MEDCHECKBOX40
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX41")]
    public class MEDCHECKBOX41
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL178")]
    public class MEDLABEL178
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL179")]
    public class MEDLABEL179
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL180")]
    public class MEDLABEL180
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL183")]
    public class MEDLABEL183
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL184")]
    public class MEDLABEL184
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX66")]
    public class MEDCOMBOBOX66
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL185")]
    public class MEDLABEL185
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX67")]
    public class MEDCOMBOBOX67
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL186")]
    public class MEDLABEL186
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX68")]
    public class MEDCOMBOBOX68
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL187")]
    public class MEDLABEL187
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL188")]
    public class MEDLABEL188
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL189")]
    public class MEDLABEL189
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX69")]
    public class MEDCOMBOBOX69
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX70")]
    public class MEDCOMBOBOX70
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX71")]
    public class MEDCOMBOBOX71
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL190")]
    public class MEDLABEL190
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO63")]
    public class MEDMEMO63
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX92")]
    public class MEDCOMBOBOX92
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL258")]
    public class MEDLABEL258
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT31")]
    public class MEDSPINEDIT31
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL259")]
    public class MEDLABEL259
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL261")]
    public class MEDLABEL261
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL262")]
    public class MEDLABEL262
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT32")]
    public class MEDSPINEDIT32
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX74")]
    public class MEDCHECKBOX74
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX75")]
    public class MEDCHECKBOX75
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX78")]
    public class MEDCHECKBOX78
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX79")]
    public class MEDCHECKBOX79
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX81")]
    public class MEDCHECKBOX81
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX76")]
    public class MEDCHECKBOX76
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX77")]
    public class MEDCHECKBOX77
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX80")]
    public class MEDCHECKBOX80
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX82")]
    public class MEDCHECKBOX82
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX83")]
    public class MEDCHECKBOX83
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX84")]
    public class MEDCHECKBOX84
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX85")]
    public class MEDCHECKBOX85
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX86")]
    public class MEDCHECKBOX86
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX87")]
    public class MEDCHECKBOX87
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX88")]
    public class MEDCHECKBOX88
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX89")]
    public class MEDCHECKBOX89
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO25")]
    public class MEDMEMO25
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO27")]
    public class MEDMEMO27
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL145")]
    public class MEDLABEL145
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL147")]
    public class MEDLABEL147
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL148")]
    public class MEDLABEL148
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX47")]
    public class MEDCHECKBOX47
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX48")]
    public class MEDCHECKBOX48
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX49")]
    public class MEDCHECKBOX49
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX50")]
    public class MEDCHECKBOX50
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX51")]
    public class MEDCHECKBOX51
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL80")]
    public class MEDLABEL80
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL81")]
    public class MEDLABEL81
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL82")]
    public class MEDLABEL82
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL83")]
    public class MEDLABEL83
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL84")]
    public class MEDLABEL84
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL87")]
    public class MEDLABEL87
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL88")]
    public class MEDLABEL88
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL89")]
    public class MEDLABEL89
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL96")]
    public class MEDLABEL96
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL97")]
    public class MEDLABEL97
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL98")]
    public class MEDLABEL98
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL101")]
    public class MEDLABEL101
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL102")]
    public class MEDLABEL102
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL103")]
    public class MEDLABEL103
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL104")]
    public class MEDLABEL104
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT14")]
    public class MEDSPINEDIT14
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT15")]
    public class MEDSPINEDIT15
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT16")]
    public class MEDSPINEDIT16
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT17")]
    public class MEDSPINEDIT17
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT18")]
    public class MEDSPINEDIT18
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT19")]
    public class MEDSPINEDIT19
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX28")]
    public class MEDCOMBOBOX28
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX53")]
    public class MEDCHECKBOX53
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX54")]
    public class MEDCHECKBOX54
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX55")]
    public class MEDCHECKBOX55
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT1")]
    public class MEDDBMKB10_EDIT1
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX56")]
    public class MEDCHECKBOX56
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT3")]
    public class MEDDBMKB10_EDIT3
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX57")]
    public class MEDCHECKBOX57
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT4")]
    public class MEDDBMKB10_EDIT4
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX58")]
    public class MEDCHECKBOX58
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT5")]
    public class MEDDBMKB10_EDIT5
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL105")]
    public class MEDLABEL105
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL106")]
    public class MEDLABEL106
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL107")]
    public class MEDLABEL107
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL110")]
    public class MEDLABEL110
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX59")]
    public class MEDCHECKBOX59
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX60")]
    public class MEDCHECKBOX60
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX29")]
    public class MEDCOMBOBOX29
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX32")]
    public class MEDCOMBOBOX32
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX33")]
    public class MEDCOMBOBOX33
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX61")]
    public class MEDCHECKBOX61
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX62")]
    public class MEDCHECKBOX62
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX39")]
    public class MEDCOMBOBOX39
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "PERV")]
    public class PERV
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL111")]
    public class MEDLABEL111
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "POVT")]
    public class POVT
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "VARIKOZ")]
    public class VARIKOZ
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NESOSUD")]
    public class NESOSUD
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "OSNOVNOE")]
    public class OSNOVNOE
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTST")]
    public class SOPUTST
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "OPERACIYA")]
    public class OPERACIYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MANIPULYACIYA")]
    public class MANIPULYACIYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "LECHENIE")]
    public class LECHENIE
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "ZAPISALSYA")]
    public class ZAPISALSYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NEZAPISALSYA")]
    public class NEZAPISALSYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "OTLOZHIL")]
    public class OTLOZHIL
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "OTOLOZHILDO")]
    public class OTOLOZHILDO
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTNEVROPATOLOG")]
    public class SOPUTNEVROPATOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTTRAVMOTOLOG")]
    public class SOPUTTRAVMOTOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTREVMATOLOG")]
    public class SOPUTREVMATOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTGEMOSTAZIOLOG")]
    public class SOPUTGEMOSTAZIOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTTERAPEVT")]
    public class SOPUTTERAPEVT
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTKARDIOLOG")]
    public class SOPUTKARDIOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTENDOKRINOLOG")]
    public class SOPUTENDOKRINOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTGINEKOLOG")]
    public class SOPUTGINEKOLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTUROLOG")]
    public class SOPUTUROLOG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTHIRURG")]
    public class SOPUTHIRURG
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTDRUGOI")]
    public class SOPUTDRUGOI
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTNETREBUETSYA")]
    public class SOPUTNETREBUETSYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZSAMOZAP")]
    public class NZSAMOZAP
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZDOROGO")]
    public class NZDOROGO
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZBOITSYA")]
    public class NZBOITSYA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZZANYAT")]
    public class NZZANYAT
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZNENASTROEN")]
    public class NZNENASTROEN
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NZOZHIDALDRUGOI")]
    public class NZOZHIDALDRUGOI
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NSNETTEHNOLOGII")]
    public class NSNETTEHNOLOGII
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "CENTR")]
    public class CENTR
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL112")]
    public class MEDLABEL112
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL113")]
    public class MEDLABEL113
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NUZHNASPRAVKA")]
    public class NUZHNASPRAVKA
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "TRIKOTAZH1KL")]
    public class TRIKOTAZH1_KL
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "TRIKOTAZH")]
    public class TRIKOTAZH
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "TDLK")]
    public class TDLK
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "ZAPISALSYATDLK")]
    public class ZAPISALSYATDLK
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }

    [XmlRoot(ElementName = "NEZAPISALSYATDLK")]
    public class NEZAPISALSYATDLK
    {
        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR Medparamstr { get; set; }
    }
}