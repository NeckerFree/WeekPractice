using DevPractices.CoderPad;
using DevPractices.CoderPad.Implementation;
using DevPractices.CoderPad.Interfaces;

namespace DevPractices.Implementation
{
    public class ParkingLot : IParkingLot
    {
        private CompactSpot[] compactSpots;
        private RegularSpot[] regularSpots;
        private LargeSpot[] largeSpots;
        private int _vansCount;
        private int _carsCount;
        private int _motosCount;

        public ParkingLot(int motos, int cars, int vans)
        {
            this.compactSpots = new CompactSpot[motos];
            this.regularSpots = new RegularSpot[cars];
            this.largeSpots = new LargeSpot[vans];
        }

        public void AddSpot(Vehicle vehicle)
        {
            var vehicleType=vehicle.GetType();
            if (vehicleType == typeof(Moto))
            {
                CompactSpot compactSpot = new CompactSpot()
                {
                    Number = _motosCount,
                    Vehicle = (Moto)vehicle
                };
                this.compactSpots[_motosCount++]=compactSpot;
            }
            if (vehicleType == typeof(Car))
            {
                RegularSpot regularSpot = new RegularSpot()
                {
                    Number = _carsCount,
                    Vehicle = (Car)vehicle
                };
                this.regularSpots[_carsCount++] = regularSpot;
            }
            if (vehicleType == typeof(Van))
            {
                LargeSpot largeSpot = new LargeSpot()
                {
                    Number = _vansCount,
                    Vehicle = (Van)vehicle
                };
                this.largeSpots[_vansCount++] = largeSpot;
                this.largeSpots[_vansCount++] = largeSpot;
                this.largeSpots[_vansCount++] = largeSpot;
            }
        }
        public bool IsEmpty()
        {
            return (_motosCount == 0 && _carsCount == 0 && _vansCount == 0);
        }

        public bool IsFull()
        {
            return (_motosCount == this.compactSpots.Length &&
                _carsCount == this.regularSpots.Length &&
                _vansCount == this.largeSpots.Length);
        }

        public bool IsFullSpotType(SpotType spotType)
        {
            switch (spotType)
            {
                case SpotType.Motorcycle: return (_motosCount == this.compactSpots.Length);
                case SpotType.Car: return (_carsCount == this.regularSpots.Length);
                case SpotType.Large: return (_vansCount == this.largeSpots.Length);
                default: return false;
            }
        }

        public int RemainingSpots()
        {
            int availableSpots =
                (this.compactSpots.Length - _motosCount) +
                 (this.regularSpots.Length - _carsCount) +
                  (this.largeSpots.Length - _vansCount);
            return availableSpots;
        }

        public int SpotsVansTaken()
        {
            return _vansCount;
        }

        public int TotalSpots()
        {
            int totalSpots = (this.compactSpots.Length + this.regularSpots.Length + this.largeSpots.Length);
            return totalSpots;
        }
    }
}
