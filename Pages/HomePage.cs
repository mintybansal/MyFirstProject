using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    class HomePage
    {
        //function to navigate hmepage

            public void navigatetoTM(IWebDriver driver)
        {
            //find the administraton page

            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            //click on time and materials

            IWebElement Time = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));

            Time.Click();


        }



    }
}
