using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp.Fundamentals
{
    public interface IVehicle
    {
        //Interfaces are great for implementing Inversion of Control or Dependency Injection.
        //private string _myField;

        //public string MyProperty
        //{
        //    get
        //    {
        //        return _myField;
        //    }
        //    set
        //    {
        //        _myField = value;
        //    }
        //}
        int MaxSpeed { get; set; }
       
        void Move();
        void Stop();

        int CalculateSpeed(int meters, int seconds);
        int CalculateSpeed(float kilometers, float hours);

        int CalculateSpeed(float kilometers, float hours, int acceleration);
        int CalculateSpeed(float kilometers, out float hours);
        int CalculateSpeed(out float kilometers, float hours);

    }
}
