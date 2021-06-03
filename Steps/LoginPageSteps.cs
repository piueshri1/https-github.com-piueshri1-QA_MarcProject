using Marc.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Marc.Steps
{
    [Binding]
    public sealed class LoginPageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
         public LoginPageSteps()
        {
             driver = new ChromeDriver();
          //  driver = new InternetExplorerDriver();
            loginPage = new LoginPage(driver);
        }

        [AfterScenario]
        public void RunAftetEveryTest()
        {
            driver.Close();
        }



        [When(@"I lunch the application")]
        public void WhenILunchTheApplication()
        {

           // LoginPage loginPage = new LoginPage();
            loginPage.navigateToLoginPage();
            Console.WriteLine("I lunch the application");
        }

        [When(@"I click the signin  link")]
        public void WhenIClickTheSigninLink()
        {

          //  LoginPage loginPage = new LoginPage();
            loginPage.clickSignLink();
            Console.WriteLine("I click the signin  link");
        }

        [When(@"I validate that i am at login page")]
        public void WhenIValidateThatIAmAtLoginPage()
        {

         //   LoginPage loginPage = new LoginPage();
           bool isAtLoginPage = loginPage.validateYouAreAtLoginPage();
            Assert.IsTrue(isAtLoginPage);
        }

    
        [When(@"I enter valid Cred")]
        public void WhenIEnterValidCred()
        {
         //   LoginPage loginPage = new LoginPage();
            loginPage.enterEmailIdAndPasswordRefactor( null, null);
            Console.WriteLine("I enter valid Cred");
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
           // LoginPage loginPage = new LoginPage();
            loginPage.clickLoginButton();
            Console.WriteLine("I click the login button");
        }

        [When(@"I login with emailId ""(.*)""")]
        public void WhenILoginWithUsername(string emailId)
        {
           // LoginPage loginPage = new LoginPage();
            loginPage.enterEmailIdAndPasswordRefactor( emailId,null);
            Console.WriteLine("I login with username = "+ emailId);
        }

        [When(@"I login with (.*) and with (.*)")]
        public void WhenILoginWithAndWith(string emailId, string password)
        {
        //    LoginPage logiinPage = new LoginPage();
            loginPage.enterEmailIdAndPasswordRefactor(emailId, password);
             Console.WriteLine("I login with username = " + emailId + " and with password = "+ password);        }


            [Then(@"I should be not login")]
        public void ThenIShouldBeNotLogin()
        {
          //  LoginPage loginPage = new LoginPage();
            bool isNotLogin = loginPage.validateNotLoginSuccessfuly();
            Console.WriteLine("I should be not login");
            Assert.IsTrue(isNotLogin);
        }


        [Then(@"I shoul be able to login successfully")]
        public void ThenIShoulBeAbleToLoginSuccessfully()
        {
          //  LoginPage logiinPage = new LoginPage();
          bool isLogin =  loginPage.validateLoginSuccessfully();
            Console.WriteLine("I shoul be able to login successfully");
            Assert.IsTrue(isLogin);
        }

    }
}
