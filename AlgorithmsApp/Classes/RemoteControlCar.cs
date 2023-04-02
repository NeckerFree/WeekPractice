using System;
using System.Runtime.CompilerServices;

namespace DevPractices.Classes
{
    public class RemoteControlCar
    {
        private static int _speed;
        private static double _batteryDrain;

        public int meters;
        public static double battery = 100;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            _speed = speed;
            _batteryDrain = batteryDrain;
        }

        public bool BatteryDrained()
        {
            return (battery == 0);
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
            return new RemoteControlCar(50, (int)(battery * 0.04));
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
          bool canFinish=!  car.BatteryDrained();
            return canFinish;
        }
    }

}
