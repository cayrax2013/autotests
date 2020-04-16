using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AuthorizationCianPageTests.PageObjects
{
    public class PersonalAccountPageObject
    {
        private IWebDriver _webDriver;

        public PersonalAccountPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
