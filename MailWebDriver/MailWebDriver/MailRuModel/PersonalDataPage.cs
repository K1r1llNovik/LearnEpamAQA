using MailWebDriver.Base;
using MailWebDriver.MailRuModel;
using MailWebDriver.Waiters;
using OpenQA.Selenium;
using System;

namespace MailWebDriver.MailRuModel
{
    public class PersonalDataPage : BasePage
    {
        private readonly By _nickNameInput = By.XPath("//input[@data-test-id='nickname-field-input']");
        private readonly By _saveButton = By.XPath("//button[@data-test-id='save-button']");
        public PersonalDataPage(IWebDriver webDriver) : base(webDriver)
        {
            WaitPageLoading();
        }

        public override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitElementIsVisible(_nickNameInput);
        }

        public PersonalDataPage ChangeNickName(string nickName)
        {
            Waiter.WaitElementIsVisible(_nickNameInput);
            Driver.FindElement(_nickNameInput).SendKeys(nickName);
            Waiter.WaitElementToBeClickable(_saveButton);
            Driver.FindElement(_saveButton).Click();
            return this;
        }
    }
}
