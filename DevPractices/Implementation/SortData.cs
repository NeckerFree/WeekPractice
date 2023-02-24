using DevPractices.Interfaces;
using System;
using System.Globalization;

namespace DevPractices.Implementation
{
    internal class SortData : ISortData
    {
        public void QSSort(ref int[] array)
        {
            int low = 0;
            int high = array.Length - 1;
            QuickSort(array, low, high);
        }

        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partition = Partition(array, low, high);
                QuickSort(array, low, partition - 1);
                QuickSort(array, partition + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            (array[i+1], array[high]) = (array[high], array[i+1]);
            return i + 1;
        }
    }
}
