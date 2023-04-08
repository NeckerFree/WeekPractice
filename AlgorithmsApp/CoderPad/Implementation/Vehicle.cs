using DevPractices.CoderPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPractices.CoderPad.Implementation
{
    public class Vehicle : IVehicle
    {
        public string Plate { get; set; } = string.Empty;
        public Color Color { get; set; }=Color.Black;
        public string OwnerName { get; set; } = string.Empty;

        public VehicleType VehicleType { get; set; }
        public int SpotsNeeded()
        {
            switch (VehicleType)
            {
                case VehicleType.Car: return 1;
                case VehicleType.Motorcycle: return 1;
                case VehicleType.Van: return 3;
                default:
                    return 0;
            }
        }
    }
}
