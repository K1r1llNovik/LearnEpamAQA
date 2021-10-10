using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;
using System;

namespace WebDriver.MailRuModel
{
    public class AutorizationPageObject : BasePage
    {

        private readonly By _accountNameInput = By.XPath("//input[@name='login']");
        private readonly By _furtherButton = By.XPath("//button[@data-testid='enter-password']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");
        private readonly By _signInButton = By.XPath("//button[@data-testid='login-to-mail']");
        private readonly By _errorMessage = By.XPath("//div[@class='error svelte-1tib0qz']");
        private readonly string _title = "Mail.ru: почта, поиск в интернете, новости, игры";

        private const string _path = "https://mail.ru/";

        public AutorizationPageObject(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_path);
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitTitleContain(_title);
        }

        public AutorizationPageObject InputLogin(string login)
        {
            Waiter.WaitElementIsVisible(_accountNameInput);
            Driver.FindElement(_accountNameInput).SendKeys(login);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();

            return this;
        }

        public InboxPage InputPassword(string password)
        {
            Waiter.WaitElementIsVisible(_passwordInput);
            Driver.FindElement(_passwordInput).SendKeys(password);
            Waiter.WaitElementToBeClickable(_signInButton);
            Driver.FindElement(_signInButton).Click();

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