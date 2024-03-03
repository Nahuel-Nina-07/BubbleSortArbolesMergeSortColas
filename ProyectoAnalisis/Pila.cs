using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis
{
    class Pila
    {
        NodoPila Nuevo, Primero, Ultimo;
        public Pila()
        {
            Nuevo = null;
            Primero = null;
            Ultimo = null;
        }
        public void CrearNodo(string nombre, string edad, string celular)
        {
            Nuevo = new NodoPila();
            Nuevo.setNombre(nombre);
            Nuevo.setEdad(edad);
            Nuevo.setCelular(celular);
        }
        public void Apilar(string nombre, string edad, string celular)
        {
            CrearNodo(nombre, edad, celular);
            Nuevo.setSiguiente(Ultimo);
            Ultimo = Nuevo;
            if (Primero == null)
            {
                Primero = Nuevo;
            }
        }
        public NodoPila Desapilar()
        {
            NodoPila aux;
            aux = Ultimo;
            Ultimo = Ultimo.getSiguiente();
            aux.setSiguiente(null);
            return aux;
        }
        public NodoPila devolverFinal()
        {
            return Ultimo;
        }
    }
}
