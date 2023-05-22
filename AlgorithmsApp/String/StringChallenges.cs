using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AlgorithmsApp.String
{
    public class StringChallenges
    {
        public string ReverseEachString(string _title)
        {
            string reversedSentence = string.Empty;
            //foreach (char c in _title)
            //{
            //    reversedSentence = c+reversedSentence;
            //}

            //char[] chars = _title.ToCharArray();
            //string[] words = _title.Split(' ');
            //foreach (string word in words)
            //{
            //    reversedSentence = $"{ReverseWord(word)} {reversedSentence}";
            //}
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = _title.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(_title[i]);
            }
            reversedSentence = stringBuilder.ToString();
            return reversedSentence;
        }

        private string ReverseWord(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string result = new string(chars);
            return result;
        }

        public string GetUniques(string word)
        {
            string answer = new string(word.Distinct().ToArray());
            return answer;
        }

        public bool HasUniques(string input)
        {
            int[] ints = new int[128];
            foreach (char i in input)
            {
                ints[i] = ints[i] + 1;
            }
            bool response = ints.All(val => val == 1);
            //var uniques= new HashSet<string>();
            //var uniques=Array.FindAll(ints, val=> val == 1);
            string uniques = string.Empty;
            string repeated = string.Empty;
            string notIncluded = string.Empty;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 1)
                {
                    uniques += (char)i;
                }
                else
                {
                    if (ints[i] > 1)
                    {
                        repeated += (char)i;
                    }
                    else
                    {
                        notIncluded += Convert.ToChar(i);
                    }
                }

            }
            return response;
        }
        public int LengthOfLongestSubstring(string s)
        {
            string result = string.Empty;
            if (s.Length == 0) return 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int max = 0;
            for (int i = 0, j = 0; i < s.Length; ++i)
            {
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                    map.Remove(s[i]);
                }
                map.Add(s[i], i);
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            string prefix = string.Empty;
            if (strs.Length==0 ) return prefix;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int indexLetter = -1;
            string response = string.Empty;
            while (true)
            {
                char car = '*';
                indexLetter++;
                for (int indexWord = 0; indexWord < strs.Length; indexWord++)
                {
                    if (strs[indexWord]=="")
                    {
                        return prefix;
                    }
                    if (strs[indexWord].Length ==indexLetter)
                    {
                        return response;
                    }
                    car = strs[indexWord][indexLetter];
                    if (map.ContainsKey(car))
                    {
                        map[car] = map[car] + 1;
                    }
                    else
                    {
                        map.Add(car, 1);
                    }

                }

                if (map[car] == strs.Length)
                {
                    response += car;
                    map[car] = 0;
                }
                else
                {
                    prefix = response;
                    break;
                }
            }
            return prefix;
        }
    }
}
