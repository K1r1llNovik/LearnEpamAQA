using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MailAutomationFrameWork.Base;
using MailAutomationFrameWork.MailServices.MailRu;
using MailAutomationFrameWork.Service;

namespace MailWebDriverTests
{
    public class AutorizationTests : CommonCondition
    {
        [Test]
        public void CorrectLoginAndPassword_Test()
        {
            var autorizationPage = new AutorizationPage(_webDriver);
            var IsHomePage = autorizationPage.LoginAs(UserCreator.UserMailRu);

            bool condition = IsHomePage is InboxPage;

            Assert.IsTrue(condition);
        }

        [Test]
        public void IncorrectLogin_ReturnTrue_Tests()
        {
            var user = UserCreator.UserInvalidLoginMailRu;
            var autorizationPage = new AutorizationPage(_webDriver);
            autorizationPage.InputLogin(user.Login);

            bool condition = autorizationPage.IsErrorDisplayed();

            Assert.IsTrue(condition);
        }

        [Test]
        public void IncorrectPassword_ReturnTrue_Tests()
        {
            var autorizationPage = new AutorizationPage(_webDriver);
            var inboxPage = autorizationPage.LoginAs(UserCreator.UserInvalidPasswordMailRu);


            bool condition = autorizationPage.IsErrorDisplayed();
            Assert.IsTrue(condition);
        }

        [Test]
        public void EmptyLogin_ReturnTrue_Tests()
        {
            var user = UserCreator.UserEmptyMailRU;
            var autorizationPage = new AutorizationPage(_webDriver);
            autorizationPage.InputLogin(user.Login);

            bool condition = autorizationPage.IsErrorDisplayed();

            Assert.IsTrue(condition);
        }
    }
}