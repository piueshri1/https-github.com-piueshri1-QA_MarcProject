using Marc.utilities;
using OpenQA.Selenium;
using System;

namespace Marc.pages
{
    class ProfilePage
    {

        private IWebDriver driver;
        private IWebElement OnClickProfileName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i"));
        private IWebElement EditFirstName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)"));
        private IWebElement EditLastName => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(4)"));
        private IWebElement SaveEdittedProfile => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div:nth-child(2) > button"));
        private IWebElement ValidateProfileSave => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title"));
        private IWebElement ClickPofile => driver.FindElement(By.CssSelector("#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)"));
        private IWebElement Availability => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i"));
        private IWebElement SelecteAvailabilityTime => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select > option:nth-child(3)"));
        private IWebElement WorkinHour => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i"));
        private IWebElement DwopDownForWorkingHours => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select"));
        private IWebElement SelectedWorkinHours => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span"));
        private IWebElement  EarnTaget => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i"));
        private IWebElement AvailabilityType => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > select"));
      //  private IWebElement AvailabilityTymeCancel => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i"));
        private IWebElement AvailabilityTarget => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select"));
        private IWebElement AvailabilityToEarn => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(4)"));
        private IWebElement AvailTimeAdd => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span"));
        private IWebElement HoursTimeAdded => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span"));
        private IWebElement EarnTargetAdded => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span"));



        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EditProfile(IWebDriver driver)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title > i", 5);
            // click on profile name.....
            OnClickProfileName.Click();
          


            // enter first name......
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)", 2);
            EditFirstName.Clear();
            EditFirstName.SendKeys("piue@");

            // enter last name.......
            EditLastName.Clear();
            EditLastName.SendKeys("shri@");

            // on click save button......
            SaveEdittedProfile.Click();
      

            // validate profile is save.......
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title",5);
            if (ValidateProfileSave.Text == "Piue Shri")
            {
                Console.WriteLine(" profile edded successfully ");
            }
            else
            {
                Console.WriteLine(" profile not edded successfully ");

            }

            // select availability time....
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i", 5);
            Availability.Click();
            AvailabilityType.Click();
             
            SelecteAvailabilityTime.Click();



            // select working hours.......
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i", 5);
            WorkinHour.Click();
            DwopDownForWorkingHours.Click();
          
            SelectedWorkinHours.Click();



            // select earnig target.....
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i", 2);
            EarnTaget.Click();
            AvailabilityTarget.Click();
          
            AvailabilityToEarn.Click();
         

        }


        // I am at profile page .......
        public void IAmAtProfilePage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)", 5);
            ClickPofile.Click();
           
        }

        // method for click on profile name using selenium with BDD specflow .......
        public void IclickOnProfileName()
        {
            OnClickProfileName.Click();
           
        }

        // method for enter profile first name using selenium with BDD specflow .......
        public void EnterFirstName(string FirstNmaeValue)
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.content.active > div > div.field > input[type=text]:nth-child(2)", 5);

            // enter first name......
            EditFirstName.Clear();
            EditFirstName.SendKeys(FirstNmaeValue);

        }

        // method for enter profile last name using selenium with BDD specflow .......
        public void EnterLastName(string LastNameValue)
        {
            EditLastName.Clear();
            EditLastName.SendKeys(LastNameValue);

        }

        // method for save edited profile name using selenium with BDD specflow .......
        public void IClickTheSaveButton()
        {
            // on click save button......
            SaveEdittedProfile.Click();
          

        }


        public void IClickOnAvailabilityIcon()
        {
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span > i", 5);

            Availability.Click();

        }

        public void IClickOnDropdown()
        {
            AvailabilityType.Click();
        }

        public void ISelectAvailabilityFromDropdown()
        {
            SelecteAvailabilityTime.Click();
        }

       public bool ValidateThatAvailabilityAdded()
        {
            return AvailTimeAdd.Displayed;
        }

        public void IClickOnHoursIcon()
        {
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > i", 5);

            WorkinHour.Click();
        }

        public void IClickOnHoursDropdown()
        {
            DwopDownForWorkingHours.Click();

            
        }
        public void ISelectHoursFromDropdown()
        {
            SelectedWorkinHours.Click();
        }

        public bool ValidateThatHoursAdded()
        {
            return HoursTimeAdded.Displayed;
        }

        public void IClickOnEarnTargetIcon()
        {
            Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i", 2);

            EarnTaget.Click();
        }

       public void IClickOnEarnDropdown()
        {
            AvailabilityTarget.Click();

           
        }
        public void ISelectEarnTargetFromDropdown()
        {
            AvailabilityToEarn.Click();
        }

        public bool ValidateThatEarnTargetAdded()
        {
            return EarnTargetAdded.Displayed;
        }

     
        // method for validate profile first name and last name added successfully using selenium with BDD specflow .......
        public bool ValidateProfileIsEdited()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div:nth-child(2) > div > div > div.title", 5);

            return ValidateProfileSave.Displayed;
        }
      
    }
}
