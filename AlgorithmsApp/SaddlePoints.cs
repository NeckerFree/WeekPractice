using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmsApp
{

    public static class SaddlePoints
    {
        public static IEnumerable<(int, int)> Calculate(int[,] matrix)
        {
            //    var matrix = new[,]
            //    {
            //     { 9, 8, 7 },
            //     { 5, 3, 2 },
            //     { 6, 6, 7 }
            //};

            //    var matrix = new[,]
            //    {
            //     { 4, 5, 4 },
            //     { 3, 5, 5 },
            //     { 1, 5, 4 }
            //};
            List<(int, int)> maxSaddlePoints = new List<(int, int)>();
            List<(int, int)> minSaddlePoints = new List<(int, int)>();

            int rowsOrHeight = matrix.GetLength(0);
            int colsOrWidth = matrix.GetLength(1);

            for (int i = 0; i < rowsOrHeight; i++)
            {
                int maxRowValue = Enumerable.Range(0, colsOrWidth)
                .Select(x => matrix[i, x])
                .ToArray().Max();

                for (int j = 0; j < colsOrWidth; j++)
                {
                    int cellValue = (matrix[i, j]);
                    if (cellValue == maxRowValue)
                    {
                        maxSaddlePoints.Add((i+1, j+1));
                    }

                }
            }
            for (int j = 0; j < colsOrWidth; j++)
            {
                int minColValue = Enumerable.Range(0, rowsOrHeight)
                 .Select(x => matrix[x, j])
                 .ToArray().Min();

                for (int i = 0; i < rowsOrHeight; i++)
                {
                    int cellValue = (matrix[i, j]);

                    if (cellValue == minColValue)
                    {
                        minSaddlePoints.Add((i+1, j + 1));
                    }
                }
            }

            var intersection = minSaddlePoints.Intersect(maxSaddlePoints);
            return intersection;

        }
    }

}
