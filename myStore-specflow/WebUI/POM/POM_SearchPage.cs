using OpenQA.Selenium;

namespace mystore_specflow
{
    
    class POM_SearchPage : BasePage
    {
        // XPaths (Locators)
        private static string searchResultCounterXPath  = "/html/body/div/div[2]/div/div[3]/div[2]/h1/span[2]";
        private static string searchWordXPath = "/html/body/div/div[2]/div/div[3]/div[2]/h1/span[1]";

        // By objects
        private static By searchResultCounterBy  = By.XPath(searchResultCounterXPath);
        private static By searchWordBy = By.XPath(searchWordXPath);

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
        
        // Get Visible Text 
        public string getVisibleText(string targetedField)
        {
            By targetedBy= null;
            switch (targetedField.Replace(" ", "").ToLower())
            {
                case "searchresultcounter":
                    targetedBy = searchResultCounterBy;
                    break;
                case "searchword":
                    targetedBy = searchWordBy;
                    break;
            }
            return driver.FindElement(targetedBy).Text.Trim().Replace("\"", "");
        }

        // ------------------
        //  PRIVATE METHODS
        // ------------------
        private By getBy(string targetField)
        {
            By targetBy = null;
            switch (targetField.Replace(" ", "").ToLower())
            {
                case "searchword":
                    targetBy = searchWordBy;
                    break;
                case "searchresultcouner":
                    targetBy = searchResultCounterBy;
                    break;
            }
            return targetBy;
        }
    }
}
