using System.Text;
using System.Text.RegularExpressions;

namespace AlgorithmsApp.String
{
    public class RunLengthEncoding
    {
        public static string Encode(string input)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<char, int> output = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (output.ContainsKey(c))
                {
                    output[c]++;
                }
                else
                {
                    output.Add(c, 1);
                }
            }
            foreach (var pair in output)
            {
                string val = (pair.Value > 1) ? pair.Value.ToString() : string.Empty;
                result.Append($"{val}{pair.Key}");
            }
            return result.ToString();
        }

        public static string Decode(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Regex rg = new Regex(@"\d*\w");
            MatchCollection collection = rg.Matches(input);
            foreach (Match match in collection)
            {
                string val=match.Value;
                Regex regexNumber =new Regex(@"^\d*");
                Match match1 = regexNumber.Match(val);
                int times=0;
                bool valid = int.TryParse(match1?.Value, out times);
                int number=valid? times:1;
                Regex regexString = new Regex(@"\D*$");
                Match match2 = regexString.Match(val);
                char text= match2.Value[0];
                stringBuilder.Append(new string(text, number));
  
            }
            return stringBuilder.ToString();
        }
        //public static string Decode(string input)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    Regex rg = new Regex(@"(\d*)(\D)");
        //    MatchCollection collection = rg.Matches(input);

        //    foreach (Match match in collection)
        //    {
        //        int number = 1;
        //        if (match.Groups[1].Success)
        //        {
        //            int.TryParse(match.Groups[1].Value, out number);
        //        }

        //        char text = match.Groups[2].Value[0];
        //        stringBuilder.Append(new string(text, number));
        //    }

        //    return stringBuilder.ToString();
        //}
    }

}
