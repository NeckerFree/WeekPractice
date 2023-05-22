using Newtonsoft.Json;

namespace AlgorithmsApp
{
    public static class RomanNumeralExtension
    {
        public static string ToRoman(this int value)
        {
            string[] arrayThousands = { "", "M", "MM", "MMM" };
            string[] arrayHundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] arrayTens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] arrayUnits = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string thousands = arrayThousands[(int)Math.Floor((double)value / 1000)];
            string hundreds = arrayHundreds[(int)Math.Floor(((double)value % 1000) / 100)];
            string tens = arrayTens[(int)Math.Floor(((double)value % 100) / 10)];
            string units = arrayUnits[value % 10];
            return thousands + hundreds + tens + units;
        }

        public static string IntToRoman(this int num)
        {
            string result = "";
            if (num == 0) return result;
            string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int[] ints = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                int q = num / ints[i];
                if (q > 0)
                {
                    result += string.Concat(Enumerable.Repeat(romans[i], q));
                    num = num % ints[i];
                }
                if (num == 0) break;
            }
            return result;
        }
        //public static int RomanToInt(string s)
        //{

        //    int value = 0;
        //    if (s.Length == 0) return value;
        //    string[] romans = { "I", "V", "X", "L", "C", "D", "M" };
        //    int[] ints = { 1, 5, 10, 50, 100, 500, 1000 };
        //    // loop string from left to rigth
        //    int previous = 0;
        //    foreach (char c in s)
        //    {

        //        // map int value of current char
        //        int current = ints[Array.IndexOf(romans, c.ToString())];
        //        // validate if previous > 0 and previous < current
        //        if (previous > 0 && previous < current)
        //        {
        //            value += (current - previous);
        //            previous = 0;                }
        //        else
        //        {
        //            if (previous > 0)
        //            {
        //                value += (previous);
        //             }
        //             previous = current;

        //        }

        //    }
        //    if (previous > 0)
        //    {
        //        value += (previous);
        //    }
        //    return value;
        //}
        public static int RomanToInt(string s)
        {
           int value = 0;
            if (s.Length == 0) return value;
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            keyValuePairs['I'] = 1;
            keyValuePairs['V'] = 5;
            keyValuePairs['X'] = 10;
            keyValuePairs['L'] = 50;
            keyValuePairs['C'] = 100;
            keyValuePairs['D'] = 500;
            keyValuePairs['M'] = 1000;
            // loop string from left to rigth
            int previous = 0;
            foreach (char c in s)
            {
                // validate if previous > 0 and previous < current
                if (previous > 0)
                {
                    if (previous < keyValuePairs[c])
                    {
                        value += (keyValuePairs[c]- previous);
                        previous = 0;
                    }
                    else
                    {
                        value += (previous);
                        previous = keyValuePairs[c];
                    }
                }
                else previous = keyValuePairs[c];
            }
            if (previous > 0)
            {
                value += (previous);
            }
            return value;
        }


    }
}
