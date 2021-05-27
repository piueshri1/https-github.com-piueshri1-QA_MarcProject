using Marc.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class HomePage
    {
        private IWebDriver driver;

       private IWebElement dropDown => driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span"));
        private IWebElement goToProfilePage => driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span > div > a:nth-child(1)"));

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigatProfilePage()
        {

         //  Wait.ElementToBeClickable(driver, "CssSelector", "#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span > div > a:nth-child(1)",1);

          //  IWebElement dropDown = driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span"));
            
      //      dropDown.Click();
         //  Thread.Sleep(1000);
            

       //     IWebElement goToProfilePage = driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span > div > a:nth-child(1)"));
           goToProfilePage.Click();
           Thread.Sleep(2000);


        }

       
    }
}
