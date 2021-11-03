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
                    case "opera":
                        var optionsOpera = new OperaOptions();
                        optionsOpera.AddArgument("--start-maximized");
                        optionsOpera.AddArgument("--disable-popup-blocking");
                        new DriverManager().SetUpDriver(new OperaConfig());
                        _webDriver = new OperaDriver(optionsOpera);
                        break;
                    default:
                        var optionsChrome = new ChromeOptions();
                        optionsChrome.AddArgument("--start-maximized");
                        optionsChrome.AddArgument("--disable-popup-blocking");
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        _webDriver = new ChromeDriver(optionsChrome);
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
