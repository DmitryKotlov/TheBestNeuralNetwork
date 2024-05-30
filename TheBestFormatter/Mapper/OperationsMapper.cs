using System.Text.RegularExpressions;
using TheBestDomain;

namespace TheBestFormatter.Mapper
{
    public static class OperationsMapper
    {
        public static Operations Map(string tactics, bool isLeftSide)
        {
            var regexTactics = Regex.Replace(tactics, "[^A-Za-zA-Яа-я]", "");
            var strings = regexTactics.Trim().ToUpper().Split(@"\R\N");

            var operations = new Operations();

            foreach (var subString in strings)
            {
                if (isLeftSide)
                {
                    if (subString.Contains("СЛЕВА"))
                    {
                        FillOperationData(operations, subString);
                    }
                }
                else
                {
                    if (subString.Contains("СПРАВА"))
                    {
                        FillOperationData(operations, subString);
                    }
                }
            }

            return operations;
        }

        private static void FillOperationData(Operations operations, string tactic)
        {
            if (tactic.Contains("ЭВЛК"))
            {
                if (tactic.Contains("МПВ"))
                {
                    operations.EvlkMpv = true;
                }

                if (tactic.Contains("БПВ"))
                {
                    operations.EvlkBpv = true;
                }
            }

            if (tactic.Contains("РЧО"))
            {
                operations.Rho = true;
            }

            if (tactic.Contains("ФЛЕБЭКТО"))
            {
                if (tactic.Contains("ЛОКАЛЬН"))
                {
                    operations.LocalFleb = true;
                }
                else
                {
                    operations.Fleb = true;
                }
            }

            if (tactic.Contains("КРОССЭКТОМИ"))
            {
                operations.Cross = true;
            }

            if (tactic.Contains("СКЛЕРОТЕРАПИ"))
            {
                operations.Scler = true;
            }

            if (operations.EvlkMpv
                || operations.EvlkBpv
                || operations.Rho
                || operations.LocalFleb
                || operations.Fleb
                || operations.Cross
                || operations.Scler)
            {
                operations.IsNeedAnyOperation = true;
            }
        }
    }
}