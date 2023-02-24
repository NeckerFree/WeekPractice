namespace Patterns.AbstractFactory.Interfaces
{
    public  interface ISoftwareFactory
    {
        public IFrontEnd CreateFrontEnd();
        public IBackEnd CreateBackend();
        public IDataBase CreateDataBase();
    }
}
