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
    }
}
