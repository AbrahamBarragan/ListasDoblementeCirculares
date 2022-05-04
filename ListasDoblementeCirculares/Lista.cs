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
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.nodoSiguiente != nodoInicial)
            {
                nodoActual = nodoActual.nodoSiguiente;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.nodoSiguiente = nodoNuevo;
            nodoActual.nodoAnterior = nodoNuevo;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidarVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.nodoSiguiente != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.nodoSiguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
    }
}
