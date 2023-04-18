using AlgorithmsApp.Fundamentals;
using DevPractices.CoderPad.Implementation;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public  class AirplaneTests
    {
        [Fact]
        public void ValidateInheritenceAndInterface()
        {
            Airplane airplane = new Airplane(50);
            int intResult=airplane.CalculateSpeed(2, 4);
           
            int floatResult = ((IVehicle)airplane).CalculateSpeed(3.5f, 15.7f);
       }
        [Fact]
        public void ValidateStaticMethodInAbstractClass() {
            AirVehicle.Test(2, 4);
        }

        [Fact]
        public void ValidateMethodCalled()
        {
            B b = new B();
            A a = new B();
            b.m1(50); 

            a.m1(50); 
        }
    }
}
