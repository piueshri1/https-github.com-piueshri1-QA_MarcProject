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
    public sealed class LanguagePageSteps
    {

        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private LanguagePage languagePage;


        public LanguagePageSteps()
        {
              driver = new ChromeDriver();
           // driver = new InternetExplorerDriver();
            loginPage = new LoginPage(driver);
            languagePage = new LanguagePage(driver);
        }

        [AfterScenario]
        public void RunAftetEveryTest()
        {
            driver.Close();
        }


        [Given(@"I at login")]
        public void GivenIAtLogin()
        {
            loginPage.iAmLogedIn(null, null);
            Console.WriteLine("I at login");
        }

        [When(@"I am at Language page")]
        public void WhenIAmAtLanguagePage()
        {
            bool isAtLanguage = languagePage.iAmATlanguagePage();
            Console.WriteLine("I am at Language page");
            Assert.IsTrue(isAtLanguage);
        }

        [When(@"I click the Language page")]
        public void WhenIClickTheLanguagePage()
        {
            languagePage.ClickTheLanguagePage();
            Console.WriteLine("I click the Language page");
        }

        [When(@"I click the add new Language button")]
        public void WhenIClickTheAddNewLanguageButton()
        {
            languagePage.clickTheAddNewLanguageButton();
            Console.WriteLine("I click the add new Language button");
        }


        [When(@"I enter  new (.*)")]
        public void WhenIEnterNew(string Language)
        {
            languagePage.iEnterTheNewLanguage(Language);
            Console.WriteLine("I enter the new Language");
        }


        //[When(@"I enter the new Language")]
        //public void WhenIEnterTheNewLanguage()
        //{
        //    languagePage.iEnterTheNewLanguage();
        //    Console.WriteLine("I enter the new Language");
        //}

        [When(@"I click on dropdown to select the new Language")]
        public void WhenIClickOnDropdownToSelectTheNewLanguage()
        {
            languagePage.clickOnDropdownToSelectTheNewLanguage();
            Console.WriteLine("I click on dropdown to select the new Language");
        }

        [When(@"I select new Language fron dropdown")]
        public void WhenISelectNewLanguageFronDropdown()
        {
            languagePage.selectNewLanguageFronDropdown();
            Console.WriteLine("I select new Language fron dropdown");
        }

        [Then(@"I click the add button")]
        public void ThenIClickTheAddButton()
        {
            languagePage.ClickTheAddButton();
            Console.WriteLine("I click the add button");
        }

        [When(@"I am at Language icons")]
        public void WhenIAmAtLanguageIcons()
        {
          bool languageIcon =  languagePage.iAmAtLanguageIcons();
            Console.WriteLine("I am at Language icons");
            Assert.IsTrue(languageIcon);
        }

        [When(@"I click the edit icon to update Language")]
        public void WhenIClickTheEditIconToUpdateLanguage()
        {
            languagePage.clickTheEditIconToUpdateLanguage();
            Console.WriteLine("I click the edit icon to update Language");
        }


        [When(@"I update new (.*)")]
        public void WhenIUpdateNew(string updateLanguage)
        {
            languagePage.updateTheNewLanguage(updateLanguage);
            Console.WriteLine("I update the new Language");
        }


        //[When(@"I update the new Language")]
        //public void WhenIUpdateTheNewLanguage()
        //{
        //    languagePage.updateTheNewLanguage();
        //    Console.WriteLine("I update the new Language");
        //}

        [When(@"I click on dropdown to update the new Language")]
        public void WhenIClickOnDropdownToUpdateTheNewLanguage()
        {
            languagePage.clickOnDropdownToUpdateTheNewLanguage();
            Console.WriteLine("I click on dropdown to update the new Language");
        }

        [When(@"I select to update  new Language fron dropdown")]
        public void WhenISelectToUpdateNewLanguageFronDropdown()
        {
            languagePage.selectToUpdateNewLanguageFronDropdown();
            Console.WriteLine("I select to update  new Language fron dropdown");
        }

        [Then(@"I click the update button")]
        public void ThenIClickTheUpdateButton()
        {
            languagePage.clickTheUpdateButton();
            Console.WriteLine("I click the update button");
        }


        [When(@"I click the delete icon to Language")]
        public void WhenIClickTheDeleteIconToLanguage()
        {
            languagePage.clickTheDeleteIconToLanguage();
            Console.WriteLine("I click the delete icon to Language");
        }

    }
}
