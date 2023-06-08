using System.Collections.Generic;

namespace AlgorithmsApp.Classes
{
    public class StringOperations
    {
        public bool IsPalindrome(string inputString)
        {
            string reversedString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString = string.Concat(reversedString, inputString[i]);
                Console.WriteLine($"reversed: {reversedString}");
            }
            return (inputString == reversedString);
        }
    }
}


