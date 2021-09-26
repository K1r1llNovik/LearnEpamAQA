using MailWebDriver.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver.MailRuModel;

namespace MailWebDriverTests
{
    public class Tests
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void CorrectLoginAndPassword_Test()
        {
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.Login(new User("alisap_etrova1992@mail.ru", "bgtvfrcdexswzaq15"));

            Assert.AreEqual(1, 1);
        }

        [Test]
        public void InCorrectLogin_ReturnTrue_Test()
        {
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.Login(new User("sawddvcx@mail.ru", "bgtvfrcdexswzaq15"));

            bool condition = autorizationPage.IsErrorDisplayd();
            Assert.IsTrue(condition);
        }

        [Test]
        public void EmptyLogin_ReturnTrue_Test()
        {
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.Login(new User(string.Empty, "aasdasdasd"));

            bool condition = autorizationPage.IsErrorDisplayd();
            Assert.IsTrue(condition);
        }

        [Test]
        public void InCorrectPassword_ReturnTrue_Test()
        {
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.Login(new User("alisap_etrova1992@mail.ru", "bgtvfrcdexsw"));

            bool condition = autorizationPage.IsErrorDisplayd();
            Assert.IsTrue(condition);
        }

        [Test]
        public void EmptyPassword_ReturnTrue_Test()
        {
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.Login(new User("alisap_etrova1992@mail.ru", string.Empty));

            bool condition = autorizationPage.IsErrorDisplayd();
            Assert.IsTrue(condition);
        }

        [TearDown]
        public void Quit()
        {
            _webDriver.Quit();
        }
    }
}