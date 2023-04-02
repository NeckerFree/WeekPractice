using System;
using System.Runtime.CompilerServices;

namespace DevPractices.Classes
{
    public class RemoteControlCar
    {
        public int _speed;
        public double _batteryDrain;

        public int meters;
        public static double battery;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            _speed = speed;
            _batteryDrain = batteryDrain;
            battery = 100;
            meters = 0;
        }

        public bool BatteryDrained()
        {
            return (battery < _batteryDrain);
        }

        public int DistanceDriven()
        {
            return meters;
        }

        public void Drive()
        {
            if (BatteryDrained() == false)
            {
                meters = meters + _speed;
                battery = battery - _batteryDrain;
            }
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50, 4);
        }
    }

    public class RaceTrack
    {
        private int distance;

        public RaceTrack(int distance)
        {
            this.distance = distance;
        }

        // TODO: define the constructor for the 'RaceTrack' class

        public bool TryFinishTrack(RemoteControlCar car)
        {
            double drivesToComplete = distance / (double)car._speed;
            double batteryToConsum = (car._batteryDrain * drivesToComplete);
            return batteryToConsum <= 100;

        }
    }

}
