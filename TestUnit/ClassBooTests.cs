using System;
using FakerDemonstration;
using FakerDemonstration.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestUnit
{
    [TestClass]
    public class ClassBooTests
    {
        private readonly Faker _faker = new Faker();

        [TestMethod]
        public void TestClassBooConstructor()
        {
            var boo = _faker.Create<Boo>();
            Console.WriteLine(boo);
            Assert.IsNotNull(boo);
        }

        [TestMethod]
        public void TestClassIntFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.a != 0);
        }

        [TestMethod]
        public void TestClassCharFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.b.ToString() != "");
        }

        [TestMethod]
        public void TestClassDateTimeFiledConstructor()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsNotNull(boo.c);
        }

        [TestMethod]
        public void TestClassIntArray()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsNotNull(boo.IntArray);
        }

        [TestMethod]
        public void TestClassFloatProperty()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.d != 0.0);
        }

        [TestMethod]
        public void TestClassPrivateIntFlied()
        {
            var boo = _faker.Create<Boo>();
            Assert.IsTrue(boo.GetE() == 0);
        }
    }
}