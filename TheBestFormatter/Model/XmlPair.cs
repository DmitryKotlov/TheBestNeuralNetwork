using System.Text.Json.Serialization;

namespace TheBestFormatter.Model
{
    public class XmlPair
    {
        [JsonPropertyName("age")]
        public required int Age { get; set; }
        [JsonPropertyName("gender")]
        public required int Gender { get; set; }
        [JsonPropertyName("xml_perv")]
        public required string Perv { get; set; }
        [JsonPropertyName("xml_uzi")]
        public required string Uzi { get; set; }
    }
}