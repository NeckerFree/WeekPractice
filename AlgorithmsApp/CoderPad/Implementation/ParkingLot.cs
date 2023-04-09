using AlgorithmsApp.CoderPad.Implementation;
using DevPractices.CoderPad;
using DevPractices.CoderPad.Implementation;

namespace DevPractices.Implementation
{
    internal abstract class ParkingLot
    {
        internal Dictionary<int, Spot> spotsCollection;
        private int _spotsCount;
        private int _quantity;
        public ParkingLot(int quantity)
        {
            _quantity = quantity;
            spotsCollection = new Dictionary<int, Spot>(quantity);
        }
        public virtual Ticket AddSpot(Vehicle vehicle)
        {
            Ticket ticket = new Ticket();
            if (spotsCollection is not null && vehicle != null)
            {
                Spot spot = new Spot() { Number = _spotsCount, Vehicle = vehicle };
                spotsCollection[_spotsCount++] = spot;
                ticket.Generate(spot);
            }
            return ticket;
        }

        public virtual Ticket? ReleaseSpot(int spotId)
        {
            Ticket ticket = new Ticket();
            Spot spot = spotsCollection[spotId];

            if (spot != null)
            {
                spotsCollection.Remove(spotId);
                _spotsCount--;
                ticket.Generate(spot);
            }
            return ticket;
        }
        public bool IsEmpty()
        {
            return (_spotsCount == 0);
        }

        public bool IsFull()
        {
            bool response = (spotsCollection is null) ? false : (_quantity == spotsCollection.Count);
            return response;
        }

        public int RemainingSpots()
        {
            int result = (spotsCollection is null) ? -1 : (_quantity - spotsCollection.Count);
            return result;

        }

        public int TotalSpots()
        {
            int result = (spotsCollection is null) ? -1 : spotsCollection.Count;
            return result;
        }


    }
}
