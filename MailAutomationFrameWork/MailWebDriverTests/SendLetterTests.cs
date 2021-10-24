using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MailAutomationFrameWork.Base;
using MailAutomationFrameWork.MailServices.MailRu;
using MailAutomationFrameWork.MailServices.Yandex;
using MailAutomationFrameWork.Service;

namespace MailWebDriverTests
{
    public class SendLetterTests : CommonCondition
    {
        public User validMailRuUser;
        public User validYandexUser;
        public Letter sendLetter;
        public Letter replyLetter;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            validMailRuUser = UserCreator.UserMailRu;
            validYandexUser = UserCreator.UserYandex;
            sendLetter = LetterCreator.SendLetter;
            replyLetter = LetterCreator.ReplyLetter;
        }

        [Test]
        public void SendLetterTest_IsNotReadAndCorrectEmailText()
        {
            var defaultMailRu = new MailAutomationFrameWork.MailServices.MailRu.AutorizationPage(_webDriver).LoginAs(validMailRuUser)
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
        public void ChangeNickName_Test()
        {
            var mailRuDriver = new MailAutomationFrameWork.MailServices.MailRu.AutorizationPage(_webDriver).LoginAs(validMailRuUser);

            string nickName = mailRuDriver.OpenLastIncomingLetter().GetTextInLetter();

            Assert.AreEqual(nickName, mailRuDriver.OpenPersonalData().ChangeNickName(nickName).GetNickName());
        }
    }
}
