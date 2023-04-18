namespace AlgorithmsApp.Fundamentals
{
    public class Airplane : AirVehicle
    {
        public Airplane(int maxSpeed) : base(maxSpeed)
        {
        }

        public override int CalculateSpeed(int meters, int seconds)
        {
            return meters * seconds;
        }
        
        protected override void Fly()
        {
            throw new NotImplementedException();
        }
        protected sealed override void Land()
        {
            base.Land();
        }
    }
}
