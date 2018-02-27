using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Test
{
    [TestClass]
    public class MyConverterTests
    {
        [TestMethod]
        public void ToRomanTest()
        {
            Assert.AreEqual("I", MyConverter.ToRoman(1));
            Assert.AreEqual("II", MyConverter.ToRoman(2));
            Assert.AreEqual("III", MyConverter.ToRoman(3));
            Assert.AreEqual("IV", MyConverter.ToRoman(4));
            Assert.AreEqual("V", MyConverter.ToRoman(5));
            Assert.AreEqual("VI", MyConverter.ToRoman(6));
            Assert.AreEqual("VII", MyConverter.ToRoman(7));
            Assert.AreEqual("VIII", MyConverter.ToRoman(8));
            Assert.AreEqual("IX", MyConverter.ToRoman(9));
            Assert.AreEqual("X", MyConverter.ToRoman(10));
            Assert.AreEqual("XL", MyConverter.ToRoman(40));
            Assert.AreEqual("XLV", MyConverter.ToRoman(45));
            Assert.AreEqual("L", MyConverter.ToRoman(50));
            Assert.AreEqual("XC", MyConverter.ToRoman(90));
            Assert.AreEqual("C", MyConverter.ToRoman(100));
            Assert.AreEqual("CD", MyConverter.ToRoman(400));
            Assert.AreEqual("CM", MyConverter.ToRoman(900));
            Assert.AreEqual("CMXCIX", MyConverter.ToRoman(999));
            Assert.AreEqual("M", MyConverter.ToRoman(1000));
        }
    }
}
