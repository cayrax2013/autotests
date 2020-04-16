//using AuthorizationCianPageTests.PageObjects;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Remote;
//using System.Threading;

//namespace AuthorizationCianPageTests
//{
//    [TestFixture]
//    class CheckngTheOperationOfLocatorsTests : BaseTest
//    {
//        [Test]
//        public void CheckingLocators_StandartBehavior_LocatorsWorking()
//        {
//            var mainMenu = new MainMenuPageObject(_webDriver);
//            mainMenu
//                .SignIn()
//                .Login(UserNameForTests.StartLogin, UserNameForTests.StartLoginPassword);

//            WaitUntil.WaitSomeInterval(2);
//            string actualLogin = mainMenu.GetUserLogin();

//            Assert.AreEqual(UserNameForTests.UserLogin, actualLogin, "Login is wrong or Enter wasn't completed");
//        }
//    }
//}
