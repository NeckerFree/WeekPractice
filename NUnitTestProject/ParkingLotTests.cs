using DevPractices.CoderPad.Implementation;
using DevPractices.CoderPad.Interfaces;
using DevPractices.Implementation;
using NUnitLite;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace NUnitTestProject
{
    public class ParkingLotTests
    {
        //public static int Main(string[] args)
        //{
        //    return new AutoRun(Assembly.GetCallingAssembly()).Execute(new String[] { "--labels=All" });
        //}

        [TestFixture]
        public class Dog
        {
            public String Bark()
            {
                return "bark";
            }

            [Test]
            public void TestBarker()
            {
                Dog dog = new Dog();
                string actual = dog.Bark();
                Assert.That(actual, Is.EqualTo("bark"));
            }

            [Test]
            public void ValidateAvailableSpots()
            {
                IParkingLot parkingLot = new ParkingLot(10, 12, 5);
                int availableSpots = parkingLot.RemainingSpots();
                Assert.Equals(availableSpots, 27);
            }
            [Test]

            public void ValidateAssignParkingCar()
            {
                ParkingLot parkingLot = new ParkingLot(10, 12, 5);
                parkingLot.AddSpot(new Car { Color = "Red", OwnerName = "Elio", Plate = "AXD345" }); 
                int cars=parkingLot.RemainingSpots();
                Assert.Equals(cars, 26);
            }
            [Test]
            public void ValidateAssignParkingVan() {
                ParkingLot parkingLot = new ParkingLot(10, 12, 5);
                parkingLot.AddSpot(new Van { Color = "Yellow", OwnerName = "Matias", Plate = "FRG564" });
                int spots = parkingLot.RemainingSpots();
                Assert.Equals(spots, 24);
            }

        }
    }
}


/*
 public class Prueba{
        public static string Bark()
        {
            return "Bark";
        }
}
public class Runner {
    public static int Main(string[] args) {
        return new AutoRun(Assembly.GetCallingAssembly()).Execute(new String[] {"--labels=All"});
    }

    [TestFixture]
    public class Validate {
        [Test]
        public void TestBarker() {
            string response=Prueba.Bark();
            Assert.AreEqual("Bark", response);
        }
    }
}
*/