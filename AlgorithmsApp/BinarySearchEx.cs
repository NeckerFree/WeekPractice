namespace AlgorithmsApp
{
    internal class BinarySearchEx
    {
        public BinarySearchEx() 
            {
                
            int[] data = new int[12] { 1, 3, 5, 7, 11,1,76, 13, 17, 19, 23, 31 };
            Array.Sort(data);
            Console.WriteLine(string.Join(" ", data));
            // Value to search for    
            int target = 14;
            int pos = Array.BinarySearch(data, target);
            Console.WriteLine(pos);
        }
    }
}
