using Newtonsoft.Json.Linq;

namespace AlgorithmsApp.BigNumbers
{
    public class BigNumbersOperations
    {
        public static string Sum(string value1, string value2)
        {
            int length = Math.Max(value1.Length, value2.Length);
            int remainder = 0;
            string result = "";

            for (int i = 0; i < length; i++)
            {
                int sum = remainder;
                int index1 = value1.Length - i - 1;
                if (index1 >= 0)
                {
                    sum += value1[index1] - '0';
                }
                int index2 = value2.Length - i - 1;
                if (index2 >= 0)
                {
                    sum += value2[index2] - '0';
                }
                remainder = sum / 10;
                int valueToStore = sum % 10;
                result = valueToStore.ToString() + result;
            }

            if (remainder > 0)
            {
                result = remainder.ToString() + result;
            }

            return result;
        }

       
            public static string Multiply(string value1, string value2)
            {
            int lengthFirst = value1.Length;
            int lengthSecond= value2.Length;
            
            string result = "0";

            for (int i = 0; i < lengthSecond; i++)
            {

                string partialResult = "";
                int carry = 0;
                int multiplicand = 1;
                int positionMultiplicand = lengthSecond - i - 1;
                if (positionMultiplicand >= 0)
                {
                    multiplicand = value2[positionMultiplicand] - '0';
                }

                for (int j = 0; j < lengthFirst; j++)
                {
                    int multiplier=1;
                    int partialProduct;
                    int positionMultiplier = lengthFirst - j - 1;
                    if (positionMultiplier >= 0)
                    {
                         multiplier = value1[positionMultiplier] - '0';
                    }
                    
                    partialProduct = (multiplier * multiplicand) +carry;
                    carry = partialProduct / 10;
                    int valueToStore = partialProduct % 10;
                    partialResult = valueToStore.ToString() + partialResult;
                }
                if (carry > 0)
                {
                    partialResult = carry.ToString() + partialResult;
                    carry= 0;
                }
                result = Sum(result, partialResult + new string('0', i));
           }
            return  result.TrimStart('0').PadLeft(1, '0');
        }
        
    }
}
