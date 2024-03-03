using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis
{
    class Arbol
    {
        NodoArbol raiz;
        NodoArbol nuevo;

        public Arbol()
        {
            raiz = null;
            nuevo = null;
        }

        public void crearNodo(int numeroEntrada)
        {
            nuevo = new NodoArbol();
            nuevo.Numero = numeroEntrada;
            nuevo.Derecha = null;
            nuevo.Izquierda = null;
        }

        public void crearArbol(int numeroEntrada)
        {
            crearNodo(numeroEntrada);
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                NodoArbol auxiliar;
                auxiliar = raiz;
                while (auxiliar != null)
                {
                    if (numeroEntrada > auxiliar.Numero)
                    {
                        if (auxiliar.Derecha == null)
                        {
                            auxiliar.Derecha = nuevo;
                            auxiliar = null;
                        }
                        else
                        {
                            auxiliar = auxiliar.Derecha;
                        }
                    }
                    else
                    {
                        if (auxiliar.Izquierda == null)
                        {
                            auxiliar.Izquierda = nuevo;
                            auxiliar = null;
                        }
                        else
                        {
                            auxiliar = auxiliar.Izquierda;
                        }
                    }
                }
            }
        }

        public NodoArbol devolverRaiz()
        {
            return raiz;
        }

        public int obtenerNivel(int numeroEntrada)
        {
            return obtenerNivelRecursivo(raiz, numeroEntrada, 1);
        }

        private int obtenerNivelRecursivo(NodoArbol nodo, int numeroEntrada, int nivelActual)
        {
            if (nodo == null)
            {
                return 0;
            }

            if (nodo.Numero == numeroEntrada)
            {
                return nivelActual;
            }

            int nivelIzquierda = obtenerNivelRecursivo(nodo.Izquierda, numeroEntrada, nivelActual + 1);
            if (nivelIzquierda != 0)
            {
                return nivelIzquierda;
            }

            int nivelDerecha = obtenerNivelRecursivo(nodo.Derecha, numeroEntrada, nivelActual + 1);
            return nivelDerecha;
        }

        private void obtenerMayoresRecursivo(NodoArbol nodo, List<int> mayores)
        {
            if (nodo != null)
            {
                mayores.Add(nodo.Numero);
                obtenerMayoresRecursivo(nodo.Izquierda, mayores);
                obtenerMayoresRecursivo(nodo.Derecha, mayores);
            }
        }

        public List<int> obtenerMayoresRaiz()
        {
            List<int> mayoresRaiz = new List<int>();
            obtenerMayoresRaizRecursivo(raiz, raiz.Numero, mayoresRaiz);
            return mayoresRaiz;
        }

        private void obtenerMayoresRaizRecursivo(NodoArbol nodo, int valorRaiz, List<int> mayoresRaiz)
        {
            if (nodo == null)
            {
                return;
            }

            if (nodo.Numero > valorRaiz)
            {
                mayoresRaiz.Add(nodo.Numero);
            }

            obtenerMayoresRaizRecursivo(nodo.Izquierda, valorRaiz, mayoresRaiz);
            obtenerMayoresRaizRecursivo(nodo.Derecha, valorRaiz, mayoresRaiz);
        }

        public List<int> obtenerMenoresRaiz()
        {
            List<int> menoresRaiz = new List<int>();
            obtenerMenoresRaizRecursivo(raiz, raiz.Numero, menoresRaiz);
            return menoresRaiz;
        }

        private void obtenerMenoresRaizRecursivo(NodoArbol nodo, int valorRaiz, List<int> menoresRaiz)
        {
            if (nodo == null)
            {
                return;
            }

            if (nodo.Numero < valorRaiz)
            {
                menoresRaiz.Add(nodo.Numero);
            }

            obtenerMenoresRaizRecursivo(nodo.Izquierda, valorRaiz, menoresRaiz);
            obtenerMenoresRaizRecursivo(nodo.Derecha, valorRaiz, menoresRaiz);
        }

        public List<int> obtenerInOrden()
        {
            List<int> inOrden = new List<int>();
            obtenerInOrdenRecursivo(raiz, inOrden);
            return inOrden;
        }

        private void obtenerInOrdenRecursivo(NodoArbol nodo, List<int> inOrden)
        {
            if (nodo != null)
            {
                obtenerInOrdenRecursivo(nodo.Izquierda, inOrden);
                inOrden.Add(nodo.Numero);
                obtenerInOrdenRecursivo(nodo.Derecha, inOrden);
            }
        }

        public List<int> obtenerPostOrden()
        {
            List<int> postOrden = new List<int>();
            obtenerPostOrdenRecursivo(raiz, postOrden);
            return postOrden;
        }

        private void obtenerPostOrdenRecursivo(NodoArbol nodo, List<int> postOrden)
        {
            if (nodo != null)
            {
                obtenerPostOrdenRecursivo(nodo.Izquierda, postOrden);
                obtenerPostOrdenRecursivo(nodo.Derecha, postOrden);
                postOrden.Add(nodo.Numero);
            }
        }

        public List<int> obtenerAmplitud()
        {
            List<int> amplitud = new List<int>();
            Queue<NodoArbol> cola = new Queue<NodoArbol>();

            if (raiz != null)
            {
                cola.Enqueue(raiz);

                while (cola.Count > 0)
                {
                    NodoArbol nodo = cola.Dequeue();
                    amplitud.Add(nodo.Numero);

                    if (nodo.Izquierda != null)
                        cola.Enqueue(nodo.Izquierda);

                    if (nodo.Derecha != null)
                        cola.Enqueue(nodo.Derecha);
                }
            }

            return amplitud;
        }

        public int obtenerAltura()
        {
            return obtenerAlturaRecursivo(raiz);
        }

        private int obtenerAlturaRecursivo(NodoArbol nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzquierda = obtenerAlturaRecursivo(nodo.Izquierda);
            int alturaDerecha = obtenerAlturaRecursivo(nodo.Derecha);

            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }
    }
}
