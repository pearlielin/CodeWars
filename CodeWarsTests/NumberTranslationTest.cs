using System;
using System.Collections.Generic;
using System.Text;
using CodeWars;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberTranslationTest
    {
        [Test]
        public void Number2WordsTest()
        {
            Assert.AreEqual("zero", NumberTranslation.Number2Words(0));
        }

        [Test]
        public void Number2WordsTest1()
        {
            Assert.AreEqual("one", NumberTranslation.Number2Words(1));
        }

        [Test]
        public void Number2WordsTest21()
        {
            Assert.AreEqual("twenty-one", NumberTranslation.Number2Words(21));
        }

        [Test]
        public void Number2WordsTest301()
        {
            Assert.AreEqual("three hundred one", NumberTranslation.Number2Words(301));
        }

        [Test]
        public void Number2WordsTest793()
        {
            Assert.AreEqual("seven hundred ninety-three", NumberTranslation.Number2Words(793));
        }

        [TestCase("eight hundred", 800)]
        [TestCase("six hundred fifty",650)]
        [TestCase("one thousand", 1000)]
        [TestCase("one thousand three", 1003)]
        public void Number2Words(string word,int num)
        {
            Assert.AreEqual(word, NumberTranslation.Number2Words(num));
        }

        [TestCase("three thousand fifty-one", 3051)]
        [TestCase("seven thousand two hundred", 7200)]
        [TestCase("seven thousand two hundred nineteen", 7219)]
        [TestCase("eight thousand three hundred thirty", 8330)]
        [TestCase("ninety-nine thousand nine hundred ninety-nine", 99999)]
        [TestCase("eight hundred eighty-eight thousand eight hundred eighty-eight", 888888)]
        public void BigNumber2Words(string word,int num)
        {
            Assert.AreEqual(word, NumberTranslation.Number2Words(num));
        }

    }
}
