using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public class FacribaEstilo2 : IFrabricaGUI
    {
        public FacribaEstilo2()
        {
        }

        public IScroll CrearScroll()
        {
            return new ScrollEstilo2();
        }

        public IVentana CrearVentana()
        {
            return new VentanaEstilo2();
        }
    }
}
