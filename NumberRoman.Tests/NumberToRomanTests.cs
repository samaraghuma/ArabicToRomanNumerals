using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lib= NumberToRoman.Library.NumberToRoman;
namespace NumberRoman.Tests
{
    [TestFixture]
    public class NumberToRomanTests
    {
        [Test]
            public void When1_Returns_roman1()
        {   int input = 1;
            string output = lib.GetRoman(input);
            Assert.AreEqual("I", output);
        }
        [Test]
        public void When3_Returns_roman3()
        {
            int input = 3;
            string output = lib.GetRoman(input);
            Assert.AreEqual("III", output);
        }
        [Test]
        public void When9_Returns_roman9()
        {
            int input = 9;
            string output = lib.GetRoman(input);
            Assert.AreEqual("IX", output);
        }
    }
}
