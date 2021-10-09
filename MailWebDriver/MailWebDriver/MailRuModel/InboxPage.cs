using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;
using System;


namespace MailWebDriver.MailRuModel
{
    public class InboxPage : BasePage
    {
        private readonly By _writeAMessageButton = By.XPath("//span[@class='compose-button__txt']");
        private readonly By _sideBarWithPersonalDataButton = By.XPath("//div[@data-testid='whiteline-account']");
        private readonly By _personalDataButton = By.XPath("//div[text()='Личные данные']");
        private readonly string _title = "Входящие - Почта Mail.ru";

        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitTitleContain(_title);
        }

        public InboxPage OpenPersonalData()
        {
            Waiter.WaitElementToBeClickable(_sideBarWithPersonalDataButton);
            Driver.FindElement(_sideBarWithPersonalDataButton).Click();
            Waiter.WaitElementToBeClickable(_personalDataButton);
            Driver.FindElement(_personalDataButton).Click();

            return this;
        }

        public WriteLetterPage OpenWriteALetterPage()
        {
            Waiter.WaitElementToBeClickable(_writeAMessageButton);
            Driver.FindElement(_writeAMessageButton).Click();

            return new WriteLetterPage(Driver);
        }

    }
}
