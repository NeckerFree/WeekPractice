using DevPractices.CoderPad.Implementation;

namespace DevPractices.CoderPad
{
    public class Spot
    {
        public int Number { get; set; }
        public Vehicle? Vehicle { get; internal set; }
        public string? Plate { get; internal set; }

    }
}
