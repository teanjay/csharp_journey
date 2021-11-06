using NUnit.Framework;
using test_project_oop;

namespace test_project_oop_test
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
            var kirill = new Human("Kirill", 23, new Cat("Alfie", 13, "bengal", "Kirill", 50));
            kirill.FeedPets("something");
            Assert.AreEqual(kirill.Pets[0].Satiety, 51);
        }
    }
}