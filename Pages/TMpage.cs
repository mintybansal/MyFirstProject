using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project.Pages
{
    class TMpage
    {
 //function to add TimeandMaterial

        public void AddTM(IWebDriver driver)
        {
            //create new record
            IWebElement new_record = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            new_record.Click();

            //Enter new record
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));
            dropdown.Click();

            //select time from dropdown
            System.Threading.Thread.Sleep(1000);

            var T1 = driver.FindElement(By.XPath("//li[@class= 'k-item' and text()= 'Time']"));
            T1.Click();


            //Enter Code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("T");

            //Enter Description

            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Selenium1");

            //Enter Price
            IWebElement Price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

            Price.SendKeys("100");

            //click on save button

            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //verify the creation of new time and material record


            //Go to last page

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();



            IWebElement actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]"));

            if (actualcode.Text == "T")
            {

                Console.WriteLine("Test passed, Time created Successfully");
            }
            else
            {

                Console.WriteLine("Test failed!");
            }

  }
       //Create afunction to edit record

        public void EditRecord(IWebDriver driver)

        {
            //click on Edit button

            System.Threading.Thread.Sleep(2000);

            //Edit decription 

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            IWebElement Desc = driver.FindElement(By.XPath("//*[@id='Description']"));
            Desc.Clear();
            Desc.SendKeys("Edit4");
            
            //click on save button

            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //Go to last page

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            //Verify the update of Description
            

            IWebElement updaterecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));

            if (updaterecord.Text == "Edit4")
            {
                Console.WriteLine("Test passed, record updated");

            }

            else
            {
                Console.WriteLine("Test failed");

            }


           
     }

        public void DeleteRecord(IWebDriver driver)
        {

            //delete a record

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[2]")).Click();
            driver.SwitchTo().Alert().Accept();


            //verify record  is deleted

            IWebElement verifydelete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[3]"));

            if (verifydelete.Text != "selenium1" )
            {
                Console.WriteLine("Test passed, record deleted");
            }
            else
            {
                Console.WriteLine("Test Case failed!");
            }

        }




           }
}
