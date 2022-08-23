
The focus of this project was a simple implementation of tests using **SpecFlow**.

## Visual Studio Plugin

Install the SpecFlow plugin, this plugin will help you with feature creation and test implementation. 

VS: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step1.html

Rider: https://docs.specflow.org/projects/getting-started/en/latest/gettingstartedrider/Step1r.html

## Code to be tested

    public interface IBasicOperations
    {
        long Sum(int a, int b);
    }

    public class BasicOperations : IBasicOperations
    {
        public long Sum(int a, int b) => a + b;
    }

## Feature file 

	Feature: BasicOperations
		Test basic math operations

	Scenario: Add two positive numbers
		Given The first number is 5
		And The second number is 7
		When The two numbers are added
		Then The result should be 12

	Scenario: Add two negative numbers
		Given The first number is -5
		And The second number is -12
		When The two numbers are added
		Then The result should be -17

	Scenario: Add a positive number and a negative number
		Given The first number is 55
		And The second number is -23
		When The two numbers are added
		Then The result should be 32

## Test Implementation

    [Binding]
    public class BasicOperationsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly IBasicOperations _basicOperations;

        public BasicOperationsStepDefinitions(ScenarioContext scenarioContext)
        {
            _basicOperations = new BasicOperations();
            _scenarioContext = scenarioContext;
        }

        [Given(@"The first number is (\-?\d+)")]
        public void GivenTheFirstNumberIs(int a)
        {
            _scenarioContext["a"] = a;
        }

        [Given(@"The second number is (\-?\d+)")]
        public void GivenTheSecondNumberIs(int b)
        {
            _scenarioContext["b"] = b;
        }

        [When(@"The two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var a = (int)_scenarioContext["a"];
            var b = (int)_scenarioContext["b"];
            _scenarioContext["Result"] = _basicOperations.Sum(a, b);
        }

        [Then(@"The result should be (\-?\d+)")]
        public void ThenTheResultShouldBe(long answer)
        {
            var result = (long)_scenarioContext["Result"];
            Assert.AreEqual(result, answer);
        }
    }