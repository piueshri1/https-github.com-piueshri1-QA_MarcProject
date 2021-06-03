using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class LanguagePage
    {
        private IWebDriver driver;
        
        private IWebElement clickLanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
        private IWebElement addNewLanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
        private IWebElement addLanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
        private IWebElement chooselanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(1)"));
        private IWebElement selectedlanguageLevel => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(4)"));
        private IWebElement saveAddLanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
        private IWebElement editLaguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i"));
        private IWebElement saveEditLaguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));
        private IWebElement clickToUpdateLaguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select"));
        private IWebElement selectLanguageToUpdate => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select > option:nth-child(5)"));
        private IWebElement clickUpdate => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
        private IWebElement deleteLanguage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i"));
       private IWebElement atLanguagePage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)"));
        private IWebElement editLanguageIcon => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i"));

        public LanguagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddNewLanguage(IWebDriver driver)
            
        {
            /// language page......
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active", 5);


            // on click language
            clickLanguage.Click();


            // on click add new language
            addNewLanguage.Click();
     

            // add language
            addLanguage.SendKeys("Hindi,English");

            // dropdown for language 
            chooselanguage.Click();

            // select language level
            selectedlanguageLevel.Click();

            // save language
            saveAddLanguage.Click();
          



        }

       public void UpdateLanguage(IWebDriver driver)
        {

           
          Wait.ElementExist(driver, "CssSelector","#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i",5);

            // Update new  language

            editLaguage.Click();


            //  clear old and update new language
            saveEditLaguage.Clear();
            saveEditLaguage.SendKeys("from india");

            // dropdown to  update language
          
            clickToUpdateLaguage.Click();

       // select language to update......

            selectLanguageToUpdate.Click();
          


            clickUpdate.Click();
         


        }
        public void DeleteLanguage(IWebDriver driver)
        {

            // delet edited language
        Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i", 5);


            deleteLanguage.Click();
          



        }





        // method for  i am at language page  using selenium with BDD specflow..........

        public bool iAmATlanguagePage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)", 5);
            return atLanguagePage.Displayed;

        }

         public void ClickTheLanguagePage()
        {
            // on click language
            clickLanguage.Click();
        }


        // method for   click add new   language using selenium with BDD specflow...........
         public void clickTheAddNewLanguageButton()
        {
            addNewLanguage.Click();
          
        }



        // method for  add new   language  using selenium with BDD specflow...........
          public void iEnterTheNewLanguage(string languageValue)
        {
            addLanguage.SendKeys(languageValue);
        }


        // method for   click on dropdown to  chhose   language   using selenium with BDD specflow...........
          public void clickOnDropdownToSelectTheNewLanguage()
        {
            chooselanguage.Click();
        }

      

        // method for   select  new   language from dropdown  using selenium with BDD specflow...........
         public void selectNewLanguageFronDropdown()
        {
            selectedlanguageLevel.Click();
        }


        // method for   click add  language  using selenium with BDD specflow...........
          public void ClickTheAddButton()
        {
            saveAddLanguage.Click();
          
        }


        // method for  validate i am at  language page  using selenium with BDD specflow...........
        public bool iAmAtLanguageIcons()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i", 5);
            return editLanguageIcon.Displayed;
        }
       

        // method for   click edit icon to update language  using selenium with BDD specflow...........
         public void clickTheEditIconToUpdateLanguage()
        {
            editLaguage.Click();
          
        }


        // method for update new   language using selenium with BDD specflow...........
          public void updateTheNewLanguage(string updateLanguage)
        {
            saveEditLaguage.Clear();
            saveEditLaguage.SendKeys(updateLanguage);
          
        }


        // method for click dropdown to update language using selenium with BDD specflow...........
        public void   clickOnDropdownToUpdateTheNewLanguage()
        {
            clickToUpdateLaguage.Click();
        }



        // method for update ne w language from dropdown language  using selenium with BDD specflow...........
         public void selectToUpdateNewLanguageFronDropdown()
        {
          //  selectLanguageToUpdate.Clear();
            selectLanguageToUpdate.Click();
          
        }


        // method for   click to update new language  using selenium with BDD specflow...........
        public void clickTheUpdateButton()
        {
            clickUpdate.Click();
           
        }


        // method for validate language deleted using selenium with BDD specflow...........
         public void clickTheDeleteIconToLanguage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i", 5);

            deleteLanguage.Click();
           
        }
     

       


      

       

    }
}
