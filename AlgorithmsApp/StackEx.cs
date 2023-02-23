using System.Collections;

namespace AlgorithmsApp
{
    internal class StackEx
    {
        public StackEx()
        {
            Stack stack = new Stack();


            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            var element = stack.Pop();
            Console.WriteLine(element);
            stack.Push("fourth");
            Console.WriteLine($"Size: {stack.Count}");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
