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
            Program.getRoots("3 5 7");
            Assert.Pass();
        }
    }
}