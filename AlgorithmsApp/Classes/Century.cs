namespace AlgorithmsApp.Classes
{
    public class Century
    {
        public int Calculate(int year)
        {
            if (year == 0) return 0;
            int res = year;

            int century = year / 100;
            if (century > 0)
            {
                res = year % 100;
            }
            Console.WriteLine($"century:{century} res:{res}");
            return (res >= 1 && res < 100) ? century + 1 : century;
        }
    }
}
