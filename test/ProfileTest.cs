using Marc.pages;
using Marc.utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marc.test
{
    [TestFixture]
    [Parallelizable]
    class ProfileTest : CommonDriver
    {
        [Test]
        public void editProfile()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            // profile page object
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.editProfile(driver);

        }
    }
}
