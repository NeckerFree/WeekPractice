using AlgorithmsApp.Codility;
namespace TestProject
{
    public class ZerosGapTests
    {
        [Theory]
        //[InlineData(1041, 5)]
        //[InlineData(15, 0)]
        //[InlineData(32, 0)]
        //[InlineData(1, 0)]
        //[InlineData(5, 1)]
        //[InlineData(2147483647, 0)]
        //[InlineData(9, 2)]
        [InlineData(561892, 3)]
        //[InlineData(1073741825, 29)]
        public void MyTestMethod(int number, int response)
        {
            ZerosGap zerosGap = new ZerosGap();
           int actual= zerosGap.MaxGap(number);
            Assert.Equal(response, actual);

        }
    }
}
