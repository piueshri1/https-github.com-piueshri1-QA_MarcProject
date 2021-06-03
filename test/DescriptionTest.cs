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
    class DescriptionTest : CommonDriver
    {
        [Test]
        public void InputDescription()
        {
            // home page object
            HomePage homepage = new HomePage(driver);
            homepage.NavigatProfilePage();

            // profile page object
            DescriptionPage descriptionPage = new DescriptionPage(driver);
            descriptionPage.descriptonStes(driver);

        }
    }
}
