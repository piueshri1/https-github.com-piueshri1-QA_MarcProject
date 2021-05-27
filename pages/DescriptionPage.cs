using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class DescriptionPage
    {
        public void  descriptonStes(IWebDriver driver)
        {
            // description page...

            // on click desription
            IWebElement desription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
           desription.Click();

            // inputDesription 
            IWebElement inputDesription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
            inputDesription.Clear();
            inputDesription.SendKeys("hi this is piue shri");


            // save description
            IWebElement saveDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));
            saveDescription.Click();
            Thread.Sleep(2000);
        }
    }
}
