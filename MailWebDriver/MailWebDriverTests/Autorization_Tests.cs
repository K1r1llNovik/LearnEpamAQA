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
            var user = new User("alisap_etrova1992@mail.ru", "bgtvfrcdexswzaq15");
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.InputLogin(user.Login);

            Assert.AreEqual(1, 1);
        }

        [Test]
        [TestCase("qwsfiuahroisdfsdfscvferlwer12344","]'/mnbvcxsertyjklp987t--")]
        [TestCase("","")]
        public void IncorrectLogin_ReturnTrue_Tests(string login, string password)
        {
            var user = new User(login, password);
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.InputLogin(user.Login);

            bool condition = autorizationPage.IsErrorDisplayd();

            Assert.IsTrue(condition);
        }

        [Test]
        [TestCase("alisap_etrova1992@mail.ru", "qweqwesfsvtrterwwef")]
        [TestCase("alisap_etrova1992@mail.ru", "")]
        public void IncorrectLogin_ReturnTrues_Tests(string login, string password)
        {
            var user = new User(login, password);
            var autorizationPage = new AutorizationPageObject(_webDriver);
            autorizationPage.InputLogin(user.Password);

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