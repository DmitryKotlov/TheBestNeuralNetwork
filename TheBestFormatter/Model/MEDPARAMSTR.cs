using System.Xml.Serialization;

namespace TheBestNeuralNetwork.Model
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(MEDPARAMSTR));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (MEDPARAMSTR)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "MEDPARAMSTR")]
    public class MEDPARAMSTR
    {

        [XmlElement(ElementName = "paramStr")]
        public ParamStr ParamStr { get; set; }
    }

    [XmlRoot(ElementName = "paramStr")]
    public class ParamStr
    {
        [XmlElement(ElementName = "CAPTION")]
        public string? CAPTION { get; set; }

        [XmlElement(ElementName = "DEFFIELDNAME")]
        public string? DEFFIELDNAME { get; set; }

        [XmlElement(ElementName = "TEXT")]
        public string? TEXT { get; set; }

        [XmlElement(ElementName = "ITEMINDEX")]
        public int? ITEMINDEX { get; set; }

        [XmlElement(ElementName = "MEDDESCRIPTION")]
        public object? MEDDESCRIPTION { get; set; }

        [XmlElement(ElementName = "DATEDOUBLE")]
        public double? DATEDOUBLE { get; set; }

        [XmlElement(ElementName = "DATESTR")]
        public string? DATESTR { get; set; }

        [XmlElement(ElementName = "DATETIMESTR")]
        public string? DATETIMESTR { get; set; }

        [XmlElement(ElementName = "LINES")]
        public string? LINES { get; set; }

        [XmlElement(ElementName = "CHECKED")]
        public int? CHECKED { get; set; }

        [XmlElement(ElementName = "CHECKEDNAME")]
        public string? CHECKEDNAME { get; set; }

        [XmlElement(ElementName = "VALUE")]
        public int? VALUE { get; set; }

        [XmlElement(ElementName = "ASSIGNEDQUOTES_MAXQUOTEVALUE")]
        public int? ASSIGNEDQUOTESMAXQUOTEVALUE { get; set; }

        [XmlElement(ElementName = "ASSIGNEDQUOTES_MINQUOTEVALUE")]
        public int? ASSIGNEDQUOTESMINQUOTEVALUE { get; set; }

        [XmlElement(ElementName = "MINQUOTEVALUE")]
        public int? MINQUOTEVALUE { get; set; }

        [XmlElement(ElementName = "MAXQUOTEVALUE")]
        public int MAXQUOTEVALUE { get; set; }

        [XmlElement(ElementName = "LESSMINCOLOR")]
        public int LESSMINCOLOR { get; set; }

        [XmlElement(ElementName = "MOREMAXCOLOR")]
        public int MOREMAXCOLOR { get; set; }

        [XmlElement(ElementName = "ACTIVECOLOR")]
        public int ACTIVECOLOR { get; set; }

        [XmlElement(ElementName = "HTMLACTIVECOLOR")]
        public string HTMLACTIVECOLOR { get; set; }

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "CODE")]
        public string CODE { get; set; }

        [XmlElement(ElementName = "NAME")]
        public string NAME { get; set; }

        [XmlElement(ElementName = "MEDLABEL1")]
        public MEDLABEL1 MEDLABEL1 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX1")]
        public MEDCOMBOBOX1 MEDCOMBOBOX1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL2")]
        public MEDLABEL2 MEDLABEL2 { get; set; }

        [XmlElement(ElementName = "MEDDATEEDIT1")]
        public MEDDATEEDIT1 MEDDATEEDIT1 { get; set; }

        [XmlElement(ElementName = "MEDMEMO1")]
        public MEDMEMO1 MEDMEMO1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL4")]
        public MEDLABEL4 MEDLABEL4 { get; set; }

        [XmlElement(ElementName = "MEDMEMO2")]
        public MEDMEMO2 MEDMEMO2 { get; set; }

        [XmlElement(ElementName = "MEDMEMO3")]
        public MEDMEMO3 MEDMEMO3 { get; set; }
        [XmlElement(ElementName = "MEDMEMO4")]
        public MEDMEMO3 MEDMEMO4 { get; set; }
        [XmlElement(ElementName = "MEDMEMO5")]
        public MEDMEMO3 MEDMEMO5 { get; set; }
        [XmlElement(ElementName = "MEDMEMO6")]
        public MEDMEMO3 MEDMEMO6 { get; set; }
        [XmlElement(ElementName = "MEDMEMO7")]
        public MEDMEMO3 MEDMEMO7 { get; set; }
        [XmlElement(ElementName = "MEDMEMO8")]
        public MEDMEMO3 MEDMEMO8 { get; set; }
        [XmlElement(ElementName = "MEDMEMO9")]
        public MEDMEMO3 MEDMEMO9 { get; set; }
        [XmlElement(ElementName = "MEDMEMO13")]
        public MEDMEMO3 MEDMEMO13 { get; set; }
        [XmlElement(ElementName = "MEDMEMO14")]
        public MEDMEMO3 MEDMEMO14 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX1")]
        public MEDCHECKBOX1 MEDCHECKBOX1 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX2")]
        public MEDCHECKBOX2 MEDCHECKBOX2 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX3")]
        public MEDCHECKBOX3 MEDCHECKBOX3 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX4")]
        public MEDCHECKBOX4 MEDCHECKBOX4 { get; set; }

        [XmlElement(ElementName = "MEDLABEL11")]
        public MEDLABEL11 MEDLABEL11 { get; set; }

        [XmlElement(ElementName = "MEDLABEL12")]
        public MEDLABEL12 MEDLABEL12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL15")]
        public MEDLABEL15 MEDLABEL15 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX6")]
        public MEDCOMBOBOX6 MEDCOMBOBOX6 { get; set; }

        [XmlElement(ElementName = "MEDLABEL19")]
        public MEDLABEL19 MEDLABEL19 { get; set; }

        [XmlElement(ElementName = "MEDLABEL20")]
        public MEDLABEL20 MEDLABEL20 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX6")]
        public MEDCHECKBOX6 MEDCHECKBOX6 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX7")]
        public MEDCHECKBOX7 MEDCHECKBOX7 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX8")]
        public MEDCHECKBOX8 MEDCHECKBOX8 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX9")]
        public MEDCHECKBOX9 MEDCHECKBOX9 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX10")]
        public MEDCHECKBOX10 MEDCHECKBOX10 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX11")]
        public MEDCHECKBOX11 MEDCHECKBOX11 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX12")]
        public MEDCHECKBOX12 MEDCHECKBOX12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL25")]
        public MEDLABEL25 MEDLABEL25 { get; set; }

        [XmlElement(ElementName = "MEDLABEL26")]
        public MEDLABEL26 MEDLABEL26 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX13")]
        public MEDCHECKBOX13 MEDCHECKBOX13 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX14")]
        public MEDCHECKBOX14 MEDCHECKBOX14 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX15")]
        public MEDCHECKBOX15 MEDCHECKBOX15 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX16")]
        public MEDCHECKBOX16 MEDCHECKBOX16 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX17")]
        public MEDCHECKBOX17 MEDCHECKBOX17 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX18")]
        public MEDCHECKBOX18 MEDCHECKBOX18 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX19")]
        public MEDCHECKBOX19 MEDCHECKBOX19 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX20")]
        public MEDCHECKBOX20 MEDCHECKBOX20 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX21")]
        public MEDCHECKBOX21 MEDCHECKBOX21 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX22")]
        public MEDCHECKBOX22 MEDCHECKBOX22 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX23")]
        public MEDCHECKBOX23 MEDCHECKBOX23 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX27")]
        public MEDCHECKBOX27 MEDCHECKBOX27 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX28")]
        public MEDCHECKBOX28 MEDCHECKBOX28 { get; set; }

        [XmlElement(ElementName = "MEDLABEL32")]
        public MEDLABEL32 MEDLABEL32 { get; set; }

        [XmlElement(ElementName = "MEDLABEL35")]
        public MEDLABEL35 MEDLABEL35 { get; set; }

        [XmlElement(ElementName = "MEDMEMO21")]
        public MEDMEMO21 MEDMEMO21 { get; set; }

        [XmlElement(ElementName = "MEDLABEL72")]
        public MEDLABEL72 MEDLABEL72 { get; set; }

        [XmlElement(ElementName = "MEDLABEL73")]
        public MEDLABEL73 MEDLABEL73 { get; set; }

        [XmlElement(ElementName = "MEDLABEL74")]
        public MEDLABEL74 MEDLABEL74 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX25")]
        public MEDCOMBOBOX25 MEDCOMBOBOX25 { get; set; }

        [XmlElement(ElementName = "MEDLABEL75")]
        public MEDLABEL75 MEDLABEL75 { get; set; }

        [XmlElement(ElementName = "MEDLABEL76")]
        public MEDLABEL76 MEDLABEL76 { get; set; }

        [XmlElement(ElementName = "MEDLABEL77")]
        public MEDLABEL77 MEDLABEL77 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX26")]
        public MEDCOMBOBOX26 MEDCOMBOBOX26 { get; set; }

        [XmlElement(ElementName = "MEDLABEL78")]
        public MEDLABEL78 MEDLABEL78 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX27")]
        public MEDCOMBOBOX27 MEDCOMBOBOX27 { get; set; }

        [XmlElement(ElementName = "MEDLABEL79")]
        public MEDLABEL79 MEDLABEL79 { get; set; }

        [XmlElement(ElementName = "MEDLABEL85")]
        public MEDLABEL85 MEDLABEL85 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX30")]
        public MEDCOMBOBOX30 MEDCOMBOBOX30 { get; set; }

        [XmlElement(ElementName = "MEDLABEL86")]
        public MEDLABEL86 MEDLABEL86 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX31")]
        public MEDCOMBOBOX31 MEDCOMBOBOX31 { get; set; }

        [XmlElement(ElementName = "MEDLABEL90")]
        public MEDLABEL90 MEDLABEL90 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX34")]
        public MEDCOMBOBOX34 MEDCOMBOBOX34 { get; set; }

        [XmlElement(ElementName = "MEDLABEL91")]
        public MEDLABEL91 MEDLABEL91 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX35")]
        public MEDCOMBOBOX35 MEDCOMBOBOX35 { get; set; }

        [XmlElement(ElementName = "MEDLABEL92")]
        public MEDLABEL92 MEDLABEL92 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX36")]
        public MEDCOMBOBOX36 MEDCOMBOBOX36 { get; set; }

        [XmlElement(ElementName = "MEDLABEL93")]
        public MEDLABEL93 MEDLABEL93 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT1")]
        public MEDSPINEDIT1 MEDSPINEDIT1 { get; set; }

        [XmlElement(ElementName = "MEDLABEL94")]
        public MEDLABEL94 MEDLABEL94 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT3")]
        public MEDSPINEDIT3 MEDSPINEDIT3 { get; set; }

        [XmlElement(ElementName = "MEDLABEL95")]
        public MEDLABEL95 MEDLABEL95 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT4")]
        public MEDSPINEDIT4 MEDSPINEDIT4 { get; set; }

        [XmlElement(ElementName = "MEDLABEL99")]
        public MEDLABEL99 MEDLABEL99 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX37")]
        public MEDCOMBOBOX37 MEDCOMBOBOX37 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX38")]
        public MEDCOMBOBOX38 MEDCOMBOBOX38 { get; set; }

        [XmlElement(ElementName = "MEDLABEL100")]
        public MEDLABEL100 MEDLABEL100 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX42")]
        public MEDCOMBOBOX42 MEDCOMBOBOX42 { get; set; }

        [XmlElement(ElementName = "MEDLABEL108")]
        public MEDLABEL108 MEDLABEL108 { get; set; }

        [XmlElement(ElementName = "MEDLABEL109")]
        public MEDLABEL109 MEDLABEL109 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT5")]
        public MEDSPINEDIT5 MEDSPINEDIT5 { get; set; }

        [XmlElement(ElementName = "MEDLABEL119")]
        public MEDLABEL119 MEDLABEL119 { get; set; }

        [XmlElement(ElementName = "MEDMEMO48")]
        public MEDMEMO48 MEDMEMO48 { get; set; }

        [XmlElement(ElementName = "MEDLABEL120")]
        public MEDLABEL120 MEDLABEL120 { get; set; }

        [XmlElement(ElementName = "MEDLABEL122")]
        public MEDLABEL122 MEDLABEL122 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX52")]
        public MEDCOMBOBOX52 MEDCOMBOBOX52 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX53")]
        public MEDCOMBOBOX53 MEDCOMBOBOX53 { get; set; }

        [XmlElement(ElementName = "MEDLABEL124")]
        public MEDLABEL124 MEDLABEL124 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX55")]
        public MEDCOMBOBOX55 MEDCOMBOBOX55 { get; set; }

        [XmlElement(ElementName = "MEDLABEL127")]
        public MEDLABEL127 MEDLABEL127 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX57")]
        public MEDCOMBOBOX57 MEDCOMBOBOX57 { get; set; }

        [XmlElement(ElementName = "MEDLABEL129")]
        public MEDLABEL129 MEDLABEL129 { get; set; }

        [XmlElement(ElementName = "MEDLABEL130")]
        public MEDLABEL130 MEDLABEL130 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT7")]
        public MEDSPINEDIT7 MEDSPINEDIT7 { get; set; }

        [XmlElement(ElementName = "MEDLABEL131")]
        public MEDLABEL131 MEDLABEL131 { get; set; }

        [XmlElement(ElementName = "MEDLABEL132")]
        public MEDLABEL132 MEDLABEL132 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT8")]
        public MEDSPINEDIT8 MEDSPINEDIT8 { get; set; }

        [XmlElement(ElementName = "MEDLABEL133")]
        public MEDLABEL133 MEDLABEL133 { get; set; }

        [XmlElement(ElementName = "MEDLABEL134")]
        public MEDLABEL134 MEDLABEL134 { get; set; }

        [XmlElement(ElementName = "MEDLABEL135")]
        public MEDLABEL135 MEDLABEL135 { get; set; }

        [XmlElement(ElementName = "MEDLABEL136")]
        public MEDLABEL136 MEDLABEL136 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT9")]
        public MEDSPINEDIT9 MEDSPINEDIT9 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT10")]
        public MEDSPINEDIT10 MEDSPINEDIT10 { get; set; }

        [XmlElement(ElementName = "MEDLABEL137")]
        public MEDLABEL137 MEDLABEL137 { get; set; }

        [XmlElement(ElementName = "MEDLABEL138")]
        public MEDLABEL138 MEDLABEL138 { get; set; }

        [XmlElement(ElementName = "MEDLABEL139")]
        public MEDLABEL139 MEDLABEL139 { get; set; }

        [XmlElement(ElementName = "MEDLABEL140")]
        public MEDLABEL140 MEDLABEL140 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT11")]
        public MEDSPINEDIT11 MEDSPINEDIT11 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT12")]
        public MEDSPINEDIT12 MEDSPINEDIT12 { get; set; }

        [XmlElement(ElementName = "MEDLABEL141")]
        public MEDLABEL141 MEDLABEL141 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX59")]
        public MEDCOMBOBOX59 MEDCOMBOBOX59 { get; set; }

        [XmlElement(ElementName = "MEDLABEL159")]
        public MEDLABEL159 MEDLABEL159 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX34")]
        public MEDCHECKBOX34 MEDCHECKBOX34 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX35")]
        public MEDCHECKBOX35 MEDCHECKBOX35 { get; set; }

        [XmlElement(ElementName = "MEDLABEL165")]
        public MEDLABEL165 MEDLABEL165 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX38")]
        public MEDCHECKBOX38 MEDCHECKBOX38 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX39")]
        public MEDCHECKBOX39 MEDCHECKBOX39 { get; set; }

        [XmlElement(ElementName = "MEDLABEL167")]
        public MEDLABEL167 MEDLABEL167 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX40")]
        public MEDCHECKBOX40 MEDCHECKBOX40 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX41")]
        public MEDCHECKBOX41 MEDCHECKBOX41 { get; set; }

        [XmlElement(ElementName = "MEDLABEL178")]
        public MEDLABEL178 MEDLABEL178 { get; set; }

        [XmlElement(ElementName = "MEDLABEL179")]
        public MEDLABEL179 MEDLABEL179 { get; set; }

        [XmlElement(ElementName = "MEDLABEL180")]
        public MEDLABEL180 MEDLABEL180 { get; set; }

        [XmlElement(ElementName = "MEDLABEL183")]
        public MEDLABEL183 MEDLABEL183 { get; set; }

        [XmlElement(ElementName = "MEDLABEL184")]
        public MEDLABEL184 MEDLABEL184 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX66")]
        public MEDCOMBOBOX66 MEDCOMBOBOX66 { get; set; }

        [XmlElement(ElementName = "MEDLABEL185")]
        public MEDLABEL185 MEDLABEL185 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX67")]
        public MEDCOMBOBOX67 MEDCOMBOBOX67 { get; set; }

        [XmlElement(ElementName = "MEDLABEL186")]
        public MEDLABEL186 MEDLABEL186 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX68")]
        public MEDCOMBOBOX68 MEDCOMBOBOX68 { get; set; }

        [XmlElement(ElementName = "MEDLABEL187")]
        public MEDLABEL187 MEDLABEL187 { get; set; }

        [XmlElement(ElementName = "MEDLABEL188")]
        public MEDLABEL188 MEDLABEL188 { get; set; }

        [XmlElement(ElementName = "MEDLABEL189")]
        public MEDLABEL189 MEDLABEL189 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX69")]
        public MEDCOMBOBOX69 MEDCOMBOBOX69 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX70")]
        public MEDCOMBOBOX70 MEDCOMBOBOX70 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX71")]
        public MEDCOMBOBOX71 MEDCOMBOBOX71 { get; set; }

        [XmlElement(ElementName = "MEDLABEL190")]
        public MEDLABEL190 MEDLABEL190 { get; set; }

        [XmlElement(ElementName = "MEDMEMO63")]
        public MEDMEMO63 MEDMEMO63 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX92")]
        public MEDCOMBOBOX92 MEDCOMBOBOX92 { get; set; }

        [XmlElement(ElementName = "MEDLABEL258")]
        public MEDLABEL258 MEDLABEL258 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT31")]
        public MEDSPINEDIT31 MEDSPINEDIT31 { get; set; }

        [XmlElement(ElementName = "MEDLABEL259")]
        public MEDLABEL259 MEDLABEL259 { get; set; }

        [XmlElement(ElementName = "MEDLABEL261")]
        public MEDLABEL261 MEDLABEL261 { get; set; }

        [XmlElement(ElementName = "MEDLABEL262")]
        public MEDLABEL262 MEDLABEL262 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT32")]
        public MEDSPINEDIT32 MEDSPINEDIT32 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX74")]
        public MEDCHECKBOX74 MEDCHECKBOX74 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX75")]
        public MEDCHECKBOX75 MEDCHECKBOX75 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX78")]
        public MEDCHECKBOX78 MEDCHECKBOX78 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX79")]
        public MEDCHECKBOX79 MEDCHECKBOX79 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX81")]
        public MEDCHECKBOX81 MEDCHECKBOX81 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX76")]
        public MEDCHECKBOX76 MEDCHECKBOX76 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX77")]
        public MEDCHECKBOX77 MEDCHECKBOX77 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX80")]
        public MEDCHECKBOX80 MEDCHECKBOX80 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX82")]
        public MEDCHECKBOX82 MEDCHECKBOX82 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX83")]
        public MEDCHECKBOX83 MEDCHECKBOX83 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX84")]
        public MEDCHECKBOX84 MEDCHECKBOX84 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX85")]
        public MEDCHECKBOX85 MEDCHECKBOX85 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX86")]
        public MEDCHECKBOX86 MEDCHECKBOX86 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX87")]
        public MEDCHECKBOX87 MEDCHECKBOX87 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX88")]
        public MEDCHECKBOX88 MEDCHECKBOX88 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX89")]
        public MEDCHECKBOX89 MEDCHECKBOX89 { get; set; }

        [XmlElement(ElementName = "MEDMEMO25")]
        public MEDMEMO25 MEDMEMO25 { get; set; }

        [XmlElement(ElementName = "MEDMEMO27")]
        public MEDMEMO27 MEDMEMO27 { get; set; }

        [XmlElement(ElementName = "MEDLABEL145")]
        public MEDLABEL145 MEDLABEL145 { get; set; }

        [XmlElement(ElementName = "MEDLABEL147")]
        public MEDLABEL147 MEDLABEL147 { get; set; }

        [XmlElement(ElementName = "MEDLABEL148")]
        public MEDLABEL148 MEDLABEL148 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX47")]
        public MEDCHECKBOX47 MEDCHECKBOX47 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX48")]
        public MEDCHECKBOX48 MEDCHECKBOX48 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX49")]
        public MEDCHECKBOX49 MEDCHECKBOX49 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX50")]
        public MEDCHECKBOX50 MEDCHECKBOX50 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX51")]
        public MEDCHECKBOX51 MEDCHECKBOX51 { get; set; }

        [XmlElement(ElementName = "MEDLABEL80")]
        public MEDLABEL80 MEDLABEL80 { get; set; }

        [XmlElement(ElementName = "MEDLABEL81")]
        public MEDLABEL81 MEDLABEL81 { get; set; }

        [XmlElement(ElementName = "MEDLABEL82")]
        public MEDLABEL82 MEDLABEL82 { get; set; }

        [XmlElement(ElementName = "MEDLABEL83")]
        public MEDLABEL83 MEDLABEL83 { get; set; }

        [XmlElement(ElementName = "MEDLABEL84")]
        public MEDLABEL84 MEDLABEL84 { get; set; }

        [XmlElement(ElementName = "MEDLABEL87")]
        public MEDLABEL87 MEDLABEL87 { get; set; }

        [XmlElement(ElementName = "MEDLABEL88")]
        public MEDLABEL88 MEDLABEL88 { get; set; }

        [XmlElement(ElementName = "MEDLABEL89")]
        public MEDLABEL89 MEDLABEL89 { get; set; }

        [XmlElement(ElementName = "MEDLABEL96")]
        public MEDLABEL96 MEDLABEL96 { get; set; }

        [XmlElement(ElementName = "MEDLABEL97")]
        public MEDLABEL97 MEDLABEL97 { get; set; }

        [XmlElement(ElementName = "MEDLABEL98")]
        public MEDLABEL98 MEDLABEL98 { get; set; }

        [XmlElement(ElementName = "MEDLABEL101")]
        public MEDLABEL101 MEDLABEL101 { get; set; }

        [XmlElement(ElementName = "MEDLABEL102")]
        public MEDLABEL102 MEDLABEL102 { get; set; }

        [XmlElement(ElementName = "MEDLABEL103")]
        public MEDLABEL103 MEDLABEL103 { get; set; }

        [XmlElement(ElementName = "MEDLABEL104")]
        public MEDLABEL104 MEDLABEL104 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT14")]
        public MEDSPINEDIT14 MEDSPINEDIT14 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT15")]
        public MEDSPINEDIT15 MEDSPINEDIT15 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT16")]
        public MEDSPINEDIT16 MEDSPINEDIT16 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT17")]
        public MEDSPINEDIT17 MEDSPINEDIT17 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT18")]
        public MEDSPINEDIT18 MEDSPINEDIT18 { get; set; }

        [XmlElement(ElementName = "MEDSPINEDIT19")]
        public MEDSPINEDIT19 MEDSPINEDIT19 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX28")]
        public MEDCOMBOBOX28 MEDCOMBOBOX28 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX53")]
        public MEDCHECKBOX53 MEDCHECKBOX53 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX54")]
        public MEDCHECKBOX54 MEDCHECKBOX54 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX55")]
        public MEDCHECKBOX55 MEDCHECKBOX55 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT1")]
        public MEDDBMKB10EDIT1 MEDDBMKB10EDIT1 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX56")]
        public MEDCHECKBOX56 MEDCHECKBOX56 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT3")]
        public MEDDBMKB10EDIT3 MEDDBMKB10EDIT3 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX57")]
        public MEDCHECKBOX57 MEDCHECKBOX57 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT4")]
        public MEDDBMKB10EDIT4 MEDDBMKB10EDIT4 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX58")]
        public MEDCHECKBOX58 MEDCHECKBOX58 { get; set; }

        [XmlElement(ElementName = "MEDDBMKB10EDIT5")]
        public MEDDBMKB10EDIT5 MEDDBMKB10EDIT5 { get; set; }

        [XmlElement(ElementName = "MEDLABEL105")]
        public MEDLABEL105 MEDLABEL105 { get; set; }

        [XmlElement(ElementName = "MEDLABEL106")]
        public MEDLABEL106 MEDLABEL106 { get; set; }

        [XmlElement(ElementName = "MEDLABEL107")]
        public MEDLABEL107 MEDLABEL107 { get; set; }

        [XmlElement(ElementName = "MEDLABEL110")]
        public MEDLABEL110 MEDLABEL110 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX59")]
        public MEDCHECKBOX59 MEDCHECKBOX59 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX60")]
        public MEDCHECKBOX60 MEDCHECKBOX60 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX29")]
        public MEDCOMBOBOX29 MEDCOMBOBOX29 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX32")]
        public MEDCOMBOBOX32 MEDCOMBOBOX32 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX33")]
        public MEDCOMBOBOX33 MEDCOMBOBOX33 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX61")]
        public MEDCHECKBOX61 MEDCHECKBOX61 { get; set; }

        [XmlElement(ElementName = "MEDCHECKBOX62")]
        public MEDCHECKBOX62 MEDCHECKBOX62 { get; set; }

        [XmlElement(ElementName = "MEDCOMBOBOX39")]
        public MEDCOMBOBOX39 MEDCOMBOBOX39 { get; set; }

        [XmlElement(ElementName = "PERV")]
        public PERV PERV { get; set; }

        [XmlElement(ElementName = "MEDLABEL111")]
        public MEDLABEL111 MEDLABEL111 { get; set; }

        [XmlElement(ElementName = "POVT")]
        public POVT POVT { get; set; }

        [XmlElement(ElementName = "VARIKOZ")]
        public VARIKOZ VARIKOZ { get; set; }

        [XmlElement(ElementName = "NESOSUD")]
        public NESOSUD NESOSUD { get; set; }

        [XmlElement(ElementName = "OSNOVNOE")]
        public OSNOVNOE OSNOVNOE { get; set; }

        [XmlElement(ElementName = "SOPUTST")]
        public SOPUTST SOPUTST { get; set; }

        [XmlElement(ElementName = "OPERACIYA")]
        public OPERACIYA OPERACIYA { get; set; }

        [XmlElement(ElementName = "MANIPULYACIYA")]
        public MANIPULYACIYA MANIPULYACIYA { get; set; }

        [XmlElement(ElementName = "LECHENIE")]
        public LECHENIE LECHENIE { get; set; }

        [XmlElement(ElementName = "ZAPISALSYA")]
        public ZAPISALSYA ZAPISALSYA { get; set; }

        [XmlElement(ElementName = "NEZAPISALSYA")]
        public NEZAPISALSYA NEZAPISALSYA { get; set; }

        [XmlElement(ElementName = "OTLOZHIL")]
        public OTLOZHIL OTLOZHIL { get; set; }

        [XmlElement(ElementName = "OTOLOZHILDO")]
        public OTOLOZHILDO OTOLOZHILDO { get; set; }

        [XmlElement(ElementName = "SOPUTNEVROPATOLOG")]
        public SOPUTNEVROPATOLOG SOPUTNEVROPATOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTTRAVMOTOLOG")]
        public SOPUTTRAVMOTOLOG SOPUTTRAVMOTOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTREVMATOLOG")]
        public SOPUTREVMATOLOG SOPUTREVMATOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTGEMOSTAZIOLOG")]
        public SOPUTGEMOSTAZIOLOG SOPUTGEMOSTAZIOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTTERAPEVT")]
        public SOPUTTERAPEVT SOPUTTERAPEVT { get; set; }

        [XmlElement(ElementName = "SOPUTKARDIOLOG")]
        public SOPUTKARDIOLOG SOPUTKARDIOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTENDOKRINOLOG")]
        public SOPUTENDOKRINOLOG SOPUTENDOKRINOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTGINEKOLOG")]
        public SOPUTGINEKOLOG SOPUTGINEKOLOG { get; set; }

        [XmlElement(ElementName = "SOPUTUROLOG")]
        public SOPUTUROLOG SOPUTUROLOG { get; set; }

        [XmlElement(ElementName = "SOPUTHIRURG")]
        public SOPUTHIRURG SOPUTHIRURG { get; set; }

        [XmlElement(ElementName = "SOPUTDRUGOI")]
        public SOPUTDRUGOI SOPUTDRUGOI { get; set; }

        [XmlElement(ElementName = "SOPUTNETREBUETSYA")]
        public SOPUTNETREBUETSYA SOPUTNETREBUETSYA { get; set; }

        [XmlElement(ElementName = "NZSAMOZAP")]
        public NZSAMOZAP NZSAMOZAP { get; set; }

        [XmlElement(ElementName = "NZDOROGO")]
        public NZDOROGO NZDOROGO { get; set; }

        [XmlElement(ElementName = "NZBOITSYA")]
        public NZBOITSYA NZBOITSYA { get; set; }

        [XmlElement(ElementName = "NZZANYAT")]
        public NZZANYAT NZZANYAT { get; set; }

        [XmlElement(ElementName = "NZNENASTROEN")]
        public NZNENASTROEN NZNENASTROEN { get; set; }

        [XmlElement(ElementName = "NZOZHIDALDRUGOI")]
        public NZOZHIDALDRUGOI NZOZHIDALDRUGOI { get; set; }

        [XmlElement(ElementName = "NSNETTEHNOLOGII")]
        public NSNETTEHNOLOGII NSNETTEHNOLOGII { get; set; }

        [XmlElement(ElementName = "CENTR")]
        public CENTR CENTR { get; set; }

        [XmlElement(ElementName = "MEDLABEL112")]
        public MEDLABEL112 MEDLABEL112 { get; set; }

        [XmlElement(ElementName = "MEDLABEL113")]
        public MEDLABEL113 MEDLABEL113 { get; set; }

        [XmlElement(ElementName = "NUZHNASPRAVKA")]
        public NUZHNASPRAVKA NUZHNASPRAVKA { get; set; }

        [XmlElement(ElementName = "TRIKOTAZH1KL")]
        public TRIKOTAZH1KL TRIKOTAZH1KL { get; set; }

        [XmlElement(ElementName = "TRIKOTAZH")]
        public TRIKOTAZH TRIKOTAZH { get; set; }

        [XmlElement(ElementName = "TDLK")]
        public TDLK TDLK { get; set; }

        [XmlElement(ElementName = "ZAPISALSYATDLK")]
        public ZAPISALSYATDLK ZAPISALSYATDLK { get; set; }

        [XmlElement(ElementName = "NEZAPISALSYATDLK")]
        public NEZAPISALSYATDLK NEZAPISALSYATDLK { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL1")]
    public class MEDLABEL1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX1")]
    public class MEDCOMBOBOX1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL2")]
    public class MEDLABEL2
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDDATEEDIT1")]
    public class MEDDATEEDIT1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO1")]
    public class MEDMEMO1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL4")]
    public class MEDLABEL4
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO2")]
    public class MEDMEMO2
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO3")]
    public class MEDMEMO3
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO4")]
    public class MEDMEMO4
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO5")]
    public class MEDMEMO5
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO6")]
    public class MEDMEMO6
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO7")]
    public class MEDMEMO7
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO8")]
    public class MEDMEMO8
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO9")]
    public class MEDMEMO9
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO13")]
    public class MEDMEMO13
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO14")]
    public class MEDMEMO14
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX1")]
    public class MEDCHECKBOX1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX2")]
    public class MEDCHECKBOX2
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX3")]
    public class MEDCHECKBOX3
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX4")]
    public class MEDCHECKBOX4
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL11")]
    public class MEDLABEL11
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL12")]
    public class MEDLABEL12
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL15")]
    public class MEDLABEL15
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX6")]
    public class MEDCOMBOBOX6
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL19")]
    public class MEDLABEL19
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL20")]
    public class MEDLABEL20
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX6")]
    public class MEDCHECKBOX6
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX7")]
    public class MEDCHECKBOX7
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX8")]
    public class MEDCHECKBOX8
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX9")]
    public class MEDCHECKBOX9
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX10")]
    public class MEDCHECKBOX10
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX11")]
    public class MEDCHECKBOX11
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX12")]
    public class MEDCHECKBOX12
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL25")]
    public class MEDLABEL25
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL26")]
    public class MEDLABEL26
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX13")]
    public class MEDCHECKBOX13
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX14")]
    public class MEDCHECKBOX14
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX15")]
    public class MEDCHECKBOX15
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX16")]
    public class MEDCHECKBOX16
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX17")]
    public class MEDCHECKBOX17
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX18")]
    public class MEDCHECKBOX18
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX19")]
    public class MEDCHECKBOX19
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX20")]
    public class MEDCHECKBOX20
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX21")]
    public class MEDCHECKBOX21
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX22")]
    public class MEDCHECKBOX22
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX23")]
    public class MEDCHECKBOX23
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX27")]
    public class MEDCHECKBOX27
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX28")]
    public class MEDCHECKBOX28
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL32")]
    public class MEDLABEL32
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL35")]
    public class MEDLABEL35
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO21")]
    public class MEDMEMO21
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL72")]
    public class MEDLABEL72
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL73")]
    public class MEDLABEL73
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL74")]
    public class MEDLABEL74
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX25")]
    public class MEDCOMBOBOX25
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL75")]
    public class MEDLABEL75
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL76")]
    public class MEDLABEL76
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL77")]
    public class MEDLABEL77
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX26")]
    public class MEDCOMBOBOX26
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL78")]
    public class MEDLABEL78
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX27")]
    public class MEDCOMBOBOX27
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL79")]
    public class MEDLABEL79
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL85")]
    public class MEDLABEL85
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX30")]
    public class MEDCOMBOBOX30
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL86")]
    public class MEDLABEL86
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX31")]
    public class MEDCOMBOBOX31
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL90")]
    public class MEDLABEL90
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX34")]
    public class MEDCOMBOBOX34
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL91")]
    public class MEDLABEL91
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX35")]
    public class MEDCOMBOBOX35
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL92")]
    public class MEDLABEL92
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX36")]
    public class MEDCOMBOBOX36
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL93")]
    public class MEDLABEL93
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT1")]
    public class MEDSPINEDIT1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL94")]
    public class MEDLABEL94
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT3")]
    public class MEDSPINEDIT3
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL95")]
    public class MEDLABEL95
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT4")]
    public class MEDSPINEDIT4
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL99")]
    public class MEDLABEL99
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX37")]
    public class MEDCOMBOBOX37
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX38")]
    public class MEDCOMBOBOX38
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL100")]
    public class MEDLABEL100
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX42")]
    public class MEDCOMBOBOX42
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL108")]
    public class MEDLABEL108
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL109")]
    public class MEDLABEL109
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT5")]
    public class MEDSPINEDIT5
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL119")]
    public class MEDLABEL119
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO48")]
    public class MEDMEMO48
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL120")]
    public class MEDLABEL120
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL122")]
    public class MEDLABEL122
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX52")]
    public class MEDCOMBOBOX52
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX53")]
    public class MEDCOMBOBOX53
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL124")]
    public class MEDLABEL124
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX55")]
    public class MEDCOMBOBOX55
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL127")]
    public class MEDLABEL127
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX57")]
    public class MEDCOMBOBOX57
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL129")]
    public class MEDLABEL129
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL130")]
    public class MEDLABEL130
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT7")]
    public class MEDSPINEDIT7
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL131")]
    public class MEDLABEL131
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL132")]
    public class MEDLABEL132
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT8")]
    public class MEDSPINEDIT8
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL133")]
    public class MEDLABEL133
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL134")]
    public class MEDLABEL134
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL135")]
    public class MEDLABEL135
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL136")]
    public class MEDLABEL136
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT9")]
    public class MEDSPINEDIT9
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT10")]
    public class MEDSPINEDIT10
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL137")]
    public class MEDLABEL137
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL138")]
    public class MEDLABEL138
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL139")]
    public class MEDLABEL139
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL140")]
    public class MEDLABEL140
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT11")]
    public class MEDSPINEDIT11
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT12")]
    public class MEDSPINEDIT12
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL141")]
    public class MEDLABEL141
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX59")]
    public class MEDCOMBOBOX59
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL159")]
    public class MEDLABEL159
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX34")]
    public class MEDCHECKBOX34
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX35")]
    public class MEDCHECKBOX35
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL165")]
    public class MEDLABEL165
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX38")]
    public class MEDCHECKBOX38
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX39")]
    public class MEDCHECKBOX39
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL167")]
    public class MEDLABEL167
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX40")]
    public class MEDCHECKBOX40
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX41")]
    public class MEDCHECKBOX41
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL178")]
    public class MEDLABEL178
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL179")]
    public class MEDLABEL179
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL180")]
    public class MEDLABEL180
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL183")]
    public class MEDLABEL183
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL184")]
    public class MEDLABEL184
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX66")]
    public class MEDCOMBOBOX66
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL185")]
    public class MEDLABEL185
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX67")]
    public class MEDCOMBOBOX67
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL186")]
    public class MEDLABEL186
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX68")]
    public class MEDCOMBOBOX68
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL187")]
    public class MEDLABEL187
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL188")]
    public class MEDLABEL188
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL189")]
    public class MEDLABEL189
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX69")]
    public class MEDCOMBOBOX69
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX70")]
    public class MEDCOMBOBOX70
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX71")]
    public class MEDCOMBOBOX71
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL190")]
    public class MEDLABEL190
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO63")]
    public class MEDMEMO63
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX92")]
    public class MEDCOMBOBOX92
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL258")]
    public class MEDLABEL258
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT31")]
    public class MEDSPINEDIT31
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL259")]
    public class MEDLABEL259
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL261")]
    public class MEDLABEL261
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL262")]
    public class MEDLABEL262
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT32")]
    public class MEDSPINEDIT32
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX74")]
    public class MEDCHECKBOX74
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX75")]
    public class MEDCHECKBOX75
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX78")]
    public class MEDCHECKBOX78
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX79")]
    public class MEDCHECKBOX79
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX81")]
    public class MEDCHECKBOX81
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX76")]
    public class MEDCHECKBOX76
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX77")]
    public class MEDCHECKBOX77
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX80")]
    public class MEDCHECKBOX80
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX82")]
    public class MEDCHECKBOX82
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX83")]
    public class MEDCHECKBOX83
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX84")]
    public class MEDCHECKBOX84
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX85")]
    public class MEDCHECKBOX85
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX86")]
    public class MEDCHECKBOX86
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX87")]
    public class MEDCHECKBOX87
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX88")]
    public class MEDCHECKBOX88
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX89")]
    public class MEDCHECKBOX89
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO25")]
    public class MEDMEMO25
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDMEMO27")]
    public class MEDMEMO27
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL145")]
    public class MEDLABEL145
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL147")]
    public class MEDLABEL147
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL148")]
    public class MEDLABEL148
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX47")]
    public class MEDCHECKBOX47
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX48")]
    public class MEDCHECKBOX48
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX49")]
    public class MEDCHECKBOX49
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX50")]
    public class MEDCHECKBOX50
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX51")]
    public class MEDCHECKBOX51
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL80")]
    public class MEDLABEL80
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL81")]
    public class MEDLABEL81
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL82")]
    public class MEDLABEL82
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL83")]
    public class MEDLABEL83
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL84")]
    public class MEDLABEL84
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL87")]
    public class MEDLABEL87
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL88")]
    public class MEDLABEL88
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL89")]
    public class MEDLABEL89
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL96")]
    public class MEDLABEL96
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL97")]
    public class MEDLABEL97
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL98")]
    public class MEDLABEL98
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL101")]
    public class MEDLABEL101
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL102")]
    public class MEDLABEL102
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL103")]
    public class MEDLABEL103
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL104")]
    public class MEDLABEL104
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT14")]
    public class MEDSPINEDIT14
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT15")]
    public class MEDSPINEDIT15
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT16")]
    public class MEDSPINEDIT16
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT17")]
    public class MEDSPINEDIT17
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT18")]
    public class MEDSPINEDIT18
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDSPINEDIT19")]
    public class MEDSPINEDIT19
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX28")]
    public class MEDCOMBOBOX28
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX53")]
    public class MEDCHECKBOX53
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX54")]
    public class MEDCHECKBOX54
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX55")]
    public class MEDCHECKBOX55
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT1")]
    public class MEDDBMKB10EDIT1
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX56")]
    public class MEDCHECKBOX56
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT3")]
    public class MEDDBMKB10EDIT3
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX57")]
    public class MEDCHECKBOX57
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT4")]
    public class MEDDBMKB10EDIT4
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX58")]
    public class MEDCHECKBOX58
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDDBMKB10EDIT5")]
    public class MEDDBMKB10EDIT5
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL105")]
    public class MEDLABEL105
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL106")]
    public class MEDLABEL106
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL107")]
    public class MEDLABEL107
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL110")]
    public class MEDLABEL110
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX59")]
    public class MEDCHECKBOX59
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX60")]
    public class MEDCHECKBOX60
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX29")]
    public class MEDCOMBOBOX29
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX32")]
    public class MEDCOMBOBOX32
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX33")]
    public class MEDCOMBOBOX33
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX61")]
    public class MEDCHECKBOX61
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCHECKBOX62")]
    public class MEDCHECKBOX62
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDCOMBOBOX39")]
    public class MEDCOMBOBOX39
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "PERV")]
    public class PERV
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL111")]
    public class MEDLABEL111
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "POVT")]
    public class POVT
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "VARIKOZ")]
    public class VARIKOZ
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NESOSUD")]
    public class NESOSUD
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "OSNOVNOE")]
    public class OSNOVNOE
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTST")]
    public class SOPUTST
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "OPERACIYA")]
    public class OPERACIYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MANIPULYACIYA")]
    public class MANIPULYACIYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "LECHENIE")]
    public class LECHENIE
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "ZAPISALSYA")]
    public class ZAPISALSYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NEZAPISALSYA")]
    public class NEZAPISALSYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "OTLOZHIL")]
    public class OTLOZHIL
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "OTOLOZHILDO")]
    public class OTOLOZHILDO
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTNEVROPATOLOG")]
    public class SOPUTNEVROPATOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTTRAVMOTOLOG")]
    public class SOPUTTRAVMOTOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTREVMATOLOG")]
    public class SOPUTREVMATOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTGEMOSTAZIOLOG")]
    public class SOPUTGEMOSTAZIOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTTERAPEVT")]
    public class SOPUTTERAPEVT
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTKARDIOLOG")]
    public class SOPUTKARDIOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTENDOKRINOLOG")]
    public class SOPUTENDOKRINOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTGINEKOLOG")]
    public class SOPUTGINEKOLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTUROLOG")]
    public class SOPUTUROLOG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTHIRURG")]
    public class SOPUTHIRURG
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTDRUGOI")]
    public class SOPUTDRUGOI
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "SOPUTNETREBUETSYA")]
    public class SOPUTNETREBUETSYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZSAMOZAP")]
    public class NZSAMOZAP
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZDOROGO")]
    public class NZDOROGO
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZBOITSYA")]
    public class NZBOITSYA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZZANYAT")]
    public class NZZANYAT
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZNENASTROEN")]
    public class NZNENASTROEN
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NZOZHIDALDRUGOI")]
    public class NZOZHIDALDRUGOI
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NSNETTEHNOLOGII")]
    public class NSNETTEHNOLOGII
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "CENTR")]
    public class CENTR
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL112")]
    public class MEDLABEL112
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "MEDLABEL113")]
    public class MEDLABEL113
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NUZHNASPRAVKA")]
    public class NUZHNASPRAVKA
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "TRIKOTAZH1KL")]
    public class TRIKOTAZH1KL
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "TRIKOTAZH")]
    public class TRIKOTAZH
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "TDLK")]
    public class TDLK
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "ZAPISALSYATDLK")]
    public class ZAPISALSYATDLK
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }

    [XmlRoot(ElementName = "NEZAPISALSYATDLK")]
    public class NEZAPISALSYATDLK
    {

        [XmlElement(ElementName = "MEDPARAMSTR")]
        public MEDPARAMSTR MEDPARAMSTR { get; set; }
    }


}
