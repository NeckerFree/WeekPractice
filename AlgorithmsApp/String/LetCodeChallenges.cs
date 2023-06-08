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
                    if (ok==false) 
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
    }
}
