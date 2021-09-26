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
        public void Test1()
        {
            var mainPage = new AutorizationPageObject(_webDriver);
            mainPage.Login("alisap_etrova1992", "bgtvfrcdexswzaq1");

            bool check = mainPage.IsErrorDisplayd();

            Assert.IsTrue(check);
        }
    }
}