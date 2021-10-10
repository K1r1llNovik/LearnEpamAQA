using MailWebDriver.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver.MailRuModel;
using MailWebDriver.YandexMailModel;
using System.Threading;

namespace MailWebDriverTests
{
    public class SendLetterTests
    {
        private IWebDriver _webDriver;
        public User validMailRuUser;
        public User validYandexUser;
        public Letter sendLetter;
        public Letter replyLetter;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            validMailRuUser = new User("alisap_etrova1992@mail.ru", "bgtvfrcdexswzaq15");
            validYandexUser = new User("johnwheeck2001@yandex.by", "qazwsxedcrfvtgb15");
            sendLetter = new Letter("johnwheeck2001@yandex.by", "Привет");
        }

        [Test]
        public void SendLetterTest_IsNotReadAndCorrectEmailSender()
        {
            var defaultYandexMail = new HomePage(_webDriver).OpenAutorizatioPage().LoginAs(validYandexUser);

            bool isNotRead = defaultYandexMail
                .UpdateLetters()
                .IsNotReadedLastIncomingLetter();

            Assert.IsTrue(isNotRead,"The letter is read");

            string text = defaultYandexMail.OpenLastIncomingLetter().GetLetterText();

            Assert.AreEqual(sendLetter.LettersText, text);
            Thread.Sleep(3000);
        }

        [TearDown]
        public void Quit()
        {
            _webDriver.Quit();
        }
    }
}
