using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ReSharperDemo;

namespace UnitTest
{
    [TestFixture]
    public class DogTest
    {
        [Test]
        public void TestAge()
        {
            int age = 5;
            var dog = new Dog { Age = age };
            Assert.That(age, Is.EqualTo(dog.Age));
        }

        [Test]
        public void TestName()
        {
            string name = "Spike";
            var dog = new Dog { Name = name };
            Assert.That(name, Is.EqualTo(dog.Name));
        }
    }
}
