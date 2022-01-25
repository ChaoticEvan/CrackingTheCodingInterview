using ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestArraysAndStrings
{
    [TestClass]
    public class TestIsUnique
    {
        [TestMethod]
        public void TestUniqueString()
        {
            Assert.IsTrue(IsUnique.IsStringUnique("abc"));
        }

        [TestMethod]
        public void TestNonUniqueString()
        {
            Assert.IsFalse(IsUnique.IsStringUnique("aaabbc"));
        }
    }
}
