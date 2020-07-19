using CoreBDD;

namespace InformeLabN_05_Utilizando_Desarrollo_guiado_por_comportamiento_BDD_para_realizaci_
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