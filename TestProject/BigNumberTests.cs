using AlgorithmsApp.BigNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class BigNumberTests
    {
        [Theory]
        [InlineData("2","3", "6")]
        [InlineData("9", "99", "891")]
        [InlineData("9133", "0", "0")]
        [InlineData("123", "456", "56088")]
        public void ValidateProductBigNumbers(string first, string second, string expected)
        {
           string actual = BigNumbersOperations.Multiply(first, second);
            Assert.Equal(expected, actual);
        }
    }
}
