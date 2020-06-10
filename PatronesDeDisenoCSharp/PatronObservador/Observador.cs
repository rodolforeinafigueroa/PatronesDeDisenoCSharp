using System;
namespace PatronesDeDisenoCSharp.PatronObservador
{
    public class Observador : IObservador
    {
        private string nombre;

        public Observador(string nombre) => this.nombre = nombre;

        public void Actualizar(string mensaje)
        {
            Console.WriteLine(String.Format("Observador {0} notificado, mensaje recibido: {1}", nombre, mensaje));
        }
    }
}
