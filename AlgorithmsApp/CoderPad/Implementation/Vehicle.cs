using DevPractices.CoderPad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevPractices.CoderPad.Implementation
{
    public abstract class Vehicle : IVehicle
    {
        public string Plate { get; set; }=string.Empty;
        public string Color { get; set; } = string.Empty;
        public string OwnerName { get; set; } = string.Empty;

        public virtual int SpotsNeeded()
        {
            return 1;
        }
    }
}
