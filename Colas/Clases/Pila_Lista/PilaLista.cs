using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.Pila_Lista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<Object> ListaPila;

        public PilaLista() 
        {
            cima = -1;
            ListaPila = new List<object>();
        }

        public void insertarPila(Object elemento) 
        {
            cima++;
            ListaPila.Add(elemento);
        }

        public Object quitar() 
        {
            Object aux;
            if (pilaVacia()) 
            {
                throw new Exception("Pila vacia");
            }
            aux = ListaPila[cima];
            ListaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila() 
        {
            if (!pilaVacia()) 
            {
                throw new Exception("Pila vacía, no se puede sacar elemento");
            }
            return ListaPila[cima];
        }

        public void LimpiarPila() 
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }

        public bool pilaVacia() 
        {
            return cima == -1;
        }
    }
}
