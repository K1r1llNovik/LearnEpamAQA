using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using MailAutomationFrameWork.Driver;
using MailAutomationFrameWork.Utils;

namespace MailWebDriverTests
{
    public class CommonCondition
    {
        protected IWebDriver _webDriver;

        [SetUp]
        public void SetUp()
        {
            _webDriver = DriverSingleton.GetDriver();
        }
        [TearDown]
        public void TearDrown()
        {
            if(TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
            {
                new ScreenShoter().TakeScreenshot(_webDriver);
            }

            DriverSingleton.CloseDriver();
        }
    }
}
