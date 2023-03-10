namespace AlgorithmsApp
{
    public static class RomanNumeralExtension
    {
        public static string ToRoman(this int value)
        {
            string[] m = { "", "M", "MM", "MMM" };
            string[] c = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] x = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] u = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string thousands = m[(int)Math.Floor((double)value / 1000)];
            string hundreds = c[(int)Math.Floor(((double)value % 1000) / 100)];
            string tens = x[(int)Math.Floor(((double)value % 100) / 10)];
            string units = u[value % 10];
            return thousands + hundreds + tens + units;
        }
    }
}
