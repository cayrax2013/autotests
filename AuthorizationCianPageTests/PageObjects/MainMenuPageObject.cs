using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorizationCianPageTests.PageObjects
{
    public class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _signInButton = By.CssSelector("#login-btn");
        private readonly By _userLogin = By.CssSelector(".c-header-user-login-full");
        private readonly By _personalAccountButton = By.CssSelector("#header-user-personal-link");
        private readonly By _directoryOfSpecialists = By.CssSelector("a[href='https://www.cian.ru/agentstva/'].c-header-top-menu-item");
        private readonly By _magazineTab = By.CssSelector("a[href='/magazine/']");
        private readonly By _allTheLoverTabs = By.CssSelector(".c-header-bottom-menu-item .c-header-link");
        private readonly By _cianLogoButtonLocator = By.CssSelector("span.c-header-logo--new");
        private readonly By _searchInput = By.CssSelector("input#ek-search");

        private readonly string _magazine = "magazine";

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void SearchGoods(string nameGoods)
        {
            WaitUntil.WaitElement(_webDriver, _searchInput);
            _webDriver.FindElement(_searchInput).SendKeys(nameGoods);
        }

        public MainMenuPageObject PushLogo()
        {
            _webDriver.FindElement(_cianLogoButtonLocator);

            return this;
        }

        public DirectoryOfSpecialistsPageObject NavigateToDirectoryOfSpecialists()
        {
            WaitUntil.WaitElement(_webDriver, _directoryOfSpecialists);
            _webDriver.FindElement(_directoryOfSpecialists).Click();

            return new DirectoryOfSpecialistsPageObject(_webDriver);
        }

        public AuthorizationPageObject SignIn()
        {
            _webDriver.FindElement(_signInButton).Click();

            return new AuthorizationPageObject(_webDriver);
        }

        public string GetUserLogin()
        {
            WaitUntil.WaitSomeInterval(1);
            string userLogin = _webDriver.FindElement(_userLogin).Text;
            return userLogin;
        }

        public PersonalAccountPageObject GoToPersonalAccount()
        {
            WaitUntil.WaitElement(_webDriver, _personalAccountButton);
            _webDriver.FindElement(_personalAccountButton).Click();

            return new PersonalAccountPageObject(_webDriver);
        }

        //1 способ
        public bool CheckPresentMagazineTab()
        {
            try
            {
                _webDriver.FindElement(_magazineTab);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //2 способ
        public bool CheckPresentMagazineTabTheSecondWay()
        {
            try
            {
                _webDriver.PageSource.Contains(_magazine);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool CheckAnything =>
            _webDriver.PageSource.Contains(_magazine);

        //3 способ
        public MainMenuPageObject NavigateToMagazineTab()
        {
            _webDriver.FindElement(_magazineTab).Click();

            return this;
        }

        //4 способ
        public List<string> AllTheLowerTabsText =>
            _webDriver.FindElements(_allTheLoverTabs).Select(x => x.Text).ToList();
    }
}