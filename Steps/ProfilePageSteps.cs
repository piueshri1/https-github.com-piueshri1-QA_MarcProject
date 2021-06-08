using Marc.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
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
            loginPage.IAmLogedIn(null,null);
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
            profilePage.IClickTheSaveButton();
            Console.WriteLine("I click the save button");
        }

        [Then(@"Validate that profile  is added")]
        public void ThenValidateThatProfileIsAdded()
        {
            bool isEditted = profilePage.ValidateProfileIsEdited();
            Console.WriteLine("Validate that profile  is added");
            Assert.IsTrue(isEditted);
        }

        [When(@"I click on availability icon")]
        public void WhenIClickOnAvailabilityIcon()
        {
            profilePage.IClickOnAvailabilityIcon();
            Console.WriteLine("I click on availability icon");
        }

        [When(@"I click on dropdown")]
        public void WhenIClickOnDropdown()
        {
            profilePage.IClickOnDropdown();
            Console.WriteLine("I click on dropdown");
        }

        [When(@"I select availability from dropdown")]
        public void WhenISelectAvailabilityFromDropdown()
        {
            profilePage.ISelectAvailabilityFromDropdown();
            Console.WriteLine("I select availability from dropdown");
        }

        [Then(@"Validate that availability added")]
        public void ThenValidateThatAvailabilityAdded()
        {
          bool isAvailAdd =  profilePage.ValidateThatAvailabilityAdded();
            Console.WriteLine("Validate that availability added");
            Assert.IsTrue(isAvailAdd);
        }

        [When(@"I click on hours icon")]
        public void WhenIClickOnHoursIcon()
        {
            profilePage.IClickOnHoursIcon();
            Console.WriteLine("I click on hours icon");
        }


        [When(@"I click on hours dropdown")]
        public void WhenIClickOnHoursDropdown()
        {
            profilePage.IClickOnHoursDropdown();
            Console.WriteLine("I click on hours dropdown");
        }

     

        [When(@"I select hours from dropdown")]
        public void WhenISelectHoursFromDropdown()
        {
            profilePage.ISelectHoursFromDropdown();
            Console.WriteLine("I select hours from dropdown");
        }

        [Then(@"Validate that hours added")]
        public void ThenValidateThatHoursAdded()
        {
            bool isHoursAdded = profilePage.ValidateThatHoursAdded();
            Console.WriteLine("Validate that hours added");
            Assert.IsTrue(isHoursAdded);
        }

        [When(@"I click on earn target icon")]
        public void WhenIClickOnEarnTargetIcon()
        {
            profilePage.IClickOnEarnTargetIcon();
            Console.WriteLine("I click on earn target icon");
        }


        [When(@"I click on earn dropdown")]
        public void WhenIClickOnEarnDropdown()
        {
            profilePage.IClickOnEarnDropdown();
            Console.WriteLine("I click on earn dropdown");
        }


        [When(@"I select earn target from dropdown")]
        public void WhenISelectEarnTargetFromDropdown()
        {
            profilePage.ISelectEarnTargetFromDropdown();
            Console.WriteLine("I select earn target from dropdown");
        }

        [Then(@"Validate that earn target added")]
        public void ThenValidateThatEarnTargetAdded()
        {
            bool isEarnAdd = profilePage.ValidateThatEarnTargetAdded();
            Console.WriteLine("Validate that earn target added");
            Assert.IsTrue(isEarnAdd);
        }


    }
}
