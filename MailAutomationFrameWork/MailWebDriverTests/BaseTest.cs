using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using MailAutomationFrameWork.Driver;
using MailAutomationFrameWork.Utils;
using MailAutomationFrameWork.Base;

namespace MailWebDriverTests
{
    public class BaseTest
    {
        protected IWebDriver _webDriver;
        public User validMailRuUser;
        public User validYandexUser;
        public Letter sendLetter;
        public Letter replyLetter;

        [SetUp]
        public void SetUp()
        {
            _webDriver = DriverSingleton.GetDriver();
        }

        [TearDown]
        public void TearDrown()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure
                || TestContext.CurrentContext.Result.Outcome == ResultState.Error)
            {
                new ScreenShoter().TakeScreenshot(_webDriver);
            }

            DriverSingleton.CloseDriver();
        }
    }
}
