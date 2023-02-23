using System.Collections;

namespace AlgorithmsApp
{
    internal class SortedListEx
    {
        //Uses binary tree
        public SortedListEx() 
            {
            SortedList sortedList = new SortedList();
            sortedList.Add(10,"Ten");
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(8, "Eigth");
            sortedList.Add(2, "Two");
            sortedList.Add(9, "Nine");
            sortedList.Add(4, "Four");
            sortedList.Add(6, "Six");
            sortedList.Add(5, "Five");
            sortedList.Add(7, "Seven");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }



            }
    }
}
