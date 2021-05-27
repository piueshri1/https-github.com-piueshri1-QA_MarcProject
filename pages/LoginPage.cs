using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Marc.pages
{
    class LoginPage
    {
        private IWebDriver driver;
        private IWebElement signInLink => driver.FindElement(By.CssSelector("#home > div > div > div.ui.secondary.menu.inverted > div > a"));
        private IWebElement emailId => driver.FindElement(By.XPath(" / html / body / div[2] / div / div / div[1] / div / div[1] / input"));
        private IWebElement password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement marcLogo => driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > a"));

        private IWebElement loginError => driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active"));






        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // method for login with selenium using NUnit...........

        public void LoginSteps(IWebDriver driver)
        {
            // Lunch Marc portal


            driver.Navigate().GoToUrl("http://localhost:5000/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(500);

            try
            {
              //  Wait.ElementExist(driver, "XPath", " #home > div > div > div.ui.secondary.menu.inverted > div > a", 5);
                // click on signIn link
           
                signInLink.Click();
               

                // identify emailId 
          
                emailId.SendKeys("piueshri24.1992@gmail.com");


                // identify password
             
                password.SendKeys("123456");


                // login button
                loginButton.Click();
                Thread.Sleep(2000);
              
            }
            catch(Exception msg)
            {
                Assert.Fail("test failed at login Page", msg.Message);  
            }


            // verify login successfully


         //   Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > div.ui.secondary.menu > a",2);
            if (marcLogo.Text == "Mars Logo")

            {
              //  Assert.Pass("login pass ,test pass");
                 Console.WriteLine("login pass ,test pass");
            }

            else

            {
                Console.WriteLine("login fail,test fail");
               // Assert.Fail("login fail,test fail");

            }
          



        }



  


        // method for  valiadating login not successfully  with selenium using BDD specflow...........
        public bool validateNotLoginSuccessfuly()
        {
            Thread.Sleep(1000);
            return loginError.Displayed;
            


        }

        // method for  click login button  using  selenium with BDD specflow...........
        public void clickLoginButton()
        {
            // login button
            loginButton.Click();
            Thread.Sleep(2000);
        }


        // method for  valiadating login  successfully  using selenium  with BDD specflow...........
        public bool  validateLoginSuccessfully()
        {
            if (marcLogo.Text == "Mars Logo")

            {
                //  Assert.Pass("login pass ,test pass");
                Console.WriteLine("login pass ,test pass");
                return true;
            }

            else

            {
                Console.WriteLine("login fail,test fail");
                return false;
                // Assert.Fail("login fail,test fail");

            }
            Thread.Sleep(2000);


        }

        // method for  valiadating user are at login page  using selenium  with BDD specflow...........

        public bool  validateYouAreAtLoginPage()
        {
            // login button
            return loginButton.Displayed;
        }


        // method for  click signin link  using selenium  with BDD specflow...........

        public void clickSignLink()
        {
            signInLink.Click();
        }



        // i am login successfully.......

        public void iAmLogedIn(string emailIdValue, string passwordValue)
        {
            navigateToLoginPage();
            clickSignLink();
            enterEmailIdAndPasswordRefactor(emailIdValue, passwordValue);
            clickLoginButton();
            validateLoginSuccessfully();
            Thread.Sleep(2000);
        }

        // method for lunching application using selenium  with BDD specflow...........

        public void navigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }


        // method for enter vailid or invalid emailId and enter vailOr Invalid password to  login  successfully  using selenium  with BDD specflow...........

        public void enterEmailIdAndPasswordRefactor( string emailIdValue, string passwordValue)
        {
            try
            {
                //  Wait.ElementExist(driver, "XPath", " #home > div > div > div.ui.secondary.menu.inverted > div > a", 5);



                // identify emailId 
                if(emailIdValue != null)
                {
                    Console.WriteLine("enter emailId =" + emailIdValue);
                    emailId.SendKeys(emailIdValue);

                }else
                {
                    Console.WriteLine("enter emailId =" + "piueshri24.1992@gmail.com");

                    emailId.SendKeys("piueshri24.1992@gmail.com");
                   


                }



                if (passwordValue != null)
                {
                    // identify password
                    Console.WriteLine("enter emailId =" + passwordValue);

                    password.SendKeys(passwordValue);
                    

                }
                else
                {
                    // identify password
                    Console.WriteLine("enter emailId =" + "123456");

                    password.SendKeys("123456");
                }
                


            }
            catch (Exception msg)
            {
                Assert.Fail("test failed at login Page", msg.Message);
            }
            
        }


     

    }


}
