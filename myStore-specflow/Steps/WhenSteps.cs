using OpenQA.Selenium;  // From Nuget: Selenium.Support and Selenium.WebDriver
using System;
using TechTalk.SpecFlow;

namespace mystore_specflow
{
    [Binding]
    class WhenSteps
    {
        // Open FF with URL
        [When(@"I open Firefox with URL ""(.*)""")]
        public void WhenIOpenAURL(string strURL)
        {
            Console.WriteLine(" I open Firefox with URL " + strURL);

            // Initiate Firefox WebDriver
            IWebDriver driver = BasePage.initializeFF();
            driver.Navigate().GoToUrl(strURL);

            // Set WebDriver to BasePage
            new BasePage().setWebDriver(driver);

        }

        // Enter/Select a field with a value
        [When(@"I select field ""(.*)"" as ""(.*)""")]
        public void WhenISelectFieldAs(string targetedField, string inText)
        {
            Console.WriteLine(" I select field  " + targetedField + " as " + inText);
            // Main Page
            POM_MainPage mp = new POM_MainPage();
            // Enter "inText" into "targetedField"
            mp.enterText(targetedField, inText);
        }

        // Click a button
        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton(string strButton)
        {
            Console.WriteLine(" I click on  " + strButton + " button");
            POM_MainPage mp = new POM_MainPage();
            mp.clickButton(strButton);
        }


    }
}
