using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MailAutomationFrameWork
{
    public static class Waiter
    {
        /// <summary>
        /// Get or set driver
        /// </summary>
        public static IWebDriver Driver { get; set; }

        /// <summary>
        /// Get or set waiting time in milliseconds
        /// </summary>
        public static int WaitTime { get; set; }

        /// <summary>
        /// A method that waits until the locator becomes visible
        /// </summary>
        /// <param name="locator"></param>
        public static void WaitElementIsVisible(By locator)
        {
            new WebDriverWait(Driver, new TimeSpan(0, 0, 0, 0, WaitTime)).Until(ExpectedConditions.ElementIsVisible(locator));
        }

        /// <summary>
        /// A method that waits until the locator becomes clickable
        /// </summary>
        /// <param name="locator"></param>
        public static void WaitElementToBeClickable(By locator)
        {
            new WebDriverWait(Driver, new TimeSpan(0, 0, 0, 0, WaitTime)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void WaitTitleContain(string title)
        {
            new WebDriverWait(Driver, new TimeSpan(0, 0, 0, 0, WaitTime)).Until(ExpectedConditions.TitleContains(title));
        }

        public static void WaitVisabilityOfAllElementLocatedBy(By locator)
        {
            new WebDriverWait(Driver, new TimeSpan(0, 0, 0, 0, WaitTime)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
        /// <summary>
        /// Waiting for the specified time
        /// </summary>
        public static void WaitPageLoading()
        {
            new WebDriverWait(Driver, new TimeSpan(0, 0, 0, 0, WaitTime));
        }
    }
}