using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public class TestFabricaAbstracta : ITest
    {
        public TestFabricaAbstracta()
        {
        }

        public void EjecutarTest()
        {
            IFrabricaGUI vFabricaGUI;
            IVentana vVentana;
            IScroll vScroll;
            Console.WriteLine("Seleccione el estilo: 1.Clasico 2.Moderno ");
            String vRespuesta = Console.ReadLine();
            if ("1".Equals(vRespuesta))
            {
                vFabricaGUI = new FabricaEstilo1();
            }
            else
            {
                vFabricaGUI = new FacribaEstilo2();
            }

            vVentana = vFabricaGUI.CrearVentana();
            vScroll = vFabricaGUI.CrearScroll();

            vVentana.Maximizar();
            vScroll.Bajar();
        }
    }
}
