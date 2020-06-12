using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public class FabricaEstilo1: IFrabricaGUI
    {
        public FabricaEstilo1()
        {
        }

        public IScroll CrearScroll()
        {
            return new ScrollEstilo1();
        }

        public IVentana CrearVentana()
        {
            return new VentanaEstilo1();
        }
    }
}
