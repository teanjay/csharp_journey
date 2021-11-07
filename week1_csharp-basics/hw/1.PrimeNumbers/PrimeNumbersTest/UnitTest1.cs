using NUnit.Framework;
using System.Collections;
using PrimeNumbers;

namespace PrimeNumbersTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            ArrayList expected = new ArrayList() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            Assert.AreEqual(expected, Program.primeList(100));
        }
    }
}