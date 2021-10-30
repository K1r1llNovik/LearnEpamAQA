using System;
using MailAutomationFrameWork;
using MailAutomationFrameWork.Base;
using OpenQA.Selenium;
using NLog;

namespace MailAutomationFrameWork.MailServices.Yandex
{
    public class HomePage : BasePage
    {
        private readonly string _title = "Яндекс.Почта — бесплатная и надежная электронная почта";
        private readonly By _signInButton = By.XPath("//div[@class='HeadBanner-ButtonsWrapper']//span[text()='Войти']/parent::a");
        private const string _path = "https://mail.yandex.by/";
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_path);
            WaitPageLoading();
        }

        protected override void WaitPageLoading()
        {
            Waiter.WaitPageLoading();
            Waiter.WaitTitleContain(_title);
        }

        public AutorizationPage OpenAutorizatioPage()
        {
            Waiter.WaitElementToBeClickable(_signInButton);
            Driver.FindElement(_signInButton).Click();
            _logger.Info("Open autorization yandex mail page");
            return new AutorizationPage(Driver);
        }
    }
}