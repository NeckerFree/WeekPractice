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
            string actual = stringChallenges.GetUniques(input);
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
        [Theory]
        [InlineData("Parangaricutirimicuaro", 8)]
        public void ValidateLengthOfLongestSubstring(string input, int expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
            int actual = stringChallenges.LengthOfLongestSubstring(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateLongestCommonPrefix()
        {
            string[] strs = { "flower", "flow", "flight" };
            string expected = "fl";
            StringChallenges stringChallenges = new StringChallenges();
            string actual = stringChallenges.LongestCommonPrefix(strs);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateLongestCommonPrefixOne()
        {
            string[] strs = { "aa", "aa" };
            string expected = "aa";
            StringChallenges stringChallenges = new StringChallenges();
            string actual = stringChallenges.LongestCommonPrefix(strs);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("22", new string[] { "aa", "ab", "ac", "ba", "bb", "bc", "ca", "cb", "cc" })]

        public void ValidateLetterCombinations(string input, string[] expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
            IList<string> actual = stringChallenges.LetterCombinations(input);
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("a", "a", 0)]
        [InlineData("abc", "c", 2)]
        public void ValidateFirstOccurrence(string haystack, string needle, int expected)
        {
            StringChallenges stringChallenges = new StringChallenges();
          int actual=  stringChallenges.CalculateFirstOcurrence(haystack, needle);
            Assert.Equal(expected, actual);
        }
    }
}
