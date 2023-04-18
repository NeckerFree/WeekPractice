using AlgorithmsApp.GlossGenius;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class CountSlotsTests
    {
        [Fact]
        public void CalculateLines()
        {
            CountSlots countSlots = new CountSlots(@"C:\Elio\Development\Projects\WeekPractice\AlgorithmsApp\GlossGenius\Appointments.json");
            int slots = countSlots.CalculateSlot(30);
            Assert.Equal(0, slots);
        }
    }
}
