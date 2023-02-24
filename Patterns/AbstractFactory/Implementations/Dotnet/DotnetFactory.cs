using Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Implementations.Dotnet
{
    public class DotnetFactory : ISoftwareFactory
    {
        public override string ToString()
        {
            return typeof(DotnetFactory).Name;
        }
        public IBackEnd CreateBackend()
        {
            return new WebApi();
        }

        public IDataBase CreateDataBase()
        {
            return new SQLServer();
        }

        public IFrontEnd CreateFrontEnd()
        {
            return  new DotnetMVC();
        }
    }
}
