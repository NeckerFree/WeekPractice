namespace AlgorithmsApp
{
    public class GCD
    {
        private int t;

        public int Calculate(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a==0) return b;
            if (b==0) return a;
            while (a % b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return b;
        }
    }
}
