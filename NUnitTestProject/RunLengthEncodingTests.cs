using AlgorithmsApp.String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    public class RunLengthEncodingTests
    {
        [Test]
        public void ValidateEncode()
        {
          string expected = "2A3B4C";
            string actual = RunLengthEncoding.Encode("AABBBCCCC");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void ValidateEncodeUnique()
        {
            string expected = "XYZ";
            string actual = RunLengthEncoding.Encode("XYZ");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateDecode()
        {
            string expected = "WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB";
            string actual = RunLengthEncoding.Decode("12WB12W3B24WB");
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
