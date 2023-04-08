using AlgorithmsApp.CoderPad.Interfaces;
using DevPractices.CoderPad;

namespace AlgorithmsApp.CoderPad.Implementation
{
    public class Ticket : ITicket
    {
        public string? Owner { get; internal set; }
        public string? Plate { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime? EndDate { get; internal set; }
        public Guid ID { get; private set; }
        public int[] SpotNumbers { get; internal set; }

        public Ticket()
        {
            SpotNumbers = new int[3];
        }
        public void Generate(Spot spot)
        {
            if (spot.Vehicle is not null)
            {
                ID =Guid.NewGuid();
                Owner = spot.Vehicle.OwnerName;
                Plate = spot.Vehicle.Plate;
                StartDate = DateTime.Now;
                SpotNumbers[0]= spot.Number;
            }
        }
    }
}
