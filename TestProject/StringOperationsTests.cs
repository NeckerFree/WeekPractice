using AlgorithmsApp.Classes;
using AlgorithmsApp.HackerRank;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestProject
{
    public class StringOperationsTests
    {
        [Fact]
        public void ValidatePalindrome()
        {
            StringOperations stringOperations = new StringOperations();
            bool actual = stringOperations.IsPalindrome("aabaa");
            Assert.True(actual);
        }

        [Fact]
        public void ValidateStringNotReapeat()
        {
            string s = "abdghjk";
            string actual = StringEx.IsValid(s);
            Assert.Equal("YES", actual);
        }

        [Fact]
        public void ValidateStringOneReapeat()
        {
            string s = "abdkghjk";
            string actual = StringEx.IsValid(s);
            Assert.Equal("YES", actual);
        }
        [Fact]
        public void ValidateStringMultipleReapeat()
        {
            string s = "abdkkghjk";
            string actual = StringEx.IsValid(s);
            Assert.Equal("NO", actual);
        }

        [Fact]
        public void ValidateStringMultipleReapeatLetters()
        {
            string s = "abdkkghjk";
            string actual = StringEx.IsValid(s);
            Assert.Equal("NO", actual);
        }
        [Fact]
        public void ValidateStringSameReapeated()
        {
            string s = "abcdefghhgfedecba";
            string actual = StringEx.IsValid(s);
            Assert.Equal("YES", actual);
        }
        [Fact]
        public void ValidateStringDiffReapeated()
        {
            string s = "aabbcd";
            string actual = StringEx.IsValid(s);
            Assert.Equal("NO", actual);
        }
        [Fact]
        public void ValidateStringTwoReapeated()
        {
            string s = "abbac";
            string actual = StringEx.IsValid(s);
            Assert.Equal("YES", actual);
        }

        [Theory]
        [InlineData(new string[] { "bella", "label", "roller" }, new string[] { "e", "l", "l" })]
        [InlineData(new string[] { "cool", "lock", "cook" }, new string[] { "c", "o" })]
        public void ValidateFindCommonCharacters(string[] input, string[] expected)
        {
            //Given a string array words, return an array of all characters that show up in all
            //strings within the words(including duplicates). You may return the answer in any order.
            string[] actual = StringEx.FindCommonCharacters(input);
            Assert.Equal(expected, actual);

        }

    }
}
