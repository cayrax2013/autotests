using AuthorizationCianPageTests.JsonDelete;
using AuthorizationCianPageTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorizationCianPageTests
{
    public class BaseTest
    {
        protected IWebDriver webDriver;
        protected MainMenuPageObject mainMenu;

        //Поле, которым будем в дальнейшем пользоваться в тестовых классах
        protected EnvironmentConstants EnvironmentConstants;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-fullscreen");
            webDriver = new ChromeDriver(chromeOptions);
            mainMenu = new MainMenuPageObject(webDriver);
            //Вызываем этот метод, когда будет производится инициализация.
            InitializeData();
        }

        //Создал метод для удобства и читабельности кода
        private void InitializeData()
        {
            EnvironmentConstantsProvider.Provide(out EnvironmentConstants environmentConstants);
            EnvironmentConstants = environmentConstants;
        }

        [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {
            webDriver.Quit();
        }

        [SetUp]
        protected void DobeforeEach()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Navigate().GoToUrl(TestSettings.HostPrefix);
            //webDriver.Manage().Window.Maximize();
            //WaitUntil.ShoudLocate(webDriver, TestSettings.LocationCian);
        }
    }
}
