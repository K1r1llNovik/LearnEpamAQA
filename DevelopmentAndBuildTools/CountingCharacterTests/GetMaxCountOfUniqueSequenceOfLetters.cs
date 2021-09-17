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
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxCountOfUniqueSequenceOfLetters(string.Empty);

            //ASSERT
            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void GetMaxCountOfUniqueSequenceOfLetters_StringIsNull_Test()
        {
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT + ASSERT
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
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxCountOfUniqueSequenceOfLetters(value);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}