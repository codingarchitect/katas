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
        public void TestToRoman()
        {
            var testData = new Dictionary<int, string>
            {
                { 1, "I" },
                { 2, "II" },
                { 3, "III" },
                { 4, "IV" },
                { 5, "V" },
                { 6, "VI" }
            };

            foreach (var arabic in testData.Keys)
            {
                var roman = arabic.ToRoman();
                Assert.AreEqual(testData[arabic], roman);
            }
        }
    }
}
