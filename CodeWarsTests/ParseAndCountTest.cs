using NUnit.Framework;
using System;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ParseAndCountTest
    {
        [Test]
        public void Checkex()
        {
            ParseAndCount source = new ParseAndCount();
            Assert.AreEqual(2281337, source.PaC("[wqettr1-2qwe+Enter number: 2281337"));

            Assert.AreEqual(1561889, source.PaC("wqrrrq]q-++ Enter answer: 6334 +1555555"));

            Assert.AreEqual(1549221, source.PaC("wqr+rq-+ Enter answer: 1555555 - 6334"));
        }
    }
}