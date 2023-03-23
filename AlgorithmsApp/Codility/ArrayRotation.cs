namespace AlgorithmsApp.Codility
{
    public class ArrayRotation
    {
        public int GetUnparedElements(int[] A)
        {
            int result = 0;
            foreach (var element in A)
            {
                result = result ^ element;
            }
            return result;
        }

        public int[] Rotate(int[] A, int K)
        {
            int arrayLength = A.Length;
            if (K == arrayLength || arrayLength <= 1)
            {
                return A;
            }
            int[] B = new int[arrayLength];
            int step = K % arrayLength;
            if (step < arrayLength)
            {
                int rightElements = arrayLength - step;
                Array.Copy(A, rightElements, B, 0, step);
                Array.Copy(A, 0, B, rightElements + 1, step - 1);
            }
            return B;
        }
    }
}
