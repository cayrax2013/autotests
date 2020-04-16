using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationCianPageTests
{
    public static class WaitUntil
    {
        public static void ShoudLocate(IWebDriver webDriver, string location)
        {
            try
            {
                new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(location));
            }
            catch(WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location: {location}", ex);
            }
        }

        public static void WaitSomeInterval(int seconds = 10)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void WaitElement(IWebDriver webDriver, By locator, int seconds = 20)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
    }
}
