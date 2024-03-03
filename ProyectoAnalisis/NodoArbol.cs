using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis
{
    class NodoArbol
    {
        int numero;
        NodoArbol derecha;
        NodoArbol izquierda;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public NodoArbol Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }

        public NodoArbol Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }
    }
}
