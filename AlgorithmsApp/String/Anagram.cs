namespace AlgorithmsApp.String
{
    public class Anagram
    {
        int[] dicWord = new int[128];
        private string origin;

        public Anagram(string baseWord)
        {
            origin = baseWord.ToLower();
            char[] values = origin.ToCharArray();
            
            foreach (var item in values)
            {
                dicWord[item] = dicWord[item] + 1;
            }
        }

        public string[] FindAnagrams(string[] potentialMatches)
        {
            
            List<string> result = new List<string>();
            foreach (string word in potentialMatches)
            {
              string  wordLower=word.ToLower();
                char[] charArray = word.ToLower().ToCharArray();
                int[] dic = new int[128];
                foreach (char car in charArray)
                {
                    dic[car] = dic[car] + 1;
                }
                bool same=true;
                for(int i=0; i<dic.Length; i++)
                {
                    if (dic[i] != dicWord[i])
                    {
                        same = false;
                        break;
                    }
                }
                if (same==true && origin!=wordLower) { result.Add(word); }
            }
            return result.ToArray();

            //return potentialMatches
            //.Where(pm => pm.Length == baseWord.Length)
            //.Where(pm => pm.ToLowerInvariant() != baseWord.ToLowerInvariant())
            //.Where(pm => pm.ToLowerInvariant().Order().SequenceEqual(baseWord.ToLowerInvariant().Order()))
            //.ToArray();
        }
    }
}
