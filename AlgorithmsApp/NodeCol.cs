namespace AlgorithmsApp
{
    //internal class NodeCol<T>
    //{
    //    public T Data;
    //    public NodeCol<T>? next;
    //    public NodeCol(T data)
    //    {
    //        Data = data;
    //        this.next = null;
    //    }
    //}

    public class NodeCol<T>
    {
        public T? Value { get; private set; }
        public NodeCol<T>? NextNode { get; set; }
        public NodeCol(T element)
        {
            Value = element;
            NextNode = null;
        }
        public NodeCol(T element, NodeCol<T> previousNode) : this(element)
        {
            previousNode.NextNode = this;
            NextNode = null;
        }
    }
}