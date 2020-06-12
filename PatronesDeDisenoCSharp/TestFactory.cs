using System;
using PatronesDeDisenoCSharp.PatronObservador;
using PatronesDeDisenoCSharp.PatronFabricaAbstracta;
namespace PatronesDeDisenoCSharp
{
    public static class TestFactory
    {
        public enum TiposDeTest
        {
            PatronObservador,
            PatronFabricaAbstracta
        }
       public static ITest ObtenerTest(TiposDeTest pvTtipoPatron)
        {
            switch (pvTtipoPatron)
            {
                case TiposDeTest.PatronObservador:
                    return new TestObservador();
                case TiposDeTest.PatronFabricaAbstracta:
                    return new TestFabricaAbstracta();
                default:
                    return null;
            }
        }
    }
}
