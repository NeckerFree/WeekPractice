using System.Data;
using System.Runtime.InteropServices;

namespace AlgorithmsApp
{
    public class MatrixEx
    {


        public static int[,] GetMatrix(int size)
        {
            int count = 0;
            int x = 0;
            int y = 0;
            int round = 0; 
            int[,] matrix = new int[size, size];
            while (count < size * size)
            {
                int newSize = size - round;
                //Fill right
                for (int i = round; i < newSize; i++)
                {
                    y = i;
                    matrix[x, y] = ++count;
                }
                //Fill down
                for (int j = round + 1; j < newSize; j++)
                {
                    x = j;
                    matrix[x, y] = ++count;
                }
                //Fill back
                for (int k = newSize - 2; k >= round; k--)
                {
                    y = k;
                    matrix[x, y] = ++count;
                }
                //Fill up
                for (int l = newSize - 2; l > round; l--)
                {
                    x = l;
                    matrix[x, y] = ++count;
                }
                round++;
            }
            return matrix;
        }
    }
}
