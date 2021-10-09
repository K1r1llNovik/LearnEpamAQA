using MailWebDriver.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver.MailRuModel;
using MailWebDriver.GoogleMailModel;

namespace MailWebDriverTests
{
    public class SendLetterTests
    {
        private IWebDriver _webDriver;
        public User validMailRuUser;
        public User validGMailUser;
        public Letter letter;

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            validMailRuUser = new User("alisap_etrova1992@mail.ru", "bgtvfrcdexswzaq15");
            letter = new Letter("jonhweek2001@gmail.com", "Привет");
        }

        [Test]
        public void SendLetterTest()
        {
            //LoginAs
            var mailRuAutorization = new AutorizationPageObject(_webDriver)
                 .InputLogin(validMailRuUser.Login)
                 .InputPassword(validMailRuUser.Password)
                 .OpenWriteALetterPage().WriteLetter(letter.EmailReciever, letter.LettersText);
        }

        [TearDown]
        public void Quit()
        {
            _webDriver.Quit();
        }
    }
}
