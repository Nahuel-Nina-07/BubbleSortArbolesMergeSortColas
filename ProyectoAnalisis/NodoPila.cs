using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis
{
    class NodoPila
    {
        string Nombre;
        string Edad;
        string Celular;
        NodoPila Siguiente;
        public NodoPila() 
        {
            Nombre = string.Empty;
            Edad = string.Empty;
            Celular = string.Empty;
            Siguiente = null;
        }
        public void setNombre(string nombre)
        {
            Nombre = nombre;
        }
        public void setEdad(string edad)
        {
            Edad = edad;
        }
        public void setCelular(string celular)
        {
            Celular = celular;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public string getEdad()
        {
            return Edad;
        }
        public string getCelular()
        {
            return Celular;
        }
        public void setSiguiente(NodoPila siguiente)
        {
            Siguiente = siguiente;
        }
        public NodoPila getSiguiente()
        {
            return Siguiente;
        }
    }
}
