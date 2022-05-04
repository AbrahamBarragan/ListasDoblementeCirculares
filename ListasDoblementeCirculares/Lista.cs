using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeCirculares
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
            nodoActual = nodoInicial;
            nodoInicial.nodoSiguiente = nodoInicial;
            nodoInicial.nodoAnterior = nodoInicial;
        }
        public bool ValidarVacio()
        {
            return (nodoInicial.nodoSiguiente == nodoInicial.nodoAnterior);
        }
        public void Vaciar()
        {
            nodoInicial.nodoSiguiente = nodoInicial;
            nodoInicial.nodoAnterior = nodoInicial;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.nodoSiguiente != nodoInicial)
            {
                nodoActual = nodoActual.nodoSiguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
    }
}
