using OpenMRS.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenMRS.Properties
{
    class StartStop
    {
        public static void Start(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Console.WriteLine("Test Case started: ");
            Thread.Sleep(2000);
            Console.WriteLine("Automation on OpenMRS started");
            Thread.Sleep(1000);
            
            driver.Manage().Window.Maximize();

            //Giving Website
            driver.Navigate().GoToUrl("https://openmrs.org");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//i[@class='eicon-close']")).Click();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/");
            Thread.Sleep(2000);
            
        }

        public static void signup(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //Login
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("Admin");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("Admin123");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//li[@id='Inpatient Ward']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='loginButton']")).Click();
            Thread.Sleep(1000);

            //Window scroll
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);
        }
       
        public static void Logout(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//i[@class='icon-signout small']")).Click();
            Thread.Sleep(2000);
        }

        public static void Stop(IWebDriver driver)
        {

            Console.WriteLine("Automation on OpenMRS ended");
            Thread.Sleep(1000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            driver.Close();
            driver.Dispose();
            driver.Quit();
            Console.WriteLine("Test Case ended: ");
            Thread.Sleep(2000);

        }
    }
}
