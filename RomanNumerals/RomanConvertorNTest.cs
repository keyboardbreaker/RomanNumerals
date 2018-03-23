using NUnit.Framework;
using RomanNumerals.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals.Test
{
    [TestFixture]
    class RomanConvertorNTest
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(47, "XLVII")]
        public void ConvertToRoman(int arabicValue, string romanValue)
        {
            Assert.AreEqual(romanValue, RomanConvertor.ToRoman(arabicValue));
        }
    }
}
