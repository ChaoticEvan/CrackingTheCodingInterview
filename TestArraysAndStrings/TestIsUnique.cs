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
            Assert.IsTrue(IsUnique.IsStringUniqueBruteForce("abc"));
            Assert.IsTrue(IsUnique.IsStringUniqueNoDataStructure("abc"));
        }

        [TestMethod]
        public void TestNonUniqueString()
        {
            Assert.IsFalse(IsUnique.IsStringUniqueBruteForce("aaabbc"));
            Assert.IsFalse(IsUnique.IsStringUniqueNoDataStructure("aaabbc"));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.IsTrue(IsUnique.IsStringUniqueBruteForce(""));
            Assert.IsTrue(IsUnique.IsStringUniqueNoDataStructure(""));
        }
    }
}
