using AuthorizationCianPageTests.JsonDelete;
using AuthorizationCianPageTests.PageObjects;
using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorizationCianPageTests
{
    [TestFixture]
    public class AuthorizationCianPageTests : BaseTest
    {
        [Test]
        public void LoginAsUser_StandartBehavior_Logined()
        {
            Console.WriteLine(EnvironmentConstants.Name);
        }
    }
}