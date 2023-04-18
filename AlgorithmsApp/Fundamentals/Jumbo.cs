namespace AlgorithmsApp.Fundamentals
{
    internal class Jumbo : Airplane
    {
        public Jumbo(int maxSpeed) : base(maxSpeed)
        {
        }

        public override int CalculateSpeed(int meters, int seconds)
        {
            return base.CalculateSpeed(meters, seconds);
        }
        protected override void Fly()
        {
            base.Fly();
            base.Land();
            
        }
        
    }
}
