using CodeWars;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests
{
    [TestFixture]
    internal class WildCardsTest
    {
        [Test]
        public void Basic1()
        {
            var list = new List<string> { "1001", "1011" };
            Assert.AreEqual(new WildCards().Possibilities("10?1").OrderBy(t => t), list.OrderBy(t => t));
        }

        [Test]
        public void Basic2()
        {
            var list = new List<string> { "1001", "1011", "1000", "1010" };
            Assert.AreEqual(new WildCards().Possibilities("10??").OrderBy(t => t), list.OrderBy(t => t));
        }

        [Test]
        public void Basic3()
        {
            var list = new List<string> { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            Assert.AreEqual(new WildCards().Possibilities("????").OrderBy(t => t), list.OrderBy(t => t));
        }
    }
}