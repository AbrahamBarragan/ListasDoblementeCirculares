﻿using System;
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

    }
}