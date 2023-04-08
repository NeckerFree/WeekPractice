using AlgorithmsApp.CoderPad.Implementation;
using DevPractices.CoderPad.Implementation;

namespace DevPractices.Implementation
{
    internal class LargeParkingLot : ParkingLot
    {
        public LargeParkingLot(int quantity) : base(quantity)
        {
        }

        public override Ticket AddSpot(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
        //public override void Initialize(int quantity)
        //{
        //    base.Initialize(quantity);
        //}
    }
}
