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
            List<(int, int, int)> triplets = new List<(int, int, int)>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0)
                    {
                        triplets.Add((nums[i], nums[left], nums[right]));

                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return ConvertToList(triplets);
        }

        private static IList<IList<int>> ConvertToList(List<(int, int, int)> triplets)
        {
            return triplets.Select(el => new List<int> { el.Item1, el.Item2, el.Item3 }).ToList<IList<int>>();
        }
    }
}
