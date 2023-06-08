using Newtonsoft.Json.Linq;

namespace AlgorithmsApp.HackerRank
{
    public class StringEx
    {
        public static string[] FindCommonCharacters(string[] words)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (characters.ContainsKey(c))
                    {
                        characters[c] = characters[c] + 1;
                    }
                    else
                    {
                        characters[c] = 1;
                    }
                }
            }
            IEnumerable<KeyValuePair<char, int>> filter = characters.Where(pair => pair.Value >= words.Length);
            foreach (var item in filter)
            {
                int times = (item.Value / words.Length);
                result.AddRange(Enumerable.Repeat(item.Key.ToString(), times));
            }
            return result.ToArray();
        }


        public static string IsValid(string s)
        {
            int repetitions = 0;

            bool valid = true;

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (char element in s)
            {
                if (dictionary.ContainsKey(element))
                {
                    dictionary[element] = dictionary[element] + 1;
                }
                else
                {
                    dictionary.Add(element, 1);
                }

                if (dictionary[element] > repetitions)
                {
                    repetitions = dictionary[element];
                }
            }

            int total = dictionary.Count();

            int maxFrequency = dictionary.Count(x => x.Value == repetitions);

            if (maxFrequency != total)
            {
                valid = (total - maxFrequency == 1);
                if (valid == false)
                {
                    maxFrequency = dictionary.Count(x => x.Value == repetitions - 1);
                    valid = (total - 1 == maxFrequency);
                }
            }

            string result = (valid) ? "YES" : "NO";
            return result;
        }
    }
}
