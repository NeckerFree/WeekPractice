namespace AlgorithmsApp.Inheritance
{
    internal class Airplane: Transport
    {
        public override void Move()
        {
            Console.WriteLine("Airplane - Move");
        }
        public new void Carry()
        {
            Console.WriteLine("Airplane - Carry");
        }
    }
}
