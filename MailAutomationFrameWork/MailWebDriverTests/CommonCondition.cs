using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MailAutomationFrameWork.Driver;

namespace MailWebDriverTests
{
    public class CommonCondition
    {
        protected IWebDriver _wevDriver;

        [SetUp]
        public void SetUp()
        {
            _wevDriver = DriverSingleton.GetDriver();
        }
        [TearDown]
        public void TearDrown()
        {
            
        }
    }
}
