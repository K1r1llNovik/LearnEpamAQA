using System;
using System.Threading;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;
using NLog;

namespace MailAutomationFrameWork.MailServices.MailRu
{
    public class AutorizationPage : BasePage
    {

        private readonly By _accountNameInput = By.XPath("//input[@name='login']");
        private readonly By _furtherButton = By.XPath("//button[@data-testid='enter-password']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");
        private readonly By _signInButton = By.XPath("//button[@data-testid='login-to-mail']");
        private readonly By _errorMessage = By.XPath("//div[@class='error svelte-1tib0qz']");

        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private const string _path = "https://mail.ru/";

        public AutorizationPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_path);
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_accountNameInput);
        }

        public AutorizationPage InputLogin(string login)
        {
            Waiter.WaitElementIsVisible(_accountNameInput);
            Driver.FindElement(_accountNameInput).SendKeys(login);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();
            _logger.Info("Input login");
            return this;
        }

        public InboxPage InputPassword(string password)
        {
            Waiter.WaitElementIsVisible(_passwordInput);
            Driver.FindElement(_passwordInput).SendKeys(password);
            Waiter.WaitElementToBeClickable(_signInButton);
            Driver.FindElement(_signInButton).Click();
            _logger.Info("Input password");

            return new InboxPage(Driver);
        }

        public InboxPage LoginAs(User user)
        {
            InputLogin(user.Login);
            return InputPassword(user.Password);
        }

        public bool IsErrorDisplayed()
        {
            Waiter.WaitElementIsVisible(_errorMessage);
            return Driver.FindElement(_errorMessage).Displayed;
        }
    }
}
