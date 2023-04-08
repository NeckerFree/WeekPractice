using DevPractices.CoderPad;
using DevPractices.CoderPad.Implementation;
using DevPractices.CoderPad.Interfaces;
using DevPractices.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.CoderPad.Implementation
{
    public class ServiceParking : IServiceParking
    {
        CompackParkingLot? compackParkingLot = null;
        RegularParkingLot? regularParkingLot = null;
        LargeParkingLot? largeParkingLot = null;

        public ServiceParking(int compack, int regular, int large)
        {
            compackParkingLot = new CompackParkingLot(compack);
            regularParkingLot = new RegularParkingLot(regular);
            largeParkingLot = new LargeParkingLot(large);

        }

        public Ticket AddSpot(Vehicle vehicle)
        {
            Ticket ticket = new Ticket();
            VehicleType vehicleType = vehicle.VehicleType;
            switch (vehicleType)
            {
                case VehicleType.Motorcycle:
                    ticket = OpenSlotMoto(vehicle);
                    break;
                case VehicleType.Car:
                    ticket = OpenSlotCar(vehicle);
                    break;
                case VehicleType.Van:
                    ticket = OpenSlotVan(vehicle);
                    break;
                default:
                    break;
            }
            return ticket;
        }

        private Ticket OpenSlotMoto(Vehicle vehicle)
        {
            Ticket ticket = new Ticket();
            if (compackParkingLot.IsFull())
            {
                if (regularParkingLot.IsFull())
                {
                    if (largeParkingLot.IsFull())
                    {
                        throw new InvalidOperationException("All parking slots for Moto are full");
                    }
                    ticket = largeParkingLot.AddSpot(vehicle);
                }
                ticket = regularParkingLot.AddSpot(vehicle);
            }
            ticket = compackParkingLot.AddSpot(vehicle);
            return ticket;
        }


        private Ticket OpenSlotCar(Vehicle vehicle)
        {
            Ticket ticket = new Ticket();
            if (compackParkingLot.IsFull())
            {
                if (regularParkingLot.IsFull())
                {
                    throw new InvalidOperationException("All parking slots are full for a Car");
                }
                ticket = regularParkingLot.AddSpot(vehicle);
            }
            ticket = compackParkingLot.AddSpot(vehicle);
            return ticket;
        }

        private Ticket OpenSlotVan(Vehicle vehicle)
        {
            Ticket ticket = new Ticket();
            if (largeParkingLot.IsFull())
            {
                if (regularParkingLot.HasThreeConsecutiveSpots())
                {
                    ticket = regularParkingLot.AddVanSpot(vehicle);
                }
            }
            ticket = largeParkingLot.AddSpot(vehicle);
            return ticket;
        }

        public bool IsEmpty()
        {
            return compackParkingLot.IsEmpty() && regularParkingLot.IsEmpty() && largeParkingLot.IsEmpty();
        }

        public bool IsFull()
        {
            return compackParkingLot.IsFull() && regularParkingLot.IsFull() && largeParkingLot.IsFull();
        }

        public bool IsFullSpotType(SpotType spotType)
        {
            switch (spotType)
            {
                case SpotType.Compack:
                    return compackParkingLot.IsFull();

                case SpotType.Car:
                    return regularParkingLot.IsFull();

                case SpotType.Large:
                    return largeParkingLot.IsFull();

                default:
                    throw new ArgumentException("Invalid Type");
            }
        }

        public Ticket? ReleaseSpot(int spotId)
        {
            Ticket ticket = null;
            ticket = compackParkingLot.ReleaseSpot(spotId);
            if (ticket == null)
            {
                ticket = regularParkingLot.ReleaseSpot(spotId);
                if (ticket == null)
                {
                    largeParkingLot.ReleaseSpot(spotId);
                }
            }
            return ticket;
        }

        public int RemainingSpots()
        {
            return compackParkingLot.RemainingSpots() + regularParkingLot.RemainingSpots() + largeParkingLot.RemainingSpots();
        }

        public int SpotsVansTaken()
        {
            return largeParkingLot.TotalSpots() - largeParkingLot.RemainingSpots();
        }

        public int TotalSpots()
        {
            return compackParkingLot.TotalSpots() + regularParkingLot.TotalSpots() + largeParkingLot.TotalSpots();
        }
    }
}
