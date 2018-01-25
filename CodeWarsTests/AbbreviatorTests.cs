using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AbbreviatorTests
    {
        [Test]
        public void TestInternationalization()
        {
            Assert.AreEqual("i18n", Abbreviator.Abbreviate("internationalization"));
        }

        [Test]
        public void TestShortSentance()
        {
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.", Abbreviator.Abbreviate("my. dog, isn't feeling very well."));
        }
    }
}