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
    }
}
