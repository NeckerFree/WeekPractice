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
            return base.AddSpot(vehicle);
        }
        
    }
}
