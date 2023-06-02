using AlgorithmsApp.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class LetCodeChallengesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void ValidateValidParentheses(string input, bool expected)
        {
           bool actual= LetCodeChallenges.ValidParentheses(input);
            Assert.Equal(expected, actual);
        }
    }
}
