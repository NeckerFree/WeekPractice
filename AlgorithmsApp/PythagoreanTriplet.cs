using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            var start = DateTime.Now;
            int a;
            int b;
            int c;
            int a_plus_b;
            List<(int, int, int)> triplets = new List<(int, int, int)>();

            for (int i = sum - 3; i > 1; i--)
            {
                c = i;
                a_plus_b = sum - c;
                for (int j = a_plus_b; j > 1; j--)
                {
                    b = j;
                    a = a_plus_b - b;
                    if (a == 0 || a >= b) continue;
                    if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c)
                    {
                        if ((a + b + c) == sum)
                        {
                            triplets.Add((a, b, c));
                            //var spendTime = DateTime.Now - start;
                            //Console.WriteLine($"found ({a},{b},{c}) in {spendTime}");
                        }
                    }
                }
            }
            var spendTime = DateTime.Now - start;
            Console.WriteLine($"time: {spendTime}");
            return triplets;
        }
        //public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum) =>
        //from a in Enumerable.Range(1, sum / 3)
        //from b in Enumerable.Range(a + 1, sum / 2)
        //where a * a + b * b == (sum - a - b) * (sum - a - b)
        //select (a, b, sum - a - b);

        //private static bool IsPythagoreanTriplet(int a, int b, int c) => a * a + b * b == c * c;
        //public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        //{
        //    // Constraints:
        //    //      1) a < b < c
        //    //      2) a + b + c = sum        (N == sum)
        //    //      3) a^2 + b^2 = c^2
        //    //      4) a > 0
        //    //
        //    //  We derive from above that:
        //    //      a < sum / 3
        //    //      b < c
        //    //      c = sum - a - b
        //    for (int a = 1; a < sum / 3; a++)
        //    {
        //        for (int b = a + 1, c = sum - a - b;
        //             b < c;
        //             b++, c--)
        //        {
        //            if (IsPythagoreanTriplet(a, b, c))
        //                yield return (a, b, c);
        //        }
        //    }
        //}

        //public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        //{
        //    int rangeA = sum / 3;
        //    int rangeB = sum / 2;
        //    var enumA = Enumerable.Range(1, rangeA);

        //    var response= from a in  enumA
        //    from b in Enumerable.Range(a + 1, rangeB)
        //                  where a * a + b * b == (sum - a - b) * (sum - a - b)
        //    select (a, b, sum - a - b);
        //    return response;
        //}
    }
}
