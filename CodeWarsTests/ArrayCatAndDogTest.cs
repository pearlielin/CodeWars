using CodeWars;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArrayCatAndDogTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(CatAndDog.Solve(new List<char> {'D', 'C', 'C', 'D', 'C'}, 1), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest1()
        {
            Assert.That(CatAndDog.Solve(new List<char> {'C', 'C', 'D', 'D', 'C', 'D'}, 2), Is.EqualTo(3));
        }

        [Test]
        public void SampleTest2()
        {//2,3,5 //0,1,4
            Assert.That(CatAndDog.Solve(new List<char> {'C', 'C', 'D', 'D', 'C', 'D'}, 1), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.That(CatAndDog.Solve(new List<char> {'D', 'C', 'D', 'C', 'C', 'D'}, 3), Is.EqualTo(3));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.That(CatAndDog.Solve(new List<char> {'C', 'C', 'C', 'D', 'D'}, 3), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest5()
        {//3,4 // 0,1,2
            Assert.That(CatAndDog.Solve(new List<char> {'C', 'C', 'C', 'D', 'D'}, 2), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest6()
        {
            Assert.That(CatAndDog.Solve(new List<char> {'C', 'C', 'C', 'D', 'D'}, 1), Is.EqualTo(1));
        }
    }
}