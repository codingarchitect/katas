using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingArchitect.Katas
{
    public static class RomanNumeralConverter
    {
        public static string ToRoman(this int arabicNumeral)
        {
            if(arabicNumeral == 0)
                return "";
            if (arabicNumeral == 1)
                return "I";
            return "I" + ToRoman(arabicNumeral - 1);
        }
    }
}
