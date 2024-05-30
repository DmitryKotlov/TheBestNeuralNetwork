using System.Text.RegularExpressions;
using TheBestDomain;

namespace TheBestFormatter.Mapper
{
    public static class UziMapper
    {
        public static UziData Map(string memo)
        {
            var strings = SplitFormatStrings(memo);

            var data = new UziData();

            foreach (var subString in strings)
            {
                //if (withAdditionalData)
                //{
                //    FillExtendedDiameter(data, subString);
                //}
                //else
                {
                    FillDiameter(data, subString);
                }

                FillReflux(data, subString);
            }

            if (data.Diameter is null)
            {
                throw new Exception("Diameter not found");
            }

            return data;
        }

        private static IEnumerable<string> SplitFormatStrings(string input)
        {
            return input.Trim()
                .ToUpper()
                .Replace(".", ",")
                .Replace(" ", "")
                .Replace("/", "-")
                .Replace(";", "-")
                .Split(@"\R\N");
        }

        public static UziDataExtended MapExt(string memo)
        {
            var strings = SplitFormatStrings(memo);

            var data = new UziDataExtended();

            foreach (var subString in strings)
            {
                //if (withAdditionalData)
                {
                    FillExtendedDiameter(data, subString);
                }
                //else
                //{
                //    FillDiameter(data, subString);
                //}

                FillReflux(data, subString);
            }

            if (!data.PredostSegment.HasValue)
            {
                throw new Exception("Diameter not found");
            }

            return data;
        }

        private static void FillExtendedDiameter(UziDataExtended extendedDiameter, string subString)
        {
            if (extendedDiameter.PredostSegment.HasValue || !subString.Contains("ДИАМЕТР"))
            {
                return;
            }

            var diameterIndex = subString.IndexOf("ДИАМЕТР");
            var diameterSubstring = Regex.Replace(subString.Substring(diameterIndex), "[^0-9,-]", "");
            var diameterSplit = diameterSubstring.Split("-").Where(d => d.Any(char.IsDigit)).ToArray();

            if (diameterSplit.Length != 4)
            {
                throw new Exception("Diameter not found");
            }

            //var extendedDiameter = new UziDataExtended();

            for (var i = 0; i < diameterSplit.Length; i++)
            {
                if (float.TryParse(diameterSplit[i], out var value))
                {
                    switch (i)
                    {
                        case 0:
                            extendedDiameter.PredostSegment = value;
                            break;
                        case 1:
                            extendedDiameter.SredTretBedra = value;
                            break;
                        case 2:
                            extendedDiameter.UrovenKolena = value;
                            break;
                        case 3:
                            extendedDiameter.VerhSredTretGoleni = value;
                            break;
                    }
                }
                else
                {
                    throw new Exception("Diameter not found");
                }
            }
        }

        private static void FillDiameter(UziData data, string subString)
        {
            if (data.Diameter is not null || !subString.Contains("ДИАМЕТР"))
            {
                return;
            }

            var index = subString.IndexOf("ДИАМЕТР");
            var strNumber = Regex.Replace(subString.Substring(index), "[^0-9,-]", "");

            if (float.TryParse(strNumber, out var value))
            {
                data.Diameter = value;
            }
            else
            {
                throw new Exception("Diameter not found");
            }
        }

        private static void FillReflux(UziData data, string subString)
        {
            if (!subString.Contains("РЕФЛЮКС"))
            {
                return;
            }

            if (subString.Contains('+'))
            {
                data.Reflux = true;
            }
            else if (subString.Contains('-'))
            {
                data.Reflux = false;
            }
        }

        private static void FillReflux(UziDataExtended data, string subString)
        {
            if (!subString.Contains("РЕФЛЮКС"))
            {
                return;
            }

            if (subString.Contains('+'))
            {
                data.Reflux = true;
            }
            else if (subString.Contains('-'))
            {
                data.Reflux = false;
            }
        }
    }
}