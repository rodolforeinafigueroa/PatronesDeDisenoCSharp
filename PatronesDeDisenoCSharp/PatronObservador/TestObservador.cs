using System;
namespace PatronesDeDisenoCSharp.PatronObservador
{
    public class TestObservador : ITest
    {
        public TestObservador()
        {
        }

       

        public void EjecutarTest()
        {
            ObjetoObservado vObjObservado = new ObjetoObservado();
            Observador vObjObservador1 = new Observador("Objeto1");
            Observador vObjObservador2 = new Observador("Objeto2");

            //Se suscriben los observadores
            vObjObservado.SubscribirObservador(vObjObservador1);
            vObjObservado.AdicionarElementoAComprar("Manzana");
            vObjObservado.SubscribirObservador(vObjObservador2);
            vObjObservado.AdicionarElementoAComprar("Pera");
        }
    }
}
