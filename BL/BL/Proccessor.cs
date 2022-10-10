namespace BL.BL
{
    public class Proccessor : IProccessor
    {
        public string Process(string inputCvs)
        {
            var delimiters = new string[] { "\\v", "\v", "\r\n", "\n"};
            string[] split = inputCvs.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> proccessedCvs = new();
            foreach (var line in split)
            {
                var lineProccessed = ProcessLine(line);
                proccessedCvs.Add(lineProccessed);
            }
            var finalResult = String.Join(Environment.NewLine, proccessedCvs.ToArray());
            return finalResult;
        }

        private string ProcessLine(string line)
        {
            var replacedDoubleQuoteCommaDoubleQuote = line.Replace("\",\"", "] [");
            var replacedFirstDoubleQuote = "[" + replacedDoubleQuoteCommaDoubleQuote.Substring(1);
            var replacedFinalDoubleQuote = replacedFirstDoubleQuote.TrimEnd('"') + "]";
            var replacedDoubleQuoteComma = replacedFinalDoubleQuote.Replace("\",", "] [");
            var replacedDoubleQuoteCommaSpate = replacedDoubleQuoteComma.Replace(",\"", "] [");
            var replacedDone = replacedDoubleQuoteCommaSpate.Split("] [");
            var finalString = string.Join("] [", replacedDone);
            return finalString;
        }
    }
}