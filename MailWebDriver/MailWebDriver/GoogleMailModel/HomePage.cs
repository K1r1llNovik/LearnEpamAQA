using System;
using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.GoogleMailModel
{
    public class HomePage : BasePage
    {
        private readonly By _logInButton = By.XPath("//a[@data-action='sign in']");
        private readonly string _title = "Электронная почта Gmail: надежно, конфиденциально, бесплатно | Google Workspace";

        private const string _path = "https://www.google.com/intl/ru/gmail/about/";
        public HomePage(IWebDriver webDriver) : base(webDriver)
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

        public HomePage OpenLoginPage()
        {
            Waiter.WaitElementToBeClickable(_logInButton);
            Driver.FindElement(_logInButton).Click();

            return this;
        }
    }
}
