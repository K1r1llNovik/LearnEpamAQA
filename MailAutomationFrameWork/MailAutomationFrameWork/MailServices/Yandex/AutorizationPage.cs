using System;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;
using NLog;

namespace MailAutomationFrameWork.MailServices.Yandex
{
    public class AutorizationPage : BasePage
    {
        private readonly By _loginInput = By.XPath("//input[@data-t='field:input-login']");
        private readonly By _passwordInput = By.XPath("//input[@data-t='field:input-passwd']");
        private readonly By _furtherButton = By.XPath("//button[@id='passp:sign-in']");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public AutorizationPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_loginInput);
        }

        public AutorizationPage TypeLogin(string login)
        {
            Waiter.WaitElementIsVisible(_loginInput);
            Driver.FindElement(_loginInput).SendKeys(login);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();
            _logger.Info("Type login in yandex mail");
            return this;
        }

        public InboxPage TypePassword(string password)
        {
            Waiter.WaitElementIsVisible(_passwordInput);
            Driver.FindElement(_passwordInput).SendKeys(password);
            Waiter.WaitElementToBeClickable(_furtherButton);
            Driver.FindElement(_furtherButton).Click();
            _logger.Info("Type paswword in yandex mail");
            return new InboxPage(Driver);
        }

        public InboxPage LoginAs(User user)
        {
            TypeLogin(user.Login);
            return TypePassword(user.Password);
        }
    }
}