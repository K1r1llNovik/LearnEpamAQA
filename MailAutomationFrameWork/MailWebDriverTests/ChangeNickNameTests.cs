using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MailAutomationFrameWork.Base;
using MailAutomationFrameWork.MailServices.MailRu;
using MailAutomationFrameWork.MailServices.Yandex;
using MailAutomationFrameWork.Service;

namespace MailWebDriverTests
{
    public class ChangeNickNameTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            validMailRuUser = UserCreator.UserMailRu;
        }

        [Test]
        [Category("All")]
        public void ChangeNickName_Test()
        {

            var mailRuDriver = new MailAutomationFrameWork.MailServices.MailRu.AutorizationPage(_webDriver).LoginAs(validMailRuUser);

            string nickName = mailRuDriver.OpenLastIncomingLetter().GetTextInLetter();

            Assert.AreEqual(nickName, mailRuDriver.OpenPersonalData().ChangeNickName(nickName).GetNickName());
        }
    }
}
