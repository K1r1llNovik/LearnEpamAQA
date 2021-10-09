using System;
using OpenQA.Selenium;

namespace MailWebDriver.MailRuModel
{
   public abstract class BasePage
    {
        /// <summary>
        /// Wait time, measured in milliseconds.
        /// </summary>
        private readonly int _waitTime = 20000;

        private IWebDriver _webDriver;

        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            Waiters.Waiter.Driver = _webDriver;
            Waiters.Waiter.WaitTime = _waitTime;
        }

        public abstract void WaitPageLoading();
    }
}
