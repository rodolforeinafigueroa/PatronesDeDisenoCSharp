using System;
namespace PatronesDeDisenoCSharp.PatronFabricaAbstracta
{
    public class ScrollEstilo1 : IScroll
    {
        public ScrollEstilo1()
        {
        }

        public void Bajar()
        {
            Console.WriteLine("Desplasando hacia abajo usando scroll estilo 1");
        }
    }
}
