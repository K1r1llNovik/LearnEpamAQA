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
            if(_webDriver == null)
            {
                switch (TestContext.Parameters["browser"])
                {
                    case "opera":
                        new DriverManager().SetUpDriver(new OperaConfig());
                        _webDriver = new OperaDriver();
                        break;
                    default:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        _webDriver = new ChromeDriver();
                        break;
                }
                _webDriver.Manage().Window.Maximize();
            }
            return _webDriver;
        }

        public void CloseDriver()
        {
            _webDriver.Quit();
            _webDriver = null;
        }

    }
}
