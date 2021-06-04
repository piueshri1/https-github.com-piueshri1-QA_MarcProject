using Marc.utilities;
using OpenQA.Selenium;


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
        //private IWebElement add => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
       // private IWebElement cancel => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input:nth-child(2)"));
      //  private IWebElement addNewSkill => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));


        public SkillsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddNewSkills(IWebDriver driver)
        {
            // skills page.....

            // on click skills
             Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)", 5);

            clickSkills.Click();

            
            // add skills
            addNewSkills.Click();
         
            // edit new sckills
            editNewSkills.SendKeys("softwareTesting");
           
            // dropdon fo select skills
            cselectSkillsDropDown.Click();

            // dropdon fo selected skills
            selectedSkills.Click();
       
            // add selected skills

            addSelectedSkills.Click();
    
        }

        public void UpdateSkills()
        {
            //upadate add skills

               Wait.ElementExist(driver,"CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i",5);

            // upadate skills

            clickUpdateSkills.Click();
           


            updateNewSkills.Clear();
            updateNewSkills.SendKeys("specflow");
          


            // dropdown for update new skills
            dropDownForUpdateSkills.Click();

            // update skills

            updateSkills.Clear();
            updateSkills.Click();
          


            // clock upadate skills button

            clickUpdateSkillsButton.Click();
          
        }
        public void DeleteSkills()
        {
            // delete edited skills


              Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2) > i",5);

            deleteEditedSkills.Click();
          


        }



        

      // method for  i am at skills page  using selenium with BDD specflow..........

        public bool iAmAtSkillsPage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)", 5);

            return iAMatSkillPage.Displayed;
        }


        public void iClickTheSkillsPage()
        {
            clickSkills.Click();
           

        }


       // method for   click add new   skills using selenium with BDD specflow...........
         public void clickAddNewSkillsButton()
        {
            addNewSkills.Click();
           
        }


       // method for  add new   skills  using selenium with BDD specflow...........
        public void enetrNewSkills(string skillsValue)
        {
            editNewSkills.SendKeys(skillsValue);
           
        }



      // method for   click on dropdown to  chhose   skills   using selenium with BDD specflow...........
         public void iClickOnDropdownToSelectTheNewSkills()
        {
            cselectSkillsDropDown.Click();
        }


      // method for   select  new   skills from dropdown  using selenium with BDD specflow...........
        public void WhenISelectNewSkillsFronDropdown()
        {
            selectedSkills.Click();
           
        }


      // method for   click add  skills  using selenium with BDD specflow...........
        public void ClickTheAddButton()
        {
            addSelectedSkills.Click();
          

        }


     // method for   click edit icon to update skills  using selenium with BDD specflow...........

      public void clickOnEditIconToUpdate()
  
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i", 5);

            clickUpdateSkills.Click();
           
        }


       // method for update new   skills using selenium with BDD specflow...........
        public void iUpdateNewSkills(string updateSkillsValue)
        {
            updateNewSkills.Clear();
            updateNewSkills.SendKeys(updateSkillsValue);
        }


        // method for click dropdown to update skills using selenium with BDD specflow...........
        public void clickOnDropdownToUpdateTheNewSkills()
        {
            dropDownForUpdateSkills.Click();
        }


       // method for update ne w skills from dropdown skills  using selenium with BDD specflow...........
        public void selectToUpdateNewSkillsFronDropdown()
        {
           // updateSkills.Clear();
            updateSkills.Click();
          
        }


        // method for   click to update new skills  using selenium with BDD specflow...........
        public void clickToUpdateSkillsButton()
        {
            clickUpdateSkillsButton.Click();
          
        }

       // method for validate i am at skills  icons  using selenium with BDD specflow...........
        public bool atSkillsIcon()
        {
            return iAmAtSkillsIcons.Displayed;
        }

        // method for   click delete icon to delete skills  using selenium with BDD specflow...........

        public void clickTheDeleteIconToSkills()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2) > i", 5);

            deleteEditedSkills.Click();
          
        }

      


    }


}
