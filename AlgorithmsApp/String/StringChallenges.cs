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
    }
}
