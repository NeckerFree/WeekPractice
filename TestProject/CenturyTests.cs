using AlgorithmsApp.Classes;

namespace TestProject
{
    public class CenturyTests
    {
        [Fact]
        public void ValidateYear()
        {
            Century century = new Century();
            int actual=century.Calculate(101);
            Assert.Equal(2, actual);
        }
    }
}
