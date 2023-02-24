using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.Dotnet
{
    public  class WebApi : IBackEnd
    {
        public override string ToString()
        {
            return typeof(WebApi).Name;
        }
    }
}