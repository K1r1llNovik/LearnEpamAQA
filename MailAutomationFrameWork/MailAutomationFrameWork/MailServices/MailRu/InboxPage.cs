using System;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;
using NLog;

namespace MailAutomationFrameWork.MailServices.MailRu
{
    public class InboxPage : BasePage
    {
        private readonly By _recivedLetterText = By.XPath("//div[contains(@class,'letter-body')]//div[contains(@class,'body-content')]");
        private readonly By _lastIncomingLetter = By.XPath("//div[@class='dataset__items']//a[contains(@class,'letter-bottom')][1]");
        private readonly By _writeAMessageButton = By.XPath("//span[@class='compose-button__txt']");
        private readonly By _sideBarWithPersonalDataButton = By.XPath("//div[@data-testid='whiteline-account']");
        private readonly By _personalDataButton = By.XPath("//div[text()='Личные данные']");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
        }

        public PersonalDataPage OpenPersonalData()
        {
            Waiter.WaitElementToBeClickable(_sideBarWithPersonalDataButton);
            Driver.FindElement(_sideBarWithPersonalDataButton).Click();
            Waiter.WaitElementToBeClickable(_personalDataButton);
            Driver.FindElement(_personalDataButton).Click();
            _logger.Info("Open personal data page");

            return new PersonalDataPage(Driver);
        }

        public InboxPage OpenLastIncomingLetter()
        {
            Waiter.WaitElementIsVisible(_lastIncomingLetter);
            Driver.FindElement(_lastIncomingLetter).Click();
            _logger.Info("Open last incoming letter");
            return this;
        }

        public string GetTextInLetter()
        {
            Waiter.WaitElementIsVisible(_recivedLetterText);
            return Driver.FindElement(_recivedLetterText).Text.Trim();
        }

        public WriteLetterPage OpenWriteALetterPage()
        {
            Waiter.WaitElementToBeClickable(_writeAMessageButton);
            Driver.FindElement(_writeAMessageButton).Click();
            _logger.Info("Open write a letter page");

            return new WriteLetterPage(Driver);
        }

    }
}
