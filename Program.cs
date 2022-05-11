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

namespace OpenMRS
{

    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);
            StartStop.Start(driver);

            StartStop.signup(driver);
            TestCase.RegisterPatient(driver);
            TestCase.FindPatientRecord(driver);

            TestCase.ScheduleAppointment(driver);
            TestCase.CaptureVitals(driver);
            StartStop.Logout(driver);
            StartStop.Stop(driver);

        }
    }
}
