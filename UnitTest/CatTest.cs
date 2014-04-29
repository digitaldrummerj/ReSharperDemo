using NUnit.Framework;
using ReSharperDemo;

namespace UnitTest
{
    [TestFixture]
    public class CatTest
    {
        [Test]
        public void TestAge()
        {
            int age = 5;
            var cat = new Cat {Age = age};
            Assert.That(age, Is.EqualTo(cat.Age));
        }

        [Test]
        public void TestName()
        {
            string name = "Fluffy";
            var cat = new Cat {Name = name};
            Assert.That(name, Is.EqualTo(cat.Name));
        }

    }
}
