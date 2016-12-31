﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using lib=NumberToRoman.Library.NumberToRoman;
namespace NumberRoman.Tests
{
    [TestFixture]
    public class NumberToRomanTests
    {
        [Test]

        public void When1_Returns_roman1()
        {
            int input = 1;
            string output = lib.GetRoman(input);
            Assert.AreEqual("I", output);
        }
       
    }
}
