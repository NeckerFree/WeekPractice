using AlgorithmsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public  class ArrayOpsTests
    {
        [Fact]
        
        public void Validate_Most_Repeated_Element()
        {
            int[] arrayToValidate = { 1, 2, 4, 0, 6, 67, 5, 88, 8, 5, 44, 3, 33, 3, 9, 5, 2, 6, 9, 7, 9 };
          int actual=  ArrayOps.ValidateMostRepeatedElement(arrayToValidate);
            Assert.Equal(9, actual);
        }

        [Fact]

        public void Validate_EmptyArray()
        {
            int[] arrayToValidate = { };
            int actual = ArrayOps.ValidateMostRepeatedElement(arrayToValidate);
            Assert.Equal(-1, actual);

        }
    }
}
