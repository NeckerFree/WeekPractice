using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp
{
    public class BinSearchEx
    {
        public int BinarySearchAlg(int[] arr, int start, int end, int key)
        {
            int position = -1;
            if (start == end) { return position; }
            int middle = start + (end - start) / 2;
            if (arr[middle] > key)
            {
                position = BinarySearchAlg(arr, start, middle, key);
                return position;
            }
            if (arr[middle] < key)
            {
                position = BinarySearchAlg(arr, middle + 1, end, key);
                return position;
            }
            position = middle;
            return position;
        }
    }
}
