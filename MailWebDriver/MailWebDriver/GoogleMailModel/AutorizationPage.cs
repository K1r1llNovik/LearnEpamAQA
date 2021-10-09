using System;
using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.GoogleMailModel
{
    public class AutorizationPage : BasePage
    {
        private readonly By _changeAccountButton = By.XPath("//div[text()='Сменить аккаунт']");
        private readonly By _usernameInput = By.XPath("//input[@type='email']");
        private readonly By _furtherButton = By.XPath("//span[text()='Далее']");
        private readonly By _passwordInput = By.XPath("//input[@type='password']");
        public AutorizationPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementToBeClickable(_changeAccountButton);
        }

        public AutorizationPage TypeUsername(string login)
        {
            Driver.FindElement(_changeAccountButton).Click();
            Waiter.WaitElementIsVisible(_usernameInput);
            Driver.FindElement(_usernameInput).SendKeys(login);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();
            return this;
        }

        public AutorizationPage TypePassword(string password)
        {
            Waiter.WaitElementIsVisible(_passwordInput);
            Driver.FindElement(_passwordInput).SendKeys(password);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();
            return this;
        }
    }
}
