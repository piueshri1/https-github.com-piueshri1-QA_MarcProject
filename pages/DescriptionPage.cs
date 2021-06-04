using Marc.utilities;
using OpenQA.Selenium;


namespace Marc.pages
{
    class DescriptionPage
       
    {
        private IWebDriver driver;
        private IWebElement desription => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
        private IWebElement inputDesription => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
        private IWebElement atDescriptionPage => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3"));
        private IWebElement valiidateInputDescription => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));
        private IWebElement saveDescription => driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));


         public DescriptionPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void  descriptonStes(IWebDriver driver)
        {
            Wait.ElementExist(driver,"CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 5);


            // description page...

            // on click desription
            desription.Click();

            // inputDesription 
            inputDesription.Clear();
            inputDesription.SendKeys("hi this is piue shri");


            // save description
            saveDescription.Click();
           
        }

        // I am at description page using selenium with BDD specflow......


        public bool iAmAtDescriptioPage()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3", 5);

            return atDescriptionPage.Displayed;
        }

        // I click the  description icon using selenium with BDD specflow......
       public void clickDescriptionIcon()
        {
            desription.Click();
        }


        // add description value through feature file using selenium with BDD specflow.....
        public void addDescription( string descriptionValuue)
        {
            inputDesription.Clear();
            inputDesription.SendKeys(descriptionValuue);
        }
        // save input description usnig selenium with BDD specflow......
        public void clickSaveButton()
        {
            saveDescription.Click();
        }

        //validate input description save or not usnig selenium with BDD specflow......
        public bool validateDescription()
        {
            return saveDescription.Displayed;
        }
    }
}
