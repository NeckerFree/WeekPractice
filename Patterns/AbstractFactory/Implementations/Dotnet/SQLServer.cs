using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.Dotnet
{
    public  class SQLServer : IDataBase
    {
        public override string ToString()
        {
            return typeof(SQLServer).Name;
        }
    }
}