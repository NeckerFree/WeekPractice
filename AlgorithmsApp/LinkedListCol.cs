using System.Collections;

namespace AlgorithmsApp
{
    public class LinkedListCol<T> : ILinkedListCol<T>, IEnumerable
    {
        /// <summary>
        /// Head of the list.
        /// </summary>
        private NodeCol<T>? Head;
        /// <summary>
        /// Tail of the list.
        /// </summary>
        private NodeCol<T>? Tail;
        /// <summary>
        /// Implementatoin of the interace property.
        /// </summary>
        /// <value>Number of elements in the list</value>
        public int Count { get; private set; }

        public LinkedListCol()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Add(T element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            NodeCol<T>? nodeColToAdd = null;
            if (Count == 0)
            {
                nodeColToAdd = new NodeCol<T>(element);
                Head = nodeColToAdd;
                Tail = Head;
                Count++;
                return true;
            }
            nodeColToAdd = new NodeCol<T>(element, Tail);
            Tail = nodeColToAdd;
            Count++;
            return true;

        }
        public bool Remove(T element)
        {
            NodeCol<T>? currentNode = Head;
            NodeCol<T>? nodeBeforeFound = null;
            if (element == null) return false;
            if (Count == 0) return false;
            
            while (!Equals(currentNode.Value, element))
            {
                nodeBeforeFound = currentNode;
                if (currentNode == null) return false;
                currentNode = currentNode.NextNode;
            }
            
            if (currentNode == Head)
            {
                Head = currentNode.NextNode;
                Count--;
                return true;
            }
            nodeBeforeFound.NextNode = currentNode.NextNode;
            Count--;
            return true;

        }

        public bool Contains(T element)
        {
            NodeCol<T>? currentNode = Head;
            if (Count == 0)
            {
                return false;
            }
            if (element == null)
            {
                throw new ArgumentNullException();
            }
            NodeCol<T>? current = Head;
            while (!Equals(currentNode, Tail))
            {
                if (currentNode != null)
                {

                    currentNode = currentNode.NextNode;
                }
            }
            if (Equals(current, null))
            {
                return false;
            }
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            var node = Head;
            while (node != null)
            {
                yield return node.Value;
                node = node.NextNode;
            }
        }


    }
}
