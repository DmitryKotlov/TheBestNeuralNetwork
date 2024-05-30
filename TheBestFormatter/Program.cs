using CsvHelper;
using System.Collections.Concurrent;
using System.Globalization;
using System.Text.Json;
using System.Xml.Serialization;
using TheBestDomain;
using TheBestFormatter.Mapper;
using TheBestFormatter.Model;
using static System.Console;

namespace TheBestFormatter
{
    internal static class Program
    {
        private static async Task Main()
        {
            var xmlPairs = await LoadXmlPairs();
            var dataForModels = ConvertToDataForModel(xmlPairs);
            await WriteCsv(dataForModels);
        }

        private static async Task<XmlPair[]> LoadXmlPairs()
        {
            const string path = "Resource\\bigData.json";
            return await JsonSerializer.DeserializeAsync<XmlPair[]>(File.OpenRead(path)) ??
                   throw new Exception("Deserialize error");
        }

        private static IEnumerable<DataForModel> ConvertToDataForModel(ICollection<XmlPair> xmlPairs)
        {
            var resultDataForModels = new ConcurrentBag<DataForModel>();

            Parallel.ForEach(xmlPairs, xmlPair =>
            {
                try
                {
                    var perv = DeserializeXml(xmlPair.Perv);
                    var uzi = DeserializeXml(xmlPair.Uzi);

                    var dataForModels = DataForModelMapper.Map(perv.ParamStr, uzi.ParamStr, xmlPair.Age,
                        xmlPair.Gender);

                    foreach (var dataForModel in dataForModels)
                    {
                        resultDataForModels.Add(dataForModel);
                    }
                }
                catch (Exception ex)
                {
                    WriteLine("Error ebat", ex.ToString());
                }
            });

            //foreach (var xmlPair in xmlPairs)
            //{
            //    try
            //    {
            //        var perv = DeserializeXml(xmlPair.Perv);
            //        var uzi = DeserializeXml(xmlPair.Uzi);

            //        dataForModels.AddRange(DataForModelMapper.Map(perv.ParamStr, uzi.ParamStr, xmlPair.Age,
            //            xmlPair.Gender));
            //    }
            //    catch(Exception ex)
            //    {
            //        WriteLine("Error ebat", ex.ToString());
            //    }
            //}

            return resultDataForModels;
        }

        private static void AA() { }

        private static MEDPARAMSTR DeserializeXml(string str)
        {
            str = ReplaceBrackets(str);
            str = RemoveXml(str);

            var serializer = new XmlSerializer(typeof(MEDPARAMSTR));
            using var reader = new StringReader(str);
            var result = (MEDPARAMSTR)serializer.Deserialize(reader)!;

            //if (result.ParamStr.IsEmpty()) //TODO
            //{
            //    throw new Exception("Xml is empty");
            //}

            return result;
        }

        private static string ReplaceBrackets(string str)
        {
            var angleBrackets = new Dictionary<string, string> { { "<", "&lt;" }, { ">", "&gt;" } };
            return angleBrackets.Aggregate(str, (current, pair) => current.Replace(pair.Value, pair.Key));
        }

        private static string RemoveXml(string str)
        {
            return str.Replace("<?xml version=1.0 encoding=windows-1251?>", "");
        }

        private static async Task WriteCsv(IEnumerable<DataForModel> dataForModels)
        {
            await using var writer = new StreamWriter("Resource\\Result.csv");
            await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            await csv.WriteRecordsAsync(dataForModels);
        }
    }
}