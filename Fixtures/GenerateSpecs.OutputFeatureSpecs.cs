using System;
using System.IO;
using CoreBDD.SpecGeneration;
using Xunit;
namespace InformeLabN_05_Utilizando_Desarrollo_guiado_por_comportamiento_BDD_para_realizaci_
{
    [CollectionDefinition("CoreBDD")]
    public class Collection : ICollectionFixture<GenerateSpecsFixture> { }
    public class GenerateSpecsFixture : IDisposable
    {
        public void Dispose()
        {
            GenerateSpecs.OutputFeatureSpecs(this.GetType().Assembly.Location,
           @"..\..\..\Specs\");
        }
    }
}
