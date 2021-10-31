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
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxOfTheSameLatinLetters(string.Empty);

            //ASSERT
            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void GetMaxOfTheSameLatinLetters_StringIsNull_Test()
        {
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT + ASSERT
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
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxOfTheSameLatinLetters(value);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
