
using System.Collections.Generic;

namespace AlgorithmsApp.LinkedList
{
    internal class LinkedListEx
    {
        public LinkedListEx()
        {
            string[] words = new string[] { "First", "Second", "Third", "Fourth" };
            LinkedList<string> ll = new LinkedList<string>(words);
            ll.AddLast("Fifth");
            ll.RemoveFirst();
            ll.Remove("Third");
            LinkedListNode<string> recent = ll.AddLast("Seventh");
            ll.AddBefore(recent, "Sixth");

            foreach (string word in ll)
            {
                Console.WriteLine(word);
            }
        }
    }
}
