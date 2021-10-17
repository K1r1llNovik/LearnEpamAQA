using System;
using OpenQA.Selenium;
using System.IO;
using NUnit.Framework;

namespace MailAutomationFrameWork.Service
{
    public class TestDataReader
    {
        public void TakeScreenshot(IWebDriver webDriver)
        {
            ((ITakesScreenshot)webDriver).GetScreenshot().SaveAsFile(CreateFileName(), ScreenshotImageFormat.Png);
        }

        public string CreateLocation()
        {
            string saveLocation = @"A:\ScreenShots";

            if (!Directory.Exists(saveLocation))
            {
                Directory.CreateDirectory(saveLocation);
            }
            return saveLocation;
        }

        public string CreateFileName()
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string testName = TestContext.CurrentContext.Test.FullName;

            return CreateLocation() + time + testName + ".png";
        }
    }
}
