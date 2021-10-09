using MailWebDriver.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver.MailRuModel;

namespace MailWebDriverTests
{
    public class SendLetterTests
    {
        private IWebDriver _webDriver;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void SendLetterTest()
        {
            var user = new User("alisap_etrova1992@mail.ru", "bgtvfrcdexswzaq15");
            var autor = new AutorizationPageObject(_webDriver).InputLogin(user.Login).InputPassword(user.Password).OpenWriteALetterPage().WriteLetter("jonhweek2001@gmail.com", "asdwqd");
            Assert.AreEqual(1, 1);     
        }

        [TearDown]
        public void Quit()
        {
            _webDriver.Quit();
        }
    }
}
