using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;


namespace mystore_specflow
{
    class BasePage
    {
        protected static IWebDriver driver;

        public void setWebDriver(IWebDriver driver)
        {
            BasePage.driver = driver;
        }

        public IWebDriver getWebDriver()
        {
            return driver;
        }

        public static IWebDriver initializeFF() {

            // Set gecko.driver in System Level
            String projDir = Directory.GetParent(Environment.CurrentDirectory).ToString();
            Environment.SetEnvironmentVariable("webdriver.gecko.driver", projDir + "\\packages\\WebDrivers\\geckodriver.exe");

            // Set Firefox location - to pass to FirefoxDriver            
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(projDir + "\\packages\\WebDrivers");
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

            // Open FF WebDriver
            return new FirefoxDriver(service); 

        }


        public static void Back() {


        }

        // More... 

    }
}
