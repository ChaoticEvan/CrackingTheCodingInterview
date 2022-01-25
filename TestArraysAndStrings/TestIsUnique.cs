using ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestArraysAndStrings
{
    [TestClass]
    public class TestIsUnique
    {
        [TestMethod]
        public void TestUniqueStringBruteForce()
        {
            Assert.IsTrue(IsUnique.IsStringUniqueBruteForce("abc"));
        }

        [TestMethod]
        public void TestNonUniqueStringBruteForce()
        {
            Assert.IsFalse(IsUnique.IsStringUniqueBruteForce("aaabbc"));
        }
    }
}
