using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class SkillsPage
    {

        private IWebDriver driver;
        private IWebElement iAMatSkillPage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
        private IWebElement clickSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
        private IWebElement addNewSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));

  
        private IWebElement editNewSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
        private IWebElement cselectSkillsDropDown => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(1)"));
        private IWebElement selectedSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(2)"));
        private IWebElement addSelectedSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
        private IWebElement clickUpdateSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i"));
        private IWebElement updateNewSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
        private IWebElement dropDownForUpdateSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
        private IWebElement updateSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select > option:nth-child(4)"));
        private IWebElement clickUpdateSkillsButton => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
        private IWebElement deleteEditedSkills => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2) > i"));
        private IWebElement iAmAtSkillsIcons => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i"));
        private IWebElement validateSkillsUpdated => driver.FindElement(By.CssSelector("#account-profile-section"));
        private IWebElement validateSkillsDeleted => driver.FindElement(By.CssSelector("#account-profile-section"));


        public SkillsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddNewSkills(IWebDriver driver)
        {
            // skills page.....

            // on click skills
            //   Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)",2);

            clickSkills.Click();


            // add skills
            addNewSkills.Click();
            Thread.Sleep(1000);


            // edit new sckills
            editNewSkills.SendKeys("softwareTesting");
            //Thread.Sleep(1000);



            // dropdon fo select skills
            cselectSkillsDropDown.Click();

            // dropdon fo selected skills
            selectedSkills.Click();
            Thread.Sleep(1000);

            // add selected skills

            addSelectedSkills.Click();
            Thread.Sleep(1000);





        }

        public void UpdateSkills()
        {
            //upadate add skills

            //   Wait.ElementToBeClickable(driver,"CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i",2);

            // upadate skills

            clickUpdateSkills.Click();
            Thread.Sleep(1000);


            updateNewSkills.Clear();
            updateNewSkills.SendKeys("specflow");
            //    Thread.Sleep(1000);


            // dropdown for update new skills
            dropDownForUpdateSkills.Click();

            // update skills

            updateSkills.Clear();
            updateSkills.Click();
            Thread.Sleep(1000);


            // clock upadate skills button

            clickUpdateSkillsButton.Click();
            Thread.Sleep(2000);
        }
        public void DeleteSkills()
        {
            // delete edited skills


            //  Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2) > i",2);

            deleteEditedSkills.Click();
            Thread.Sleep(1000);


        }



        // method for  i am at skills page  using selenium with BDD specflow..........
        // method for   click add new   skills using selenium with BDD specflow...........
        // method for  add new   skills  using selenium with BDD specflow...........
        // method for   click on dropdown to  chhose   skills   using selenium with BDD specflow...........
        // method for   select  new   skills from dropdown  using selenium with BDD specflow...........
        // method for   click add  skills  using selenium with BDD specflow...........
        // method for  validate new   skills added  using selenium with BDD specflow..........
        // method for   click edit icon to update skills  using selenium with BDD specflow...........
        // method for update new   skills using selenium with BDD specflow...........
        // method for click dropdown to update skills using selenium with BDD specflow...........
        // method for update ne w skills from dropdown skills  using selenium with BDD specflow...........
        // method for   click to update new skills  using selenium with BDD specflow...........
        // method for validate  skills updated  using selenium with BDD specflow...........

        // method for   click delete icon to delete skills  using selenium with BDD specflow...........

        // method for validate skills deleted using selenium with BDD specflow...........


        public bool iAmAtSkillsPage()
        {
            return iAMatSkillPage.Displayed;
        }

        public void iClickTheSkillsPage()
        {
            clickSkills.Click();
            Thread.Sleep(1000);

        }

        public void clickAddNewSkillsButton()
        {
            addNewSkills.Click();
            Thread.Sleep(1000);
        }

        public void enetrNewSkills()
        {
            editNewSkills.SendKeys("softwareTesting");
            //Thread.Sleep(1000);
        }


        public void iClickOnDropdownToSelectTheNewSkills()
        {
            cselectSkillsDropDown.Click();
        }

        public void WhenISelectNewSkillsFronDropdown()
        {
            selectedSkills.Click();
            Thread.Sleep(1000);
        }


        public void ClickTheAddButton()
        {
            addSelectedSkills.Click();
            Thread.Sleep(2000);

        }

        public void clickOnEditIconToUpdate()
        {
            clickUpdateSkills.Click();
            Thread.Sleep(2000);
        }

        public void iUpdateNewSkills()
        {
           // updateNewSkills.Clear();
            updateNewSkills.SendKeys("specflow");
        }

        public void clickOnDropdownToUpdateTheNewSkills()
        {
            dropDownForUpdateSkills.Click();
        }

        public void selectToUpdateNewSkillsFronDropdown()
        {
           // updateSkills.Clear();
            updateSkills.Click();
            Thread.Sleep(1000);
        }

        public void clickToUpdateSkillsButton()
        {
            clickUpdateSkillsButton.Click();
            Thread.Sleep(2000);
        }
        public bool atSkillsIcon()
        {
            return iAmAtSkillsIcons.Displayed;
        }



        public void clickTheDeleteIconToSkills()
        {
            deleteEditedSkills.Click();
            Thread.Sleep(1000);
        }


    }


}
