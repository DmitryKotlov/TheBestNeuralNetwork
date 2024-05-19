using System.Globalization;
using System.Text.Json;
using System.Xml.Serialization;
using TheBestNeuralNetwork.Model;
using TheBestDomain;
using TheBestFormatter.Mapper;
using CsvHelper;

namespace TheBestFormatter
{
    internal static class Program
    {
        private static async Task Main()
        {
            var xmlPairs = await LoadXmlPairs();
            var dataForModels = new List<DataForModel>();

            foreach (var xmlPair in xmlPairs)
            {
                var perv = Deserialize(xmlPair.Perv);
                var uzi = Deserialize(xmlPair.Uzi);

                dataForModels.Add(DataForModelMapper.Map(perv.ParamStr, uzi.ParamStr));
            }

            using (var writer = new StreamWriter("Resource\\Result.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(dataForModels);
            }
        }

        private static async Task<XmlPair[]> LoadXmlPairs()
        {
            const string path = "Resource\\data.json";

            return await JsonSerializer.DeserializeAsync<XmlPair[]>(File.OpenRead(path)) ?? throw new Exception("Deserialize error");
        }

        private static MEDPARAMSTR Deserialize(string str)
        {
            str = ReplaceBr(str);
            str = RemoveXml(str);
            str = RemoveSymbols(str);

            var serializer = new XmlSerializer(typeof(MEDPARAMSTR));
            using var reader = new StringReader(str);
            return (MEDPARAMSTR)serializer.Deserialize(reader)!;
        }

        private static string ReplaceBr(string str)
        {
            var angleBrackets = new Dictionary<string, string> { { "<", "&lt;" }, { ">", "&gt;" } };

            return angleBrackets.Aggregate(str, (current, pair) => current.Replace(pair.Value, pair.Key));
        }

        private static string RemoveXml(string str)
        {
            return str.Replace("<?xml version=1.0 encoding=windows-1251?>", "");
        }

        private static string RemoveSymbols(string str)
        {
            var list = new List<string>() { "\\r", "\\n", "•", "\\t" };

            return list.Aggregate(str, (current, symb) => current.Replace(symb, ""));
        }
    }
}