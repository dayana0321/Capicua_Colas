using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular
    {
        private static int fin;
        private static int MAXTAMQ = 99;
        protected int frente;

        protected Object[] ListaCola;

        //Avanza una posicion, retoma el siguiente
        private int siguiente(int r) 
        {
            return (r + 1) % MAXTAMQ;
        }

        //Constructor
        public  ColaCircular() 
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            ListaCola = new Object[MAXTAMQ];
        }
        //Validaciones
        public bool colaVacia() 
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena() 
        {
            return frente == siguiente(siguiente(fin));
        }
        //Operaciones de mofidicaciones de cola
        public void insertar(Object elemento) 
        {
            if (!colaLlena()) 
            {
                fin = siguiente(fin);
                ListaCola[fin] = elemento;
            }
            else 
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //Quitar elemento
        public Object quitar() 
        {
            if (!colaVacia()) 
            {
                Object tn = ListaCola[frente];
                frente = siguiente(frente);
                return tn;
            }
            else 
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Borrar cola
        public void borrarCola() 
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        //Obtener el valor de frente
        public Object frenteCola() 
        {
            if (!colaVacia()) 
            {
                return ListaCola[frente];
            }
            else 
            {
                throw new Exception("Cola vacía");
            }
        }
    }//end class
}
