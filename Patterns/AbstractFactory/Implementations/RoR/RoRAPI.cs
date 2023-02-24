using Patterns.AbstractFactory.Implementations.Dotnet;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.RoR
{
    public  class RoRAPI : IBackEnd
    {
        public override string ToString()
        {
            return typeof(RoRAPI).Name;
        }
    }
}