using Marc.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Marc.pages
{
    class LoginPage
    {
        private IWebDriver driver;
        private IWebElement SignInLink => driver.FindElement(By.CssSelector("#home > div > div > div.ui.secondary.menu.inverted > div > a"));
        private IWebElement EmailId => driver.FindElement(By.XPath(" / html / body / div[2] / div / div / div[1] / div / div[1] / input"));
        private IWebElement Password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private IWebElement MarcLogo => driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > a"));
        private IWebElement LoginError => driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active"));






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
      
            try
            {
                Wait.ElementExist(driver, "CssSelector", "#home > div > div > div.ui.secondary.menu.inverted > div > a", 5);
                // click on signIn link
           
               SignInLink.Click();
               

                // identify emailId 
          
                EmailId.SendKeys("piueshri24.1992@gmail.com");


                // identify password
             
                Password.SendKeys("123456");


                // login button
             

                LoginButton.Click();
            
              
            }
            catch(Exception msg)
            {
               // Assert.Fail("test failed at login Page", msg.Message);
                Console.WriteLine("test failed at login Page", msg.Message);
            }


            // verify login successfully


            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > div.ui.secondary.menu > a", 5);
            if (MarcLogo.Text == "Mars Logo")
            {
                //  Assert.Pass("login pass test pass");
                 Console.WriteLine("login pass ,test pass");
            }

            else
            {
                Console.WriteLine("login fail,test fail");
                 // Assert.Fail("login fail test fail");

            }
          



        }



  


        // method for  valiadating login not successfully  with selenium using BDD specflow...........
        public bool ValidateNotLoginSuccessfuly()
        {
          
            return LoginError.Displayed;
            


        }

        // method for  click login button  using  selenium with BDD specflow...........
        public void ClickLoginButton()
        {
            // login button
            LoginButton.Click();
          
        }


        // method for  valiadating login  successfully  using selenium  with BDD specflow...........
        public bool  ValidateLoginSuccessfully()
        {
            Wait.ElementExist(driver, "CssSelector", "#account-profile-section > div > div.ui.secondary.menu > a", 5);
            if (MarcLogo.Text == "Mars Logo")

            {
                //  Assert.Pass("login pass ,test pass");
                Console.WriteLine("login pass ,test pass");
                return true;
            }

            else

            {
                Console.WriteLine("login fail,test fail");
               
               //  Assert.Fail("login fail,test fail");
                return false;
            }
           


        }

        // method for  valiadating user are at login page  using selenium  with BDD specflow...........

        public bool  ValidateYouAreAtLoginPage()
        {
            // login button
            return LoginButton.Displayed;
        }


        // method for  click signin link  using selenium  with BDD specflow...........

        public void ClickSignLink()
        {
            SignInLink.Click();
        }



        // i am login successfully.......

        public void IAmLogedIn(string emailIdValue, string passwordValue)
        {
            NavigateToLoginPage();
            ClickSignLink();
            EnterEmailIdAndPasswordRefactor(emailIdValue, passwordValue);
            ClickLoginButton();
            ValidateLoginSuccessfully();
          
        }

        // method for lunching application using selenium  with BDD specflow...........

        public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");

            driver.Manage().Window.Maximize();
           
        }


        // method for enter vailid or invalid emailId and enter vailOr Invalid password to  login  successfully  using selenium  with BDD specflow...........

        public void EnterEmailIdAndPasswordRefactor( string emailIdValue, string passwordValue)
        {
            try
            {
                Wait.ElementExist(driver, "CssSelector", "#home > div > div > div.ui.secondary.menu.inverted > div > a", 5);



                // identify emailId 
                if (emailIdValue != null)
                {
                    Console.WriteLine("enter emailId =" + emailIdValue);
                    EmailId.SendKeys(emailIdValue);

                }else
                {
                    Console.WriteLine("enter emailId =" + "piueshri24.1992@gmail.com");

                    EmailId.SendKeys("piueshri24.1992@gmail.com");
                   


                }



                if (passwordValue != null)
                {
                    // identify password
                    Console.WriteLine("enter emailId =" + passwordValue);

                    Password.SendKeys(passwordValue);
                    

                }
                else
                {
                    // identify password
                    Console.WriteLine("enter emailId =" + "123456");

                    Password.SendKeys("123456");
                }
                


            }
            catch (Exception msg)
            {
                Assert.Fail("test failed at login Page", msg.Message);
            }
            
        }


     

    }


}
