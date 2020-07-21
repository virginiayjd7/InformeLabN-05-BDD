using Xunit;
using CoreBDD;

namespace InformeLabN_05_Utilizando_Desarrollo_guiado_por_comportamiento_BDD_para_realizaci_
{
    public class AdvancedCalculator : CalculatorFeature
    {
        Calculator calculator;

        [Scenario("Multiply two numbers")]
        public void MultiplyTwoNumbers()
        {

            Given("I have a calculator",           () => calculator = new Calculator());
            When("I key in 10",                    () => calculator.Key(10));
            And("I key in 5 and press multiply",  () => calculator.Multiply(5));
            Then("It sets the Total to 50",        () => calculator.Total.ShouldBe(50));
            And("It sets the equation to 10 x 5", () => calculator.Equation.ShouldBe("10 x 5"));
        }

        [Scenario("Divide two numbers")]
        public void DivideTwoNumbers()
        {
          Given("I have a calculator", () => calculator = new Calculator());
          When("I key in 10", () => calculator.Key(10));
          And("I key in 5 and press divide", () => calculator.Divide(5));
          Then("It sets the Total to 2", () => calculator.Total.ShouldBe(2));
        }
        [ScenarioOutline("Divide two numbers")]
        [Examples(10, 2, 5)]
        [Examples(20, 4, 5)]
        public void DivideTwoNumbers(int number, int divideby, int result)
        {
            Given($"I have a calculator",         () => calculator = new Calculator());
            When($"I key in {number}",                    () => calculator.Key(number));
            And($"I key in {divideby} and press divide",  () => calculator.Divide(divideby));
            Then($"It sets the Total to {result}",        () => calculator.Total.ShouldBe(result));
            //And($"It sets the equation to {number} / {divideby}", () => calculator.Equation.ShouldBe($"{number} / {divideby}"));
        }
    }
}