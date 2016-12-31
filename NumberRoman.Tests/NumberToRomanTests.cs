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
        [Test]
        public void When1066_Returns_roman1066()
        {
            int input = 1066;
            string output = lib.GetRoman(input);
            Assert.AreEqual("MLXVI", output);
        }
        [Test]
        public void When1989_Returns_roman1989()
        {
            int input = 1989;
            string output = lib.GetRoman(input);
            Assert.AreEqual("MCMLXXXIX", output);
        }
    }
}
