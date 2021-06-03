using Marc.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class ProfilePage
    {

        private IWebDriver driver;
        private IWebElement onClickProfileName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i"));
        private IWebElement editFirstName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)"));
        private IWebElement editLastName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(4)"));
        private IWebElement saveEdittedProfile => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button"));
        private IWebElement validateProfileSave => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title"));
        private IWebElement clickPofile => driver.FindElement(By.CssSelector("#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)"));
        private IWebElement availability => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i"));
        private IWebElement selecteAvailabilityTime => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select > option:nth-child(3)"));
        private IWebElement workinHour => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i"));
        private IWebElement dwopDownForWorkingHours => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select"));
        private IWebElement selectedWorkinHours => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span"));
        private IWebElement  earnTaget => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i"));
        private IWebElement availabilityType => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select"));
        private IWebElement availabilityTymeCancel => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i"));
        private IWebElement availabilityTarget => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select"));
        private IWebElement availabilityToEarn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(4)"));
       
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EditProfile(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i", 5);
            // click on profile name.....
            onClickProfileName.Click();
          


            // enter first name......
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)", 2);
            editFirstName.Clear();
            editFirstName.SendKeys("piue@");

            // enter last name.......
            editLastName.Clear();
            editLastName.SendKeys("shri@");

            // on click save button......
            saveEdittedProfile.Click();
      

            // validate profile is save.......
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title", 8);
            if (validateProfileSave.Text == "Piue Shri")
            {
                Console.WriteLine(" profile edded successfully ");
            }
            else
            {
                Console.WriteLine(" profile not edded successfully ");

            }

            // select availability time....
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i", 2);
            availability.Click();
            availabilityType.Click();
             
            selecteAvailabilityTime.Click();



            // select working hours.......
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i", 2);
            workinHour.Click();
            dwopDownForWorkingHours.Click();
          
            selectedWorkinHours.Click();



            // select earnig target.....
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i", 2);
            earnTaget.Click();
            availabilityTarget.Click();
          
            availabilityToEarn.Click();
         

        }


        // I am at profile page .......
        public void IAmAtProfilePage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)", 5);
            clickPofile.Click();
           
        }

        // method for click on profile name using selenium with BDD specflow .......
        public void IclickOnProfileName()
        {
            onClickProfileName.Click();
           
        }

        // method for enter profile first name using selenium with BDD specflow .......
        public void EnterFirstName(string FirstNmaeValue)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)", 5);

            // enter first name......
            editFirstName.Clear();
            editFirstName.SendKeys(FirstNmaeValue);

        }

        // method for enter profile last name using selenium with BDD specflow .......
        public void EnterLastName(string LastNameValue)
        {
            editLastName.Clear();
            editLastName.SendKeys(LastNameValue);

        }

        // method for save edited profile name using selenium with BDD specflow .......
        public void iClickTheSaveButton()
        {
            // on click save button......
            saveEdittedProfile.Click();
          

        }


        //// method for enter profile  first name and last name using selenium with BDD specflow .......
        //public void enterFirstNameAndLastName(string FirstNameValue,string LastNameValue)
        //{
        //    editFirstName.SendKeys(FirstNameValue);
        //    editLastName.SendKeys(LastNameValue);

        //}


        // method for validate profile first name and last name added successfully using selenium with BDD specflow .......
        public bool ValidateProfileIsEdited()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title", 5);

            return validateProfileSave.Displayed;
        }
      
    }
}
