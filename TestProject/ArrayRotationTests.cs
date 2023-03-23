
using AlgorithmsApp.Codility;

namespace TestProject
{
    public class ArrayRotationTests
    {
        [Fact]

        public void ValidateRotation()
        {
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 8;
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] actual = arrayRotation.Rotate(A, K);
            int[] expected = { 9, 7, 6, 3, 8 };
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 8, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { }, 8, new int[] { })]
        [InlineData(new int[] { 7 }, 8, new int[] { 7 })]
        public void ValidateMasiveRotation(int[] A, int K, int[] B)
        {
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] actual = arrayRotation.Rotate(A, K);
            Assert.Equal(B, actual);
        }

        [Fact]
        public void UnpairedElements()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };

            ArrayRotation arrayRotation = new ArrayRotation();
            int actual = arrayRotation.GetUnparedElements(A);
            Assert.Equal(7, actual);
        }

    }
}
