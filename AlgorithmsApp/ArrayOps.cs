namespace AlgorithmsApp
{
    public class ArrayOps
    {
        //public static int ValidateMostRepeatedElement(int[] arrayToValidate)
        //{
        //    int repeatedElement = -1;
        //    Dictionary<int,int> map = new Dictionary<int,int>();
        //    if (arrayToValidate.Length == 0)
        //        {
        //        return repeatedElement;
        //    }
        //    for (int i = 0; i < arrayToValidate.Length; i++)
        //    {
        //        int key= arrayToValidate[i];
        //        map[key] = (map.Keys.Contains(key)) ?map[key] + 1: 1;
        //    }
        //    var repeated = map.OrderByDescending(x => x.Value).FirstOrDefault();
        //    repeatedElement = repeated.Key;
        //    return repeatedElement;
        //}

        public static int ValidateMostRepeatedElement(int[] arrayToValidate)
        {
            int repeatedElement = -1;
            int maxFrequency = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            if (arrayToValidate.Length == 0)
            {
                return repeatedElement;
            }
            for (int i = 0; i < arrayToValidate.Length; i++)
            {
                int key = arrayToValidate[i];
                map[key] = (map.Keys.Contains(key)) ? map[key] + 1 : 1;
                if (map[key] >= maxFrequency)
                {
                    repeatedElement = key;
                    maxFrequency = map[key];
                }
            }
          return repeatedElement;
        }
    }
}