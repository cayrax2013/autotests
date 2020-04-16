using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AuthorizationCianPageTests.PageObjects
{
    public class AuthorizationPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _loginInputButton = By.XPath("//input[@name='username']");
        private readonly By _continueButton = By.XPath("//button[@data-mark='ContinueAuthBtn']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='password']");
        private readonly By _enterButton = By.XPath("//button[@data-mark='ContinueAuthBtn']");
        private readonly By _phoneNumberInputButton = By.CssSelector("input[placeholder='Телефон']");

        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public MainMenuPageObject CreateNewUser(string mail, string password, string phoneNumber)
        {
            WaitUntil.WaitElement(_webDriver, _loginInputButton);
            _webDriver.FindElement(_loginInputButton).SendKeys(mail);
            _webDriver.FindElement(_continueButton).Click();
            WaitUntil.WaitElement(_webDriver, _passwordInputButton);
            _webDriver.FindElement(_passwordInputButton).SendKeys(password);
            _webDriver.FindElement(_phoneNumberInputButton).SendKeys(phoneNumber);

            return new MainMenuPageObject(_webDriver);
        }

        public MainMenuPageObject Login(string login, string password)
        {
            _webDriver.FindElement(_loginInputButton).SendKeys(login);
            _webDriver.FindElement(_continueButton).Click();
            WaitUntil.WaitElement(_webDriver, _passwordInputButton);
            _webDriver.FindElement(_passwordInputButton).SendKeys(password);
            _webDriver.FindElement(_enterButton).Click();

            return new MainMenuPageObject(_webDriver);
        }
    }
}