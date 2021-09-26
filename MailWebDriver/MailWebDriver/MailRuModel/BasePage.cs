using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace MailWebDriver.MailRuModel
{
   public abstract class BasePage
    {
        private IWebDriver _webDriver;

        public BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
