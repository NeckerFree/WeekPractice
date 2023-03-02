namespace AlgorithmsApp.Inheritance
{
    internal class Transport
    {
        public virtual void Move()
        {
            Console.WriteLine("Transport - Move");
        }
        public void Carry()
        {
            Console.WriteLine("Transport - Carry");
        }
    }
}
