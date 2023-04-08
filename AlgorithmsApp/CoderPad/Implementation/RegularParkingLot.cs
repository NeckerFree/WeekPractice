using AlgorithmsApp.CoderPad.Implementation;
using DevPractices.CoderPad;
using DevPractices.CoderPad.Implementation;

namespace DevPractices.Implementation
{
    internal class RegularParkingLot : ParkingLot
    {
        public RegularParkingLot(int quantity) : base(quantity)
        {
        }

        public override Ticket AddSpot(Vehicle vehicle)
        {
            return base.AddSpot(vehicle);
        }

        internal bool HasThreeConsecutiveSpots()
        {
            bool response = false;
            var collection = base.spotsCollection;
            for (int i = 0; i < collection.Count - 2; i++)
            {
                response = (collection[i] == null && collection[i + 1] == null && collection[i + 2] == null);
                if (response == true) return response;
            }
            return response;
        }
        internal Ticket AddVanSpot(Vehicle vehicle)
        {
            Ticket generalTicket = null;
            Ticket ticket1 = base.AddSpot(vehicle);
            Ticket ticket2 = base.AddSpot(vehicle);
            Ticket ticket3 = base.AddSpot(vehicle);
            generalTicket = ticket1;
            generalTicket.SpotNumbers[0] = ticket1.SpotNumbers[0];
            generalTicket.SpotNumbers[1] = ticket2.SpotNumbers[0];
            generalTicket.SpotNumbers[2] = ticket3.SpotNumbers[0];
            return generalTicket;
        }
    }
}
