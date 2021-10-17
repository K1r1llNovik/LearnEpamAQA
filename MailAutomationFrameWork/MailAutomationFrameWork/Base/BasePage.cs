using System;
using MailAutomationFrameWork;
using OpenQA.Selenium;

namespace MailAutomationFrameWork.Base
{
    public abstract class BasePage
    {
        /// <summary>
        /// Wait time, measured in milliseconds.
        /// </summary>
        private readonly int _waitTime = 20000;

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