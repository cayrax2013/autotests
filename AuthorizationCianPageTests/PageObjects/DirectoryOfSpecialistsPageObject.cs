using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthorizationCianPageTests.PageObjects
{
    public class DirectoryOfSpecialistsPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _sortByListButton = By.CssSelector(".catalog__sorting .s-button_arrow");
        private readonly By _allTheSorts = By.CssSelector(".s-popup__menu__item--sort.catalog__select__item");

        public DirectoryOfSpecialistsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public DirectoryOfSpecialistsPageObject SearchSortBy(string nameSort)
        {
            WaitUntil.WaitElement(_webDriver, _sortByListButton);
            _webDriver.FindElement(_sortByListButton).Click();

            WaitUntil.WaitSomeInterval(1);
            var sortBy = _webDriver.FindElements(_allTheSorts).First(x => x.Text == nameSort);
            sortBy.Click();

            return this;
        }
    }
}
