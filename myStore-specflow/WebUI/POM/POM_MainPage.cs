using OpenQA.Selenium;

namespace mystore_specflow
{
    
    class POM_MainPage : BasePage
    {
        // XPaths (Locators)
        private static string searchXPath = "//*[@id='search_query_top']";
        private static string searchButtonXPath = "/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/button";

        // By objects
        private static By searchBy = By.XPath(searchXPath);
        private static By searchButtonBy = By.XPath(searchButtonXPath);

        // ------------------
        //  PUBLIC METHODS
        // ------------------

        // To enter a text
        public void enterText(string targetField, string inText) {
            IWebElement element = driver.FindElement(getBy(targetField));
            element.Click();
            element.Clear();
            element.SendKeys(inText);
        }

        // To click a button
        public void clickButton(string strButton)
        {
            if (strButton.ToLower().Equals("search"))
            {
                IWebElement element = driver.FindElement(searchButtonBy);
                element.Click();
            }
        }

        // ------------------
        //  PRIVATE METHODS
        // ------------------
        private By getBy(string targetedField)
        {
            By targetedBy = null;
            switch (targetedField.Replace(" ", "").ToLower())
            {
                case "search":
                    targetedBy = searchBy;
                    break;

                // More to come!..
            }
            return targetedBy;
        }
    }
}
