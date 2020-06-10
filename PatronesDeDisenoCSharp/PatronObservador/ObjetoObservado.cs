using System;
using System.Collections.Generic;

namespace PatronesDeDisenoCSharp.PatronObservador
{
    public class ObjetoObservado
    {
        private List<IObservador> prvListaObservadores; 
        private List<string> prvListaDeLaCompra;

        public ObjetoObservado()
        {
            prvListaObservadores = new List<IObservador>();
            prvListaDeLaCompra = new List<string>();

        }

        public void AdicionarElementoAComprar(string pvStrElementoAComprar)
        {
            prvListaDeLaCompra.Add(pvStrElementoAComprar);
            Notificar(pvStrElementoAComprar);
        }

        public void SubscribirObservador(IObservador pvObservador)
        {
            prvListaObservadores.Add(pvObservador);
        }

        public void DesuscribirObservador(IObservador pvObservador)
        {
            prvListaObservadores.Remove(pvObservador);
        }

        private void Notificar(string mensaje)
        {
            foreach( IObservador observador in prvListaObservadores)
            {
                observador.Actualizar(String.Format("Notificacion desde el objeto observado. Elemento adicionado: {0}", mensaje));
            }
        }

    }
}
