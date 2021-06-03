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
    public sealed class ProfilePageSteps
    {


        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private ProfilePage profilePage;
        


        public ProfilePageSteps()
        {
             driver = new ChromeDriver();
          //  driver = new InternetExplorerDriver();
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);
            
        }

        [AfterScenario]
        public void RunAftetEveryTest()
        {
            driver.Close();
        }


        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            loginPage.iAmLogedIn(null,null);
            Console.WriteLine("I am logged in");
        }


        [Given(@"I am at the Profile page")]
        public void GivenIAmAtTheProfilePage()
        {
            profilePage.IAmAtProfilePage();
            Console.WriteLine("I am at the Profile page");
        }

        [When(@"I click on profile")]
        public void WhenIClickOnProfile()
        {
            profilePage.IclickOnProfileName();
            Console.WriteLine("I click on profile");
        }


        [When(@"I enter new firstname (.*)")]
        public void WhenIEnterNewFirstname(string FirstName)
        {
            profilePage.EnterFirstName(FirstName);
            Console.WriteLine("I enter the new name");
        }

        [When(@"I enter new lastname (.*)")]
        public void WhenIEnterNewLastname(string LastName)
        {
            profilePage.EnterLastName(LastName);
            Console.WriteLine("I enter the new serName");
        }

        [When(@"I click the save button")]
        public void WhenIClickTheSaveButton()
        {
            profilePage.iClickTheSaveButton();
            Console.WriteLine("I click the save button");
        }

        [Then(@"Validate that profile  is added")]
        public void ThenValidateThatProfileIsAdded()
        {
            bool isEditted = profilePage.ValidateProfileIsEdited();
            Console.WriteLine("Validate that profile  is added");
            Assert.IsTrue(isEditted);
        }

    }
}
