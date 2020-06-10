using System;

namespace PatronesDeDisenoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest vObjTest = TestFactory.ObtenerTest(TestFactory.TiposDeTest.PatronObservador);
            vObjTest.EjecutarTest();
        }
    }
}
