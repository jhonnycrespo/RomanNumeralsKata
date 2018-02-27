using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("I", MyConverter.ToRoman(1));
        }
    }
}
