using System.Collections;

namespace AlgorithmsApp
{
    internal class HashtableEx
    {
        public HashtableEx()
        {
            Hashtable hashtable= new Hashtable();
            hashtable.Add(3, "Three");
            hashtable.Add(0, "Zero");
            hashtable.Add(1, "One");
            hashtable.Add(2, "Two");
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
        }
    }
}
