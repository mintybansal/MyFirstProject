using My_First_Project.Helpers;
using My_First_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    [TestFixture]

    class Program
    {
        [SetUp]

        public void loginstep()
        {
            CommonDriver.driver = new ChromeDriver();

            //Login steps

            LoginPage loginobj = new LoginPage();

            loginobj.loginstep(CommonDriver.driver);

            HomePage Homeobj = new HomePage();

            Homeobj.navigatetoTM(CommonDriver.driver);


        }

        [Test]

        public void AddTM()
        {
            TMpage TMobj = new TMpage();
            TMobj.AddTM(CommonDriver.driver);

        }

        [Test]

        public void EditRecord()
        {
            TMpage TMobj = new TMpage();
            TMobj.EditRecord(CommonDriver.driver);

        }

        [Test]

        public void DeleteRecord()
        {

            TMpage TMobj = new TMpage();

            TMobj.DeleteRecord(CommonDriver.driver);
        }

        [TearDown]

        public void FlushTest()
        {
            //close driver
            CommonDriver.driver.Close();


        }
        static void Main(string[] args)
        {

        }

    }

}
            



            

            

           









            

            
           

      