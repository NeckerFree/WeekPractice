using DevPractices.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace TestProject
{
    public class RemoteControlCarTests
    {
        [Fact]
        public void Validate()
        {

            int speed = 5;
            int batteryDrain = 1;
            var car = new RemoteControlCar(speed, batteryDrain);
             car.Drive();
            var dd = car.DistanceDriven();
            Assert.Equal(5, dd);
                    }
    }
}
