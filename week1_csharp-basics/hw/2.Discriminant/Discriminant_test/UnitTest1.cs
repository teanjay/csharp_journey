using NUnit.Framework;
using Discriminant_and_roots;

namespace Discriminant_test
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
            int a = 0;
            int b = 0;
            int c = 0;
            Program.validateUserInput("1 15 29", ref a, ref b, ref c);
            Assert.Pass();
        }
    }
}