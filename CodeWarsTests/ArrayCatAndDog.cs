using System.Collections.Generic;
using System.Text;
using CodeWars;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArrayCatAndDog
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(CatAndDog.Solve(new List<char> { 'D', 'C', 'C', 'D', 'C' }, 1), Is.EqualTo(2));
            Assert.That(CatAndDog.Solve(new List<char> { 'C', 'C', 'D', 'D', 'C', 'D' }, 2), Is.EqualTo(3));
            Assert.That(CatAndDog.Solve(new List<char> { 'C', 'C', 'D', 'D', 'C', 'D' }, 1), Is.EqualTo(2));
            Assert.That(CatAndDog.Solve(new List<char> { 'D', 'C', 'D', 'C', 'C', 'D' }, 3), Is.EqualTo(3));
            Assert.That(CatAndDog.Solve(new List<char> { 'C', 'C', 'C', 'D', 'D' }, 3), Is.EqualTo(2));
            Assert.That(CatAndDog.Solve(new List<char> { 'C', 'C', 'C', 'D', 'D' }, 2), Is.EqualTo(2));
            Assert.That(CatAndDog.Solve(new List<char> { 'C', 'C', 'C', 'D', 'D' }, 1), Is.EqualTo(1));
        }
    }
}