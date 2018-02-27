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
        }
    }
}
