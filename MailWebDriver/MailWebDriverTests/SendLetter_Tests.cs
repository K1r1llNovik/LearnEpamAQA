using MailWebDriver.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver.MailRuModel;
using MailWebDriver.YandexMailModel;

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
            sendLetter = new Letter("johnwheeck2001@yandex.by", "Hello My Friend");
            replyLetter = new Letter("alisap_etrova1992@mail.ru", "NewNickName");
        }

        [Test]
        [Order(1)]
        public void SendLetterTest_IsNotReadAndCorrectEmailText()
        {
            var defaultMailRu = new AutorizationPageObject(_webDriver).LoginAs(validMailRuUser)
                .OpenWriteALetterPage()
                .WriteLetter(sendLetter.EmailReciever, sendLetter.LettersText);

            var defaultYandexMail = new HomePage(_webDriver).OpenAutorizatioPage().LoginAs(validYandexUser).UpdateLetters();

            bool isNotRead = defaultYandexMail
                .UpdateLetters()
                .IsNotReadedLastIncomingLetter();

            Assert.IsTrue(isNotRead, "The letter is read");

            var openInbox = defaultYandexMail.OpenLastIncomingLetter();

            string text = openInbox.GetLetterText();
            Assert.AreEqual(sendLetter.LettersText, text);

            string email = openInbox.GetSenderEmail();
            Assert.AreEqual(validMailRuUser.Login, email);

            openInbox.ReplyLetter(replyLetter.LettersText);
        }
        [Test]
        [Order(2)]
        public void ChangeNickName_Test()
        {
            var mailRuDriver = new AutorizationPageObject(_webDriver).LoginAs(validMailRuUser);

            string nickName = mailRuDriver.OpenLastIncomingLetter().GetTextInLetter();

            Assert.AreEqual(nickName, mailRuDriver.OpenPersonalData().ChangeNickName(nickName).GetNickName());
        }

        [TearDown]
        public void Tests_TearDown()
        {
            _webDriver.Quit();
        }
    }
}
