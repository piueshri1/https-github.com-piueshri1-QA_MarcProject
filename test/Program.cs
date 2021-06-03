using Marc.pages;
using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Marc
{
   [TestFixture]
   [Parallelizable]
    class Program : CommonDriver
    {
   

        [Test,Order(0)]
        public void CreateLnguage()
        {

            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            //language object
            LanguagePage languagePage = new LanguagePage(driver);
            languagePage.AddNewLanguage(driver);

        }

        [Test,Order(1)]
        public void UpdateLanguage()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            //language object
            LanguagePage languagePage = new LanguagePage(driver);
            languagePage.UpdateLanguage(driver);

        }
        [Test,Order(2)]
        public void DeleteLanguage()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            //language object
            LanguagePage languagePage = new LanguagePage(driver);
            languagePage.DeleteLanguage(driver);


        }
     


    }
}

