using Patterns.AbstractFactory.Implementations.Dotnet;
using Patterns.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Implementations.RoR
{
    public  class RoRFactory : ISoftwareFactory
    {
        public override string ToString()
        {
            return typeof(RoRFactory).Name;
        }
        public IBackEnd CreateBackend()
        {
            return new RoRAPI();
        }

        public IDataBase CreateDataBase()
        {
            return new PosgreSQL();
        }

        public IFrontEnd CreateFrontEnd()
        {
            return new React();
        }
    }
}
