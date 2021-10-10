using System;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.YandexMailModel
{
    public class InboxPage : BasePage
    {
        private readonly By _allLetters = By.XPath("//div[contains(@class, 'MessagesList')]/div");
        private readonly By _updateButton = By.XPath("//span[@data-click-action='mailbox.check']");
        private readonly By _lastIncomingLetter = By.XPath("//div[contains(@class, 'MessagesList')]/div[1]");
        private readonly By _notReadedIcon = By.XPath("//div[contains(@class, 'MessagesList')]/div[1]//span[@class='mail-MessageSnippet-Item mail-MessageSnippet-Item_body js-message-snippet-body']//span[@class='mail-Icon mail-Icon-Read js-read toggles-svgicon-on-active is-active']");
        private readonly string _title = "Входящие — Яндекс.Почта";
        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitTitleContain(_title);
        }

        public InboxPage UpdateLetters()
        {
            Waiter.WaitElementToBeClickable(_updateButton);
            Driver.FindElement(_updateButton).Click();
            return this;
        }

        public bool IsNotReadedLastIncomingLetter()
        {
            Waiter.WaitVisabilityOfAllElementLocatedBy(_allLetters);
            return Driver.FindElement(_notReadedIcon).Displayed;
        }

        public LetterPage OpenLastIncomingLetter()
        {
            Waiter.WaitVisabilityOfAllElementLocatedBy(_allLetters);
            Waiter.WaitElementIsVisible(_lastIncomingLetter);
            Driver.FindElement(_lastIncomingLetter).Click();
            return new LetterPage(Driver);
        }


    }
}
