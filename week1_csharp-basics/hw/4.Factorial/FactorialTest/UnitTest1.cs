using NUnit.Framework;
using Factorial;
namespace FactorialTest
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
            int result;
            Program.factorial(8, out result);
            Assert.AreEqual(result, 40320);
        }
        public void Test2()
        {
            int result;
            Program.factorial(3, out result);
            Assert.AreEqual(result, 6);
        }
        public void Test3()
        {
            int result;
            Program.factorial(4, out result);
            Assert.AreEqual(result, 24);
        }
        public void Test4()
        {
            int result;
            Program.factorial(5, out result);
            Assert.AreEqual(result, 120);
        }
        public void Test5()
        {
            int result;
            Program.factorial(6, out result);
            Assert.AreEqual(result, 720);
        }
        public void Test6()
        {
            int result;
            Program.factorial(7, out result);
            Assert.AreEqual(result, 5040);
        }
        public void Test7()
        {
            int result;
            Program.factorial(9, out result);
            Assert.AreEqual(result, 362880);
        }
    }
}