namespace BL.BL
{
    public class Proccessor : IProccessor
    {
        public string Process(string inputCvs)
        {
            var replacedDoubleQuoteCommaDoubleQuote = inputCvs.Replace("\",\"", "] [");
            var replacedFirstDoubleQuote = "[" + replacedDoubleQuoteCommaDoubleQuote.Substring(1);
            var replacedFinalDoubleQuote = replacedFirstDoubleQuote.TrimEnd('"') + "]";
            var replacedDoubleQuoteComma = replacedFinalDoubleQuote.Replace("\",", "] [");
            var replacedDoubleQuoteCommaSpate = replacedDoubleQuoteComma.Replace(",\"", "] [");
            var basicReplacedDone = replacedDoubleQuoteCommaSpate.Split("] [");
            for (var i = 0; i < basicReplacedDone.Length; i++)
            {
                basicReplacedDone[i] = basicReplacedDone[i].Replace(" =", "=");
                basicReplacedDone[i] = basicReplacedDone[i].Replace("= ", "=");
                if (!basicReplacedDone[i].Contains(", "))
                {
                    continue;
                }
                var token = basicReplacedDone[i];
                var commaFoundIndex = token.IndexOf(',');
                var charBefore = token.Substring(commaFoundIndex - 1, 1);
                if (!int.TryParse(charBefore, out _))
                {
                    continue;
                }
                basicReplacedDone[i] = basicReplacedDone[i].Replace(", ", ",");
            }
            var finalString = string.Join("] [", basicReplacedDone);
            return finalString;
        }
    }
}