using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingArchitect.Katas
{
    public static class RomanNumeralConverter
    {
        private static readonly IDictionary<int, string> ConversionFactors = new Dictionary<int, string>
        {
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        private static readonly IEnumerable<int> Arabics = ConversionFactors.Keys.OrderByDescending(a => a);

        public static string ToRoman(this int arabicNumeral)
        {
            if(arabicNumeral == 0)
                return "";
            var arabic = Arabics.First(a => arabicNumeral >= a);
            return ConversionFactors[arabic] + ToRoman(arabicNumeral - arabic);
        }
    }
}
