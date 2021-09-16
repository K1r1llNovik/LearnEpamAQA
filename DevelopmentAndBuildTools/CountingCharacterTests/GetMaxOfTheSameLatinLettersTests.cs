using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace CountingCharacterTests
{
    public class GetMaxOfTheSameLatinLettersTests
    {
        [Test]
        public void GetMaxOfTheSameLatinLetters_EmptyString_Test()
        {
            var countingCharacters = new CountingCharacters();

            var actual = countingCharacters.GetMaxOfTheSameLatinLetters(string.Empty);

            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void GetMaxOfTheSameLatinLetters_StringIsNull_Test()
        {
            var countingCharacters = new CountingCharacters();

            Assert.Throws<ArgumentNullException>(() => countingCharacters.GetMaxOfTheSameLatinLetters(null));
        }

        [Test]
        [TestCase("aaaas//***rtg", 4)]
        [TestCase("str&///////////gaaaaa", 5)]
        [TestCase("a", 1)]
        [TestCase("qwefffffqwe", 5)]
        [TestCase("aaa//233333333qwesdaaaaaaads", 7)]
        public void GetMaxOfTheSameLatinLetters_CorrectResults_Tests(string value, int expected)
        {
            var countingCharacters = new CountingCharacters();

            var actual = countingCharacters.GetMaxOfTheSameLatinLetters(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
