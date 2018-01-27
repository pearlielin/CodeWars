using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NotRandomTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Black", NotRandom.NotSoRandom(1, 1));

            Assert.AreEqual("White", NotRandom.NotSoRandom(2, 1));

            Assert.AreEqual("Black", NotRandom.NotSoRandom(1, 2));

            Assert.AreEqual("White", NotRandom.NotSoRandom(2, 2));

            Assert.AreEqual("White", NotRandom.NotSoRandom(6, 9));

            Assert.AreEqual("White", NotRandom.NotSoRandom(10000, 10000));

            Assert.AreEqual("Black", NotRandom.NotSoRandom(11111, 22222));
        }
    }
}
