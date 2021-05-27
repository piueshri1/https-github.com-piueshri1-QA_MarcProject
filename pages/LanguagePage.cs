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
        //   private IWebElement validateLanguageUpdate => driver.FindElement(By.CssSelector("#account-profile-section"));
        //   private IWebElement validateLanguageDelete => driver.FindElement(By.CssSelector("#account-profile-section"));
        private IWebElement editLanguageIcon => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i"));

        public LanguagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddNewLanguage(IWebDriver driver)
            
        {
            /// language page......
            /// 

            // on click language
            clickLanguage.Click();


            // on click add new language
            addNewLanguage.Click();
            Thread.Sleep(1000);

            // add language
            addLanguage.SendKeys("Hindi,English");

            // dropdown for language 
            chooselanguage.Click();


            // select language level
            selectedlanguageLevel.Click();



            // save language
        //    IWebElement saveAddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
            saveAddLanguage.Click();
            Thread.Sleep(2000);




            // cancel language
            //IWebElement cancel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input:nth-child(2)"));
            //cancel.Click();





            // IWebElement clickUpdate = driver.FindElement(By.CssSelector(""));



        }

       public void UpdateLanguage(IWebDriver driver)
        {

            // edit language
        //    Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i",3);


       //     IWebElement editLaguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i"));
            editLaguage.Click();
            Thread.Sleep(1000);


            // edit language
        //    IWebElement saveEditLaguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));
            saveEditLaguage.Clear();
            saveEditLaguage.SendKeys("from india");
           Thread.Sleep(1000);

            // update language
       //     IWebElement clickToUpdateLaguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select"));
            clickToUpdateLaguage.Click();

            //    IWebElement selectLanguageToUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(2) > select > option:nth-child(5)"));
            //  selectLanguageToUpdate.Clear();
            selectLanguageToUpdate.Clear();
            selectLanguageToUpdate.Click();
            Thread.Sleep(1000);


       //     IWebElement clickUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
            clickUpdate.Click();
            Thread.Sleep(2000);


        }
        public void DeleteLanguage(IWebDriver driver)
        {

            // delet edited language
        //    Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i",2);


        //    IWebElement deleteLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i"));
            deleteLanguage.Click();
            Thread.Sleep(2000);



        }





        // method for  i am at language page  using selenium with BDD specflow..........






        // method for   click add new   language using selenium with BDD specflow...........




        // method for  add new   language  using selenium with BDD specflow...........



        // method for   click on dropdown to  chhose   language   using selenium with BDD specflow...........



        // method for   select  new   language from dropdown  using selenium with BDD specflow...........



        // method for   click add  language  using selenium with BDD specflow...........



        // method for  validate new   language added  using selenium with BDD specflow...........

        //  public bool validateLanguageIsAdded()
        //  {
        //     return validateLanguageAdded.Displayed;

        // }

        // method for   click edit icon to update language  using selenium with BDD specflow...........



        // method for update new   language using selenium with BDD specflow...........



        // method for click dropdown to update language using selenium with BDD specflow...........




        // method for update ne w language from dropdown language  using selenium with BDD specflow...........



        // method for   click to update new language  using selenium with BDD specflow...........



        // method for validate  language updated  using selenium with BDD specflow...........

        //   public bool validateLanguageIsUpdated()
        //  {
        //     return validateLanguageUpdate.Displayed;
        //  }


        // method for   click delete icon to delete language  using selenium with BDD specflow...........



        // method for validate language deleted using selenium with BDD specflow...........

     public bool iAmATlanguagePage()
        {
            return atLanguagePage.Displayed;

        }

        public void ClickTheLanguagePage()
        {
            // on click language
            clickLanguage.Click();
        }


    public void clickTheAddNewLanguageButton()
        {
            addNewLanguage.Click();
            Thread.Sleep(1000);
        }
        public void iEnterTheNewLanguage()
        {
            addLanguage.SendKeys("Hindi,English");
        }
        public void clickOnDropdownToSelectTheNewLanguage()
        {
            chooselanguage.Click();
        }

        public void selectNewLanguageFronDropdown()
        {
            selectedlanguageLevel.Click();
        }

        public void ClickTheAddButton()
        {
            saveAddLanguage.Click();
            Thread.Sleep(2000);
        }
         public bool iAmAtLanguageIcons()
        {
            return editLanguageIcon.Displayed;
        }

        public void clickTheEditIconToUpdateLanguage()
        {
            editLaguage.Click();
            Thread.Sleep(1000);
        }
        public void updateTheNewLanguage()
        {
            saveEditLaguage.Clear();
            saveEditLaguage.SendKeys("from india");
            Thread.Sleep(1000);
        }

     public void   clickOnDropdownToUpdateTheNewLanguage()
        {
            clickToUpdateLaguage.Click();
        }
        public void selectToUpdateNewLanguageFronDropdown()
        {
          //  selectLanguageToUpdate.Clear();
            selectLanguageToUpdate.Click();
            Thread.Sleep(1000);
        }

      public void clickTheUpdateButton()
        {
            clickUpdate.Click();
            Thread.Sleep(2000);
        }

        public void clickTheDeleteIconToLanguage()
        {
            deleteLanguage.Click();
            Thread.Sleep(2000);
        }

    }
}
