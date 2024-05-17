using System.Text.Json.Serialization;

namespace TheBestNeuralNetwork.Model
{
    public class XmlPair
    {
        [JsonPropertyName("xml_perv")]
        public required string Perv { get; set; }
        [JsonPropertyName("xml_uzi")]
        public required string Uzi { get; set; }
    }
}