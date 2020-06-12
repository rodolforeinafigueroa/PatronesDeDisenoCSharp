using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public class ScrollEstilo2 : IScroll
    {
        public ScrollEstilo2()
        {
        }

        public void Bajar()
        {
            Console.WriteLine("Desplasando hacia abajo usando scroll estilo 2");
        }
    }
}
