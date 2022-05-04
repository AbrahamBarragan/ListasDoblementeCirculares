using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeCirculares
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo nodoSiguiente { get; set; }
        public Nodo nodoAnterior { get; set; }
        public Nodo(string valor = "", Nodo nodoanterior = null, Nodo nodosiguiente = null)
        {
            Valor = valor;
            nodoAnterior = nodoanterior;
            nodoSiguiente = nodosiguiente;
        }
    }
}
