using System;
using MailWebDriver.Waiters;
using OpenQA.Selenium;

namespace MailWebDriver.YandexMailModel
{
    public abstract class BasePage
    {
        private readonly int _waitTime = 20000;
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
            Waiter.Driver = Driver;
            Waiter.WaitTime = _waitTime;
        }
        public abstract void WaitPageLoading();
    }
}
