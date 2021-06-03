using Marc.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marc.utilities
{
    class CommonDriver
    {
        // init driver
        public  IWebDriver driver;



        [SetUp]
        public void Loginproject()
        {
            Console.WriteLine("Hello World!");
             driver = new ChromeDriver();
           // driver = new InternetExplorerDriver();

            // login object

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSteps(driver);

        }


        [TearDown]
        public void FinalSteps()
        {
            // driver close...
            driver.Close();

        }
    }
}
