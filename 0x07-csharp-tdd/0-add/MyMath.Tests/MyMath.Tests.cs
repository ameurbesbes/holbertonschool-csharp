using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(40, 10)]
        [TestCase(37, 13)]
        [TestCase(25, 25)]
        [TestCase(50, 0)]
        [TestCase(100, -50)]
        public void SimpleAddition(int value, int valueb)
        {
            var res = MyMath.Operations.Add(value, valueb);
            Assert.AreEqual(50, res);
        }
    }
}
