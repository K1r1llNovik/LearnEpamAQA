using System;
using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.GoogleMailModel
{
    public class InboxPage : BasePage
    {
        private readonly string _title = "Личные сообщения и цепочки писем, которые не попали в другие разделы.";
        private readonly By _writeLetterButton = By.XPath("//div[text()='Написать']");
        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitTitleContain(_title);
        }


    }
}
