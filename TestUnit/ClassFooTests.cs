using System;
using FakerDemonstration.DTO;
using FakerDemonstration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnit
{
    [TestClass]
    public class ClassFooTests
    {
        private readonly Faker _faker = new Faker();

        [TestMethod]
        public void TestClassFoo()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo);
        }

        [TestMethod]
        public void TestClassFooConstructor()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsTrue(foo.a != 0);
            Assert.IsTrue(foo.b != 0);
        }

        [TestMethod]
        public void TestClassBoo()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo.Boo);
        }

        [TestMethod]
        public void TestClassStrProperty()
        {
            var foo = _faker.Create<Foo>();
            Assert.IsNotNull(foo.Str);
        }

    }
}
