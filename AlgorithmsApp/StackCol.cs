using System.Collections;
using System.Linq;
using System.Text;

namespace AlgorithmsApp
{
    public class StackCol
    {
        private int _capacity;
        int[] _collection;
        private int top;

        public StackCol(int capacity)
        {
            _capacity=capacity;
            _collection= new int[capacity];
            top = -1;
        }

        
        public int Peek()
        {
            return _collection[Count - 1];
        }

        public int? Pop()
        {
            if (top==-1) { return null; }
            return _collection[top--];
        }

        public void Push(int element)
        {
            if (top == _capacity + 1) { return; }
            _collection[++top]= element;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i <= top;i++)
            {
                sb.AppendFormat("{0} ",_collection[i]);
            }
            return sb.ToString();
            
        }

        public int Count { get { return _collection.Length; } }
    }
}
