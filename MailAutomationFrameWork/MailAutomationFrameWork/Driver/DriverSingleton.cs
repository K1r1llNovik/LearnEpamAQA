using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MailAutomationFrameWork.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver _webDriver;

        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if (_webDriver == null)
            {
                switch (TestContext.Parameters["browser"])
                {
                    default:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        _webDriver = new ChromeDriver();
                        break;
                }
                _webDriver.Manage().Window.Maximize();
            }
            return _webDriver;
        }

        public static void CloseDriver()
        {
            _webDriver.Quit();
            _webDriver = null;
        }
    }
}
