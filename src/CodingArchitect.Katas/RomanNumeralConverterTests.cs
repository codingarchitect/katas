using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodingArchitect.Katas
{
    [TestFixture]
    public class RomanNumeralConverterTests
    {
        [Test]
        public void Test0ReturnsEmpty()
        {
            var roman = 0.ToRoman();
            Assert.AreEqual("", roman);
        }

        [Test]
        public void Test1ReturnsI()
        {
            var roman = 1.ToRoman();
            Assert.AreEqual("I", roman);
        }

        [Test]
        public void Test2ReturnsII()
        {
            var roman = 2.ToRoman();
            Assert.AreEqual("II", roman);
        }
    }
}
