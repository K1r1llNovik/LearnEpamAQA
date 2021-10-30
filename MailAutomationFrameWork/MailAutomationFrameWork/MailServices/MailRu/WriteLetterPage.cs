using System;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;
using NLog;

namespace MailAutomationFrameWork.MailServices.MailRu
{
    public class WriteLetterPage : BasePage
    {
        private readonly By _recieverInput = By.XPath("//label[@class='container--zU301']");
        private readonly By _letterInput = By.XPath("//br/parent::div");
        private readonly By _sendButton = By.XPath("//span[text()='Отправить']");
        private readonly By _closeLayerWindowButton = By.XPath("//div[@class='layer__controls']/span");
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        public WriteLetterPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_recieverInput);
        }

        public WriteLetterPage TypeRecieverName(string recieverName)
        {
            Driver.FindElement(_recieverInput).SendKeys(recieverName);
            _logger.Info("Type reciever name");
            return this;
        }

        public WriteLetterPage TypeLetter(string letter)
        {
            Waiter.WaitElementIsVisible(_letterInput);
            Driver.FindElement(_letterInput).SendKeys(letter);
            _logger.Info("Type letter");

            return this;
        }

        public WriteLetterPage SendMessage()
        {
            Waiter.WaitElementToBeClickable(_sendButton);
            Driver.FindElement(_sendButton).Click();
            _logger.Info("Click on send button");

            return this;
        }

        public InboxPage CloseLayerWindow()
        {
            Waiter.WaitElementToBeClickable(_closeLayerWindowButton);

            Driver.FindElement(_closeLayerWindowButton).Click();

            _logger.Info("Close layer window");

            return new InboxPage(Driver);
        }

        public InboxPage WriteLetter(string recieverName, string letter)
        {
            TypeRecieverName(recieverName);
            TypeLetter(letter);
            SendMessage();

            return CloseLayerWindow();
        }
    }
}
