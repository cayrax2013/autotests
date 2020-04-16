using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationCianPageTests.PageObjects
{
    public class RentPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _buyButton = By.CssSelector("a[href='/kupit/']");

        public RentPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public RentPageObject NavigateToBuyTab()
        {
            _webDriver.FindElement(_buyButton).Click();
            return this;
        }
    }
}
