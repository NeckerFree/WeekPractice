namespace AlgorithmsApp.Classes
{
    public static class Recursion
    {
        public static int Calculate(Int64 value1, Int64 value2 , bool sumar)
        {
            int sum = 0;
            if (value1 == 0 || value2 == 0)
            {
                return 1;
            }
            else
            {
                if (sumar)
                {
                    Console.WriteLine($"Sum of values: {value1}+{value2} equals: {value1 + value2}");
                    sum++;
                    return sum + Calculate(value1, value2, !sumar);
                }
                else
                {
                    Console.WriteLine($"Dif of values: {value1}-{value2} equals: {value1 - value2}");
                    sum++;
                    return sum + Calculate(value1 - 1, value2 - 1, !sumar);
                }
                

            }
        }
    }
}
