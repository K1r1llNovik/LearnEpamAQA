using System;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.YandexMailModel
{
    public class LetterPage : BasePage
    {
        private readonly By _senderEmail = By.XPath("//span[contains(@class, 'SenderEmail')]");
        private readonly By _letterText = By.XPath("//div[contains(@class,'MessageBody')]//div[contains(@class,'MessageViewer')]//div[2]");
        private readonly By _answerButton = By.XPath("//div[@data-params='source=toolbar']//span[text()='Ответить']");
        private readonly By _ansewInput = By.XPath("//div[contains(@class,'context_menu')]//div[1]");
        private readonly By _sendButton = By.XPath("//button[@type='button']//span[text()='Отправить']");
        public LetterPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_senderEmail);
        }

        public string GetSenderEmail()
        {
            Waiter.WaitElementIsVisible(_senderEmail);
            return Driver.FindElement(_senderEmail).Text;
        }

        public string GetLetterText()
        {
            Waiter.WaitElementIsVisible(_letterText);
            return Driver.FindElement(_letterText).Text;
        }

        public LetterPage ReplyLetterButton()
        {
            Waiter.WaitElementToBeClickable(_answerButton);
            Driver.FindElement(_answerButton).Click();
            return this;
        }

        public LetterPage ReplyLetterInputText(string letterText)
        {
            Waiter.WaitElementIsVisible(_ansewInput);
            Driver.FindElement(_ansewInput).SendKeys(letterText);
            return this;
        }

        public LetterPage SendLetterButton()
        {
            Waiter.WaitElementToBeClickable(_sendButton);
            Driver.FindElement(_sendButton).Click();
            return this;
        }

        public LetterPage ReplyLetter(string letterText)
        {
            ReplyLetterButton();
            ReplyLetterInputText(letterText);
            SendLetterButton();
            return this;
        }
    }
}
