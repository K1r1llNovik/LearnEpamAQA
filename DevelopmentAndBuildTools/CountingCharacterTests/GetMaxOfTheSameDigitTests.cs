using NUnit.Framework;
using DevelopmentAndBuildTools;
using System;

namespace CountingCharacterTests
{
    public class GetMaxOfTheSameDigitTests
    {
        [Test]
        public void GetMaxOfTheSameDigit_EmptyString_Test()
        {
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxOfTheSameDigit(string.Empty);

            //ASSERT
            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void GetMaxOfTheSameDigit_StringIsNull_Test()
        {
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => countingCharacters.GetMaxOfTheSameLatinLetters(null));
        }

        [Test]
        [TestCase("1234////*5555", 4)]
        [TestCase("55555/////&&&&&&", 5)]
        [TestCase("5", 1)]
        [TestCase("**/sad0000000/..,,", 7)]
        [TestCase("aaa//233333333qwesdaaaaaaads", 8)]
        public void GetMaxOfTheSameLatinLetters_CorrectResults_Tests(string value, int expected)
        {
            //ARRANGE
            var countingCharacters = new CountingCharacters();

            //ACT
            var actual = countingCharacters.GetMaxOfTheSameDigit(value);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}