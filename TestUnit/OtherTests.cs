using System.Collections.Generic;
using FakerDemonstration.DTO;
using FakerDemonstration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnit
{
    [TestClass]
    public class OtherTests
    {
        private readonly Faker _faker = new Faker();

        [TestMethod]
        public void TestCycleDependency()
        {
            var a = _faker.Create<A>();

            Assert.IsNotNull(a);
            Assert.IsNull(a.B);


        }

        [TestMethod]
        public void TestIntType()
        {
            var boo = _faker.Create<int>();
            Assert.IsTrue(boo != 0);
        }

        [TestMethod]
        public void TestIntList()
        {
            var boo = _faker.Create<List<int>>();
            Assert.IsNotNull(boo);
        }

        [TestMethod]
        public void TestInt2xList()
        {
            var boo = _faker.Create<List<List<int>>>();
            Assert.IsNotNull(boo);
        }

        [TestMethod]
        public void TestFooList()
        {
            var foo = _faker.Create<List<Foo>>();
            Assert.IsNotNull(foo);
        }

        [TestMethod]
        public void TestFoo2xList()
        {
            var foo = _faker.Create<List<List<Foo>>>();
            Assert.IsNotNull(foo);
        }
    }
}