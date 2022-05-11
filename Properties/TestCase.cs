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
    class TestCase
    {
        public static void RegisterPatient(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='referenceapplication-registrationapp-registerPatient-homepageLink-referenceapplication-registrationapp-registerPatient-homepageLink-extension']")).Click();
            Thread.Sleep(9000);

            //Listing Patient name
            driver.FindElement(By.XPath("//input[@name='givenName']")).SendKeys("Shri");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='middleName']")).SendKeys("Shyaam");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='familyName']")).SendKeys("Sundar");
            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//input[@id='checkbox-unknown-patient']")).SendKeys("Sundar");
            //Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);

            //Select Gender
            driver.FindElement(By.XPath("//option[@value='M']")).Click();
            Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);

            //Select Date of Birth
            driver.FindElement(By.XPath("//input[@name='birthdateDay']")).SendKeys("14");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//select[@id='birthdateMonth-field']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[text()='February']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='birthdateYear']")).SendKeys("2002");
            Thread.Sleep(1000);


            //Estimated Age
            //driver.FindElement(By.XPath("//input[@id='birthdateYears-field']")).SendKeys("24");
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//input[@id='birthdateMonths-field']")).SendKeys("2");
            //Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);


            driver.FindElement(By.XPath("//input[@id='address1']")).SendKeys("Mayapur ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='address2']")).SendKeys("Nabadwip ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='cityVillage']")).SendKeys("Nodia, ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='stateProvince']")).SendKeys("West Bengal, ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='country']")).SendKeys("India-");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='postalCode']")).SendKeys("712457");
            Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);

            //Patient's Contact Number
            driver.FindElement(By.XPath("//input[@name='phoneNumber']")).SendKeys("2005005002");
            Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);

            //Patient's Contact Number
            driver.FindElement(By.XPath("//select[@id='relationship_type']")).Click();
            Thread.Sleep(1000);

            //Patient's Relationship
            driver.FindElement(By.XPath("//option[@data-val='Supervisor']")).Click();
            Thread.Sleep(1000);


            //Patient's Name
            //driver.FindElement(By.XPath("//input[@class='person-typeahead ng-pristine ng-valid ng-empty ng-touched']")).SendKeys("Shri Shyaam Sundar");
            driver.FindElement(By.XPath("//*[@id='relationship']/p[2]/input[1]")).SendKeys("Shri Shyaam Sundar");
            Thread.Sleep(1000);

            //Next Button
            driver.FindElement(By.XPath("//button[@id='next-button']")).Click();
            Thread.Sleep(1000);

            //Submit Button
            driver.FindElement(By.XPath("//input[@id='submit']")).Click();
            Thread.Sleep(1000);



        }
        public static void FindPatientRecord(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/referenceapplication/home.page");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@id='coreapps-activeVisitsHomepageLink-coreapps-activeVisitsHomepageLink-extension']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='patient-search']")).SendKeys("Shyaam");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//tr[@class='odd']")).Click();
            Thread.Sleep(4000);

        }

        public static void ScheduleAppointment(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/referenceapplication/home.page");
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='appointmentschedulingui-homeAppLink-appointmentschedulingui-homeAppLink-extension']")).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//a[@id='appointmentschedulingui-appointmentRequests-app']")).Click();
            //Thread.Sleep(1000);
            driver.FindElement(By.XPath("//i[@class='icon-share-alt edit-action']")).Click();
            Thread.Sleep(2000);


            //new
            driver.FindElement(By.XPath("//a[text()='View all types']")).Click(); 
            js.ExecuteScript("window.scrollBy(0,600)"); 
            driver.FindElement(By.XPath("//*[@id='allAppointmentTypesModal']/div[2]/div[3]/a")).Click();
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//*[@id='allAppointmentTypesModal']/div[2]/span")).Click();
            //close();



            //Clear Date Picker
            //driver.FindElement(By.XPath("//*[@id='searchParameters']/daterangepicker/div/span[1]/a")).Click();
            //Thread.Sleep(2000);
            
            //Calender
            //driver.FindElement(By.XPath("//*[@id='searchParameters']/daterangepicker/div/span[1]/i")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='datepicker-317-8967-24']")).Click();
            
            //Output- No available time slot


            driver.FindElement(By.XPath("//button[@class='confirm']")).Click();
        }

        public static void CaptureVitals(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/referenceapplication/home.page");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//i[@class='icon-vitals']")).Click(); 
            driver.FindElement(By.XPath("//input[@id='patient-search']")).SendKeys("Shyaam");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//tr[@class='odd']")).Click();
            Thread.Sleep(4000);

        }

    }

}
