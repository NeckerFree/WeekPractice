using AlgorithmsApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StringOperationsTests
    {
        [Fact]
        public void ValidatePalindrome() {
            StringOperations  stringOperations = new StringOperations();
         bool actual=   stringOperations.IsPalindrome("aabaa");
            Assert.True(actual);
            }
    }
}
