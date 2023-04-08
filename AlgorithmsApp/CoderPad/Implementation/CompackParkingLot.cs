using AlgorithmsApp.CoderPad.Implementation;
using DevPractices.CoderPad.Implementation;

namespace DevPractices.Implementation
{
    internal class CompackParkingLot : ParkingLot
    {
        public CompackParkingLot(int quantity) : base(quantity)
        {
        }

        public override Ticket AddSpot(Vehicle vehicle)
        {
            return base.AddSpot(vehicle);
        }

        public override Ticket? ReleaseSpot(int slotId)
        {
            return base.ReleaseSpot(slotId);
        }

    }
}
