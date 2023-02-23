using System.Collections;

namespace AlgorithmsApp
{
    internal class QueueEx
    {
        public QueueEx()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);   
            queue.Enqueue(4);
            Console.WriteLine($"Peek: {queue.Dequeue()}");
            queue.Enqueue(5);   
            queue.Enqueue(6);   
            queue.Enqueue(7);
            Console.WriteLine($"Peek: {queue.Dequeue()}");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


        }
    }
}
