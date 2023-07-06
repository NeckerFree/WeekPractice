using System.Collections.Generic;
using System.ComponentModel.Design;

namespace AlgorithmsApp.String
{
    public class LetCodeChallenges
    {
        public static bool ValidParentheses(string s)
        {
            Stack<char> chars = new Stack<char>();

            foreach (char ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    chars.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    bool ok = chars.TryPop(out char output);
                    if (ok == false)
                    {
                        return false;
                    }
                    if (output == '(' && ch == ')')
                    {
                        continue;
                    }
                    else
                    {
                        if (output == '{' && ch == '}')
                        {
                            continue;
                        }
                        else
                        {
                            if (output == '[' && ch == ']')
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return chars.Count == 0;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    if (dict[num] < 3)
                    {
                        dict[num]++;
                    }

                }
                else
                {
                    dict[num] = 1;
                }
            }
            List<int> listInts = new List<int>();
            foreach (var item in dict)
            {
                listInts.AddRange(Enumerable.Repeat(item.Key, item.Value).ToArray());
            }
            List<(int, int, int)> triplets = new List<(int, int, int)>();
            int[] filtered = listInts.ToArray();
            
            if (filtered.Length < 3) return new List<IList<int>>();
            else
            {
                for (int i = 0; i < filtered.Length - 2; i++)
                {
                    for (int j = i + 1; j < filtered.Length - 1; j++)
                    {
                       for (int k = j + 1; k < filtered.Length; k++)
                        {
                            if (filtered[k] > 0 - (filtered[i] + filtered[j]))
                            {
                                break;
                            }
                            if (filtered[k] + filtered[i] + filtered[j] == 0)
                            {
                                (int, int, int) sequence = (filtered[i], filtered[j], filtered[k]);
                                if (triplets.Contains(sequence) == false)
                                {
                                    triplets.Add(sequence);
                                }

                            }
                        }

                    }
                }
            }

            return ConvertToList(triplets); ;
        }

        private static IList<IList<int>> ConvertToList(List<(int, int, int)> triplets)
        {
            return triplets.Select(el => new List<int> { el.Item1, el.Item2, el.Item3 }).ToList<IList<int>>();
        }
    }
}
