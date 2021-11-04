using System;
using MailAutomationFrameWork;
using OpenQA.Selenium;
using NUnit.Framework;

namespace MailAutomationFrameWork.Base
{
    public abstract class BasePage
    {
        private readonly int _waitTime = int.Parse(TestContext.Parameters["waittime"]);

        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
            Waiter.Driver = Driver;
            Waiter.WaitTime = _waitTime;
        }

        protected abstract void WaitPageLoading();
    }
}