using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmsApp.MathTest
{
    public class MedianFinder
    {
        List<int> data;
        public MedianFinder()
        {
            data = new List<int>();
        }

        public void AddNum(int num)
        {
            data.Add(num);
        }

        public double FindMedian()
        {
            double media = 0.0;
            foreach (int val in data)
            {
                media += val;
            }
            
            double result= media/data.Count;
            int convert = (int)(result);
            if (Math.Abs(result % convert)==0.5)
            {
                return result;
            }
            else
            {
                return Math.Round(result,0, MidpointRounding.AwayFromZero);
            }
        }
    }

}
//public double FindMedian()
//{
//    double sum = data.Sum();
//    double result = sum / data.Count;
//    return Math.Round(result, MidpointRounding.AwayFromZero);
//}