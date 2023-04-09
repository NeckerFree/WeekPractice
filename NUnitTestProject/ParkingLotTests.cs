using AlgorithmsApp.CoderPad.Implementation;
using DevPractices.CoderPad;
using DevPractices.CoderPad.Implementation;
using DevPractices.CoderPad.Interfaces;
using DevPractices.Implementation;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Assert = NUnit.Framework.Assert;

namespace NUnitTestProject
{
    [TestFixture]
    public class ParkingLotTests
    {
        IServiceParking iServiceParking = null;

        private const int _COMPACK_PARKING_SLOTS = 7;
        private const int _REGULAR_PARKING_SLOTS = 5;
        private const int _LARGE_PARKING_SLOTS = 3;

        [SetUp]
        public void Initialize()
        {
            iServiceParking = new ServiceParking(_COMPACK_PARKING_SLOTS, _REGULAR_PARKING_SLOTS, _LARGE_PARKING_SLOTS);
            for (int i = 0; i < 7; i++)
            {
                Vehicle vehicle = new Vehicle() { Color = Color.Red, OwnerName = "Elio" + i, Plate = "ABC" + i, VehicleType = VehicleType.Motorcycle };
                Ticket ticket = iServiceParking.AddSpot(vehicle);
            }

        }
        [TearDown]
        public void Cleanup()
        {
            iServiceParking = null;
        }
        public void ValidateCollectionInitialize()
        {
            int remaining = iServiceParking.RemainingSpots();
            Assert.That(remaining, Is.EqualTo(_COMPACK_PARKING_SLOTS));
        }
        [Test]
        public void ValidateAssignMoto()
        {
            Vehicle vehicle = new Vehicle() { Color = Color.Red, OwnerName = "Elio", Plate = "ABC", VehicleType = VehicleType.Motorcycle };
            Ticket ticket = iServiceParking.AddSpot(vehicle);
            int total = iServiceParking.TotalSpots();
            Assert.That(total, Is.EqualTo(_COMPACK_PARKING_SLOTS));
            bool isFull = iServiceParking.IsFull();
            Assert.That(isFull, Is.True);
        }
        [Test]
        public void ValidateRemoveSpot()
        {
            Ticket? ticket = iServiceParking.ReleaseSpot(0);
            bool isEmpty = iServiceParking.IsEmpty();
            Assert.IsTrue(isEmpty);
        }
        [Test]
        public void ValidateThatIfFirstListIsFullUsesSecond()
        {
            for (int i = 0; i < 8; i++)
            {
                Vehicle vehicle = new Vehicle() { Color = Color.Red, OwnerName = "Elio" + i, Plate = "ABC" + i, VehicleType = VehicleType.Motorcycle };
                Ticket ticket = iServiceParking.AddSpot(vehicle);
            }
            Vehicle vehicle1 = new Vehicle() { Color = Color.Red, OwnerName = "Elio" , Plate = "ABC" , VehicleType = VehicleType.Motorcycle };
            Ticket ticket1 = iServiceParking.AddSpot(vehicle1);
            int actual = iServiceParking.RemainingSpots();
            Assert.That(0, Is.EqualTo(actual));
        }
    }
}

