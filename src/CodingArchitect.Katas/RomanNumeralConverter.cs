﻿using System;
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
            if (arabicNumeral >= 10)
                return "X" + ToRoman(arabicNumeral - 10);
            if (arabicNumeral == 9)
                return "IX";
            if (arabicNumeral >= 5)
                return "V" + ToRoman(arabicNumeral - 5);
            if (arabicNumeral == 4)
                return "IV";            
            return "I" + ToRoman(arabicNumeral - 1);
        }
    }
}
