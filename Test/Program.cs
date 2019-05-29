using My_First_Project.Helpers;
using My_First_Project.Pages;
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
    class Program
    {
        static void Main(string[] args)
 {

            CommonDriver.driver = new ChromeDriver();

//create object for all the classes

            LoginPage loginobj = new LoginPage();

            loginobj.loginstep(CommonDriver.driver);

            HomePage Homeobj = new HomePage();

            Homeobj.navigatetoTM(CommonDriver.driver);

            TMpage TMobj = new TMpage();
            TMobj.AddTM(CommonDriver.driver);

            TMobj.EditRecord(CommonDriver.driver);

            TMobj.DeleteRecord(CommonDriver.driver);








            

            
           

        }
    }
}
