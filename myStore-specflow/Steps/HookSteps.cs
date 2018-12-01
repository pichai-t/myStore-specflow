using TechTalk.SpecFlow;

namespace mystore_specflow
{
    [Binding]
    class HookSteps : BasePage
    {
        // Before each scenario
        [BeforeScenario]
        void beforeScenario() {
            // Nothing yet.
        }

        // After each scenario
        [AfterScenario]
        void afterScenario()
        {
            // Close WebDriver
            driver.Quit();
        }

    }
}
