using System;
using PatronesDeDisenoCSharp.PatronObservador;
namespace PatronesDeDisenoCSharp
{
    public static class TestFactory
    {
        public enum TiposDeTest
        {
            PatronObservador
        }
       public static ITest ObtenerTest(TiposDeTest pvTtipoPatron)
        {
            switch (pvTtipoPatron)
            {
                case TiposDeTest.PatronObservador:
                    return new TestObservador();
                default:
                    return null;
            }
        }
    }
}
