using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.Fundamentals
{
    public abstract class AirVehicle : IVehicle
    {
        public int MaxSpeed { get; set; }
        private int height; //Fields
        private int speed;

        protected AirVehicle(int maxSpeed)
        {
            this.MaxSpeed = maxSpeed;
        }
        public void Move()
        {
            speed++;
        }

        public void Stop()
        {
            this.speed = 0;
        }

        protected abstract void Fly();
        protected virtual void Land()
        {
            this.speed = 0;
            this.height = 0;
        }

        public abstract int CalculateSpeed(int meters, int seconds);

        int  IVehicle.CalculateSpeed(float kilometers, float hours)
        {
            float speed = (kilometers * hours);
            return (int)speed;
        }

        public static void Test(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public int CalculateSpeed(float kilometers, float hours, int acceleration)
        {
            throw new NotImplementedException();
        }

        public int CalculateSpeed(float kilometers, out float hours)
        {
            throw new NotImplementedException();
        }

        public int CalculateSpeed(out float kilometers, float hours)
        {
            throw new NotImplementedException();
        }
    }
}
