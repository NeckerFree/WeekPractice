using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.Dotnet
{
    public  class DotnetMVC : IFrontEnd
    {
        public override string ToString()
        {
            return typeof(DotnetMVC).Name;
        }
    }
}