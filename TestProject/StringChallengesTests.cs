using AlgorithmsApp.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class StringChallengesTests
    {
        [Theory]
        [InlineData("Elio Nelson Cortés Martínez", "zenítraM sétroC nosleN oilE")]
        public void ValidateReverseSentence(string input, string expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
            string actual = stringChallenges.ReverseEachString(input);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Parangaricutirimicuaro", "Parngicutmo")]
        public void ValidateUniqueChars(string input, string expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
          string actual=  stringChallenges.GetUniques(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Parangaricutirimicuaro", false)]
        public void ValidateSenteceContainsUniqueChars(string input, bool expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
            bool actual = stringChallenges.HasUniques(input);
            Assert.Equal(expected, actual);
        }
    }
}
