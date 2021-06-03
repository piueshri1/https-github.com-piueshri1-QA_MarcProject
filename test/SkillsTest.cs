using Marc.pages;
using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marc.test
{
    [TestFixture]
    [Parallelizable]
    class SkillsTest : CommonDriver
    {
   
        [Test,Order(0)]
        public void CreateSkills()
        {

            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            // skills object

            SkillsPage skillsPage = new SkillsPage(driver);
            skillsPage.AddNewSkills(driver);

        }

        [Test,Order(1)]
        public void UpdateSkills()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

           
            SkillsPage skillsPage = new SkillsPage(driver);
            skillsPage.AddNewSkills(driver);
        }
        [Test,Order(2)]
        public void DeleteSkills()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            SkillsPage skillsPage = new SkillsPage(driver);
            skillsPage.AddNewSkills(driver);


        }
     
    }
}
