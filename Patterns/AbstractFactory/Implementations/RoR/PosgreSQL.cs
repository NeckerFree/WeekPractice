using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Implementations.RoR
{
    public  class PosgreSQL : IDataBase
    {
        public override string ToString()
        {
            return typeof(PosgreSQL).Name;
        }
    }
}