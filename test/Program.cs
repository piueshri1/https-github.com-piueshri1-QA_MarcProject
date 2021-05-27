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
      //static void Main(string[] args)
      //{
           


            // home page object
           //omePage homepage = new HomePage();
          //homepage.navigatProfilePage(driver);

            // description object
          //DescriptionPage descriptionPage = new DescriptionPage();
           //escriptionPage.descriptonStes(driver);

            // language object
           //anguagePage languagePage = new LanguagePage();
           //anguagePage.languageSteps(driver);

            // skills object

           //killsPage skillsPage = new SkillsPage();
          //skillsPage.skillsSteps(driver);


            // object for profilePage..

            // ProfilePage profilePage = new ProfilePage();
            // profilePage.navigateDescriptionPage(driver);
            // profilePage.navigateDescriptionPage(driver);
            // profilePage.navigateSkillsPage(driver);


            
          
      //}
        

      //  [SetUp]
     //   public void Loginproject()
       //     {
         //   Console.WriteLine("Hello World!");
           // driver = new ChromeDriver();

            // login object

           // LoginPage loginPage = new LoginPage();
          //  loginPage.LoginSteps(driver);

       // }


        [Test]
        public void CreateLnguage()
        {

            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            //language object
            LanguagePage languagePage = new LanguagePage(driver);
            languagePage.AddNewLanguage(driver);

        }

        [Test]
        public void UpdateLanguage()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            //language object
            LanguagePage languagePage = new LanguagePage(driver);
            languagePage.UpdateLanguage(driver);

        }
        [Test]
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

