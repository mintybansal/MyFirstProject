using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    class LoginPage
    {

        //Step to login

            public void loginstep(IWebDriver driver)
        {

  
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login");

            //enter username
            IWebElement username = driver.FindElement(By.Id("UserName"));

            username.SendKeys("Hari");

            //enter password

            IWebElement password = driver.FindElement(By.Id("Password"));

            password.SendKeys("123123");

            //click on login button

            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            loginbutton.Click();

            //To maximise the window
            driver.Manage().Window.Maximize();


            //Verify the test case
            IWebElement welcomeuser = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (welcomeuser.Text == "Hello hari!")
            {
                Console.WriteLine("Test passed, Login successfully");
            }

            else
            {
                Console.WriteLine("Test failed!");

            }
        }

        



    }
}
