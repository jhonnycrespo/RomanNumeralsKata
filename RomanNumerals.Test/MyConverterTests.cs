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
        }
    }
}
