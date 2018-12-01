using System;
using TechTalk.SpecFlow;

namespace mystore_specflow
{
    [Binding]
    class GivenSteps
    {
        // To set Scenario Name
        [Given(@"Scenario is ""(.*)""")]
        public void GivenScenarioIs(string currScenario)
        {
            Console.WriteLine(" Scenario is " + currScenario);
            Globals.currScenario = currScenario;
        }
        
    }
}
