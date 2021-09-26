using OpenQA.Selenium;
using System;
using System.Text;
using System.Threading;

namespace WebDriver.MailRuModel
{
    public class AutorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _accountNameInput = By.XPath("//input[@name='login']");
        private readonly By _furtherButton = By.XPath("//button[@data-testid='enter-password']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");
        private readonly By _signInButton = By.XPath("//button[@data-testid='login-to-mail']");
        private readonly By _errorMessage = By.XPath("//div[@class='error svelte-1tib0qz']");

        private const string _path = "https://mail.ru/";

        public AutorizationPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(_path);
        }

        public AutorizationPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_accountNameInput).SendKeys(login);
            _webDriver.FindElement(_furtherButton).Click();
            Thread.Sleep(10000);
            _webDriver.FindElement(_passwordInput).SendKeys(password);
            _webDriver.FindElement(_signInButton).Click();

            return this;
        }

        public bool IsErrorDisplayd()
        {
            Thread.Sleep(10000);
            return _webDriver.FindElement(_errorMessage).Displayed;
        }
    }
}