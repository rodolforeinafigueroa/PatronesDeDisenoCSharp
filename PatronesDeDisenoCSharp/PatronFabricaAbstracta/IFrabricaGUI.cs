using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public interface IFrabricaGUI
    {
        IVentana CrearVentana();
        IScroll CrearScroll();
    }
}
