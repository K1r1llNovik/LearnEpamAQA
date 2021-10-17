using System;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;

namespace MailAutomationFrameWork.MailServices.MailRu
{
    public class PersonalDataPage : BasePage
    {
        private readonly By _nickNameInput = By.XPath("//input[@data-test-id='nickname-field-input']");
        private readonly By _saveButton = By.XPath("//button[@data-test-id='save-button']");
        public PersonalDataPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_nickNameInput);
        }

        public PersonalDataPage ChangeNickName(string nickName)
        {
            Waiter.WaitElementIsVisible(_nickNameInput);
            Driver.FindElement(_nickNameInput).Clear();
            Driver.FindElement(_nickNameInput).SendKeys(nickName);
            Waiter.WaitElementToBeClickable(_saveButton);
            Driver.FindElement(_saveButton).Click();
            return this;
        }

        public string GetNickName()
        {
            Driver.Navigate().Refresh();
            Waiter.WaitElementIsVisible(_nickNameInput);
            var element = Driver.FindElement(_nickNameInput);
            return element.GetAttribute("value");
        }
    }
}
