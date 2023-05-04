namespace AlgorithmsApp.HackerRank
{
    public class StringEx
    {
        public static string IsValid(string s)
        {
            int repetitions = 0;
            
            bool valid = true;

            Dictionary<int,int> dictionary = new  Dictionary<int, int>() ;
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
