using CoreBDD;

namespace demobdd
{
    [Feature("Calculator", 
    @"In order to avoid silly mistakes
    As a math idiot
    I want to be told the sum of two numbers")]
    public class CalculatorFeature : Specification
    {
         public CalculatorFeature(SpecFixture context):base(context) 
         {
            
         }

         public CalculatorFeature()
         {
            
         }
    }
}