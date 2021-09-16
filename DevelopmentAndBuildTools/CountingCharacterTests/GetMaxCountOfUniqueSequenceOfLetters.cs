using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace CountingCharacterTests
{
    public class GetMaxCountOfUniqueSequenceOfLetters
    {
        [Test]
        public void GetMaxCountOfUniqueSequenceOfLetters_EmptyString_Test()
        {
            var countingCharacters = new CountingCharacters();

            var actual = countingCharacters.GetMaxCountOfUniqueSequenceOfLetters(string.Empty);

            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void GetMaxCountOfUniqueSequenceOfLetters_StringIsNull_Test()
        {
            var countingCharacters = new CountingCharacters();

            Assert.Throws<ArgumentNullException>(() => countingCharacters.GetMaxCountOfUniqueSequenceOfLetters(null));
        }

        [Test]
        [TestCase("sadwedsaaaa", 8)]
        [TestCase("aaaaaaaaaaaaa", 1)]
        [TestCase("s", 1)]
        [TestCase("aaaaserf", 5)]
        [TestCase("   ", 0)]
        public void GetMaxCountOfUniqueSequenceOfLetters_CorrectResults_Tests(string value, int expected)
        {
            var countingCharacters = new CountingCharacters();

            var actual = countingCharacters.GetMaxCountOfUniqueSequenceOfLetters(value);

            Assert.AreEqual(expected, actual);
        }
    }
}