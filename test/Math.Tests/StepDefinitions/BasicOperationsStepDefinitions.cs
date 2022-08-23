namespace Math.Tests.StepDefinitions;

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

    [When(@"The two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        var a = (int)_scenarioContext["a"];
        var b = (int)_scenarioContext["b"];
        _scenarioContext["Result"] = _basicOperations.Subtract(a, b);
    }

    [When(@"The two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        var a = (int)_scenarioContext["a"];
        var b = (int)_scenarioContext["b"];
        _scenarioContext["Result"] = _basicOperations.Multiply(a, b);
    }

    [When(@"The two numbers are divided")]
    public void WhenTheTwoNumbersAreDivided()
    {
        var a = (int)_scenarioContext["a"];
        var b = (int)_scenarioContext["b"];
        _scenarioContext["Result"] = _basicOperations.Divide(a, b);
    }

    [Then(@"The result should be (\-?\d+)")]
    public void ThenTheResultShouldBe(long answer)
    {
        var result = (long)_scenarioContext["Result"];
        Assert.AreEqual(result, answer);
    }

    [Then(@"The result should be (\-?\d+\.\d+)")]
    public void ThenTheResultShouldBe(double answer)
    {
        var result = (double)_scenarioContext["Result"];
        Assert.AreEqual(result, answer);
    }
}