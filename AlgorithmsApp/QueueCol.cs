using System.Text;

namespace AlgorithmsApp
{
    public class QueueCol
    {
        private string[] _collection;
        private int _capacity;
        private int tail;
        private int head;


        public QueueCol(int capacity)
        {
            _collection = new string[capacity];
            this._capacity = capacity;
            head = 0;
            tail = -1;
        }

        public string? Dequeue()
        {
            if (head == tail + 1)
            {
                return null;
            }
            return _collection[head++];

        }

        public void Enqueue(string element)
        {
            if (tail== _capacity - 1)
            {
                return;
            }
            _collection[++tail] = element;
        }

        public string Print()
        {
            StringBuilder   sb = new StringBuilder();
            for (int i = head; i <= tail; i++)
            {
                sb.AppendFormat("{0} ", _collection[i]);
            }
            return sb.ToString();   
        }
    }
}
