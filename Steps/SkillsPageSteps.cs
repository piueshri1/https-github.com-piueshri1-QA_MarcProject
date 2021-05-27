using Marc.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Marc.Steps
{
    [Binding]
    public sealed class SkillsPageSteps
    {

        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private SkillsPage skillsPage;



        public SkillsPageSteps()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            skillsPage = new SkillsPage(driver);

        }

        [AfterScenario]
        public void RunAftetEveryTest()
        {
            driver.Close();
        }

        [Given(@"I login")]
        public void GivenILogin()
        {
            loginPage.iAmLogedIn(null, null);
            Console.WriteLine("I login");
        }

        [When(@"I am at skill page")]
        public void WhenIAmAtSkillPage()
        {
           bool atSkillspage = skillsPage.iAmAtSkillsPage();
            Console.WriteLine("I am at skill page");
            Assert.IsTrue(atSkillspage);
        }

        [When(@"I click the skills page")]
        public void WhenIClickTheSkillsPage()
        {
            skillsPage.iClickTheSkillsPage();
            Console.WriteLine("I click the skills page");
        }

        [When(@"I click the add new skills button")]
        public void WhenIClickTheAddNewSkillsButton()
        {
            skillsPage.clickAddNewSkillsButton();
            Console.WriteLine("I click the add new skills button");
        }

        [When(@"I enter the new skills")]
        public void WhenIEnterTheNewSkills()
        {
            skillsPage.enetrNewSkills();
            Console.WriteLine("I enter the new skills");
        }

        [When(@"I click on dropdown to select the new skills")]
        public void WhenIClickOnDropdownToSelectTheNewSkills()
        {
            skillsPage.iClickOnDropdownToSelectTheNewSkills();
            Console.WriteLine("I click on dropdown to select the new skills");
        }

        [When(@"I select new skills fron dropdown")]
        public void WhenISelectNewSkillsFronDropdown()
        {
            skillsPage.WhenISelectNewSkillsFronDropdown();
            Console.WriteLine("I select new skills fron dropdown");
        }

        [When(@"I click the add button")]
        public void WhenIClickTheAddButton()
        {
            skillsPage.ClickTheAddButton();
            Console.WriteLine("I click the add button");
        }

        [When(@"I am at skills icons")]
        public void WhenIAmAtSkillsIcons()
        {
          bool stSkillsIcons =  skillsPage.atSkillsIcon();
            Assert.IsTrue(stSkillsIcons);
            
        }


        [When(@"I click the edit icon to update skills")]
        public void WhenIClickTheEditIconToUpdateSkills()
        {
            skillsPage.clickOnEditIconToUpdate();
            Console.WriteLine("I click the edit icon to update skills");
        }

        [When(@"I update the new skills")]
        public void WhenIUpdateTheNewSkills()
        {
            skillsPage.iUpdateNewSkills();
            Console.WriteLine("I update the new skills");
        }

        [When(@"I click on dropdown to update the new skills")]
        public void WhenIClickOnDropdownToUpdateTheNewSkills()
        {
            skillsPage.clickOnDropdownToUpdateTheNewSkills();
            Console.WriteLine("I click on dropdown to update the new skills");
        }

        [When(@"I select to update  new skills fron dropdown")]
        public void WhenISelectToUpdateNewSkillsFronDropdown()
        {
            skillsPage.selectToUpdateNewSkillsFronDropdown();
            Console.WriteLine("I select to update  new skills fron dropdown");
        }

        [When(@"I click the update button")]
        public void WhenIClickTheUpdateButton()
        {
            skillsPage.clickToUpdateSkillsButton();
            Console.WriteLine("I click the update button");
        }

        [When(@"I click the delete icon to skills")]
        public void WhenIClickTheDeleteIconToSkills()
        {
            skillsPage.clickTheDeleteIconToSkills();
            Console.WriteLine("I click the delete icon to skills");
        }

    }
}
