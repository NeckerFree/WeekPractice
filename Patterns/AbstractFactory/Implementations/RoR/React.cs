using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.RoR
{
    public  class React : IFrontEnd
    {
        public override string ToString()
        {
            return typeof(React).Name;
        }
    }
}