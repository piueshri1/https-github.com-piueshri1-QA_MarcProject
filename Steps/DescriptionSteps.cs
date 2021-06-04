using Marc.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marc.Steps
{
    [Binding]
    public sealed class DescriptionSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private DescriptionPage descriptionPage;



        public DescriptionSteps()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            descriptionPage = new DescriptionPage(driver);

        }

        [AfterScenario]
        public void RunAftetEveryTest()
        {
            driver.Close();
        }

        [Given(@"I am login")]
        public void GivenIAmLogin()
        {
            loginPage.iAmLogedIn(null, null);
            Console.WriteLine("I am login");
        }

        [When(@"I am at description page")]
        public void WhenIAmAtDescriptionPage()
        {
           bool IsDescriptionPage = descriptionPage.iAmAtDescriptioPage();
            Console.WriteLine("I am at description page");
            Assert.IsTrue(IsDescriptionPage);
        }

        [When(@"I click on description icon")]
        public void WhenIClickOnDescriptionIcon()
        {
            descriptionPage.clickDescriptionIcon();
            Console.WriteLine("I click on description icon");
        }

        [When(@"I eneter (.*)")]
        public void WhenIEneter(string Description)
        {
            descriptionPage.addDescription(Description);
            Console.WriteLine("I eneter description =" + Description);
        }

        [When(@"I click  save button")]
        public void WhenIClickSaveButton()
        {
            descriptionPage.clickSaveButton();
            Console.WriteLine("I click  save button");
        }

        [Then(@"Validate that description was save")]
        public void ThenValidateThatDescriptionWasSave()
        {
            bool isSave = descriptionPage.validateDescription();
            Console.WriteLine("Validate that description was save");
            Assert.IsTrue(isSave);
        }


    }
}
