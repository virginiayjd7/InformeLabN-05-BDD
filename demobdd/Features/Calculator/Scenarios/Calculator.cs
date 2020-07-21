using CoreBDD;
using Xunit;

namespace Demobdd
{
    public class Calculator: CalculatorFeature
    {
        
			[Scenario("Add two numbers")]
			public void AddTwoNumbers()
			{
				Given($"I have entered 1 into the calculator",   () => { });
				And($"I have also entered 2 into the calculator",   () => { });
				When($"I press add",   () => { });
				Then($"the result should be 3",   () => { });
			}

			[Scenario("Multiply two numbers")]
			public void MultiplyTwoNumbers()
			{
				Given($"I have a calculator",   () => { });
				When($"I key in 10",   () => { });
				And($"I key in 5 and press multiply",   () => { });
				Then($"It sets the Total to 50",   () => { });
				And($"It sets the equation to 10 x 5",   () => { });
			}

			[Scenario("Divide two numbers")]
			public void DivideTwoNumbers()
			{
			}

			[Scenario("Subtract two numbers")]
			public void SubtractTwoNumbers()
			{
				Given($"I have entered 5 into the calculator",   () => { });
				And($"I have also entered 2 into the calculator",   () => { });
				When($"I press minus",   () => { });
				Then($"the result should be 3",   () => { });
			}

    }
}