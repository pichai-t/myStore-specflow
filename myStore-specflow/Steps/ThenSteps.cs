using NUnit.Framework; // From Nuget: Nunit
using TechTalk.SpecFlow;

namespace mystore_specflow
{
    [Binding]
    class ThenSteps
    {
        // Verify Expected texts and Actual texts
        [Then(@"I see ""(.*)"" in ""(.*)""")]
        public void ThenISeeIn(string expectedValue, string targetedField)
        {
            string actualValue = new POM_SearchPage().getVisibleText(targetedField);
            Assert.AreEqual(expectedValue.Trim(), actualValue.Trim());
        }

        // More...


    }
}
