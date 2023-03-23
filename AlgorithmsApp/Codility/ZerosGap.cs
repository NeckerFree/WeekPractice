namespace AlgorithmsApp.Codility
{
    public class ZerosGap
    {
        public int MaxGap(int N)
        {
            int binGap = 0;
            string binary = Convert.ToString(N, 2);
            for (int i = 1; i <= binary.Length - 2; i++)
            {
                int coincidence = binary.IndexOf($"1{new string('0', i)}1");
                if (coincidence >= 0 && i > binGap)
                {
                    binGap = i;
                }
            }
            return binGap;
        }
    }
}
