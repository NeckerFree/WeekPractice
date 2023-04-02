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

            int speed = 3;
            int batteryDrain = 20;
            var car = new RemoteControlCar(speed, batteryDrain);
            int distance = 16;
            var race = new RaceTrack(distance);
            var can = race.TryFinishTrack(car);
            Assert.False(can);

        }
    }
}
