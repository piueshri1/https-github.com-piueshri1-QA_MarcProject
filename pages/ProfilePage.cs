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
        
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void editProfile(IWebDriver driver)
        {
            // click on profile name.....
            onClickProfileName.Click();
            Thread.Sleep(1000);


            // enter first name......
            editFirstName.Clear();
            editFirstName.SendKeys("piue@");

            // enter last name.......
            editLastName.Clear();
            editLastName.SendKeys("shri@");

            // on click save button......
            saveEdittedProfile.Click();
            Thread.Sleep(1000);

            // validate profile is save.......
            if (validateProfileSave.Text == "Piue Shri")
            {
                Console.WriteLine(" profile edded successfully ");
            }
            else
            {
                Console.WriteLine(" profile not edded successfully ");

            }


        }


        // I am at profile page .......
        public void iAmAtProfilePage()
        {
            clickPofile.Click();
            Thread.Sleep(1000);
        }

        // method for click on profile name using selenium with BDD specflow .......
        public void iclickOnProfileName()
        {
            onClickProfileName.Click();
            Thread.Sleep(1000);
        }

        // method for enter profile first name using selenium with BDD specflow .......
        public void enterFirstName()
        {
            // enter first name......
            editFirstName.Clear();
            editFirstName.SendKeys("piue@");
            Thread.Sleep(500);
        }

        // method for enter profile last name using selenium with BDD specflow .......
        public void enterLastName()
        {
            editLastName.Clear();
            editLastName.SendKeys("shri@");
            Thread.Sleep(500);
        }

        // method for save edited profile name using selenium with BDD specflow .......
        public void iClickTheSaveButton()
        {
            // on click save button......
            saveEdittedProfile.Click();
            Thread.Sleep(2000);

        }


        // method for validate profile first name and last name added successfully using selenium with BDD specflow .......
        public bool validateProfileIsEdited()
        {

            return validateProfileSave.Displayed;
        }
          // validate profile is save.......
          //  if (validateProfileSave.Text == "Piue Shri")
         // .//  {
            //    Console.WriteLine(" profile edded successfully");
             //   return true;
          //  }
         //   else
          //  {
             //   Console.WriteLine(" profile not edded successfully");
            //    return false;

           // }
        
    }
}
