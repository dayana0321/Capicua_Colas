using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin; //Puntero
        private static int MAXTAMQ = 39; //Tamaño
        protected int frente; //Puntero

        protected Object[] ListaCola;//En donde se almacenarán los datos 

        //Constructor
        public ColaLineal() 
        {
            frente = 0;
            fin = -1;
            ListaCola = new object[MAXTAMQ];
        }

        public bool colaVacia() 
        {
            return frente > fin;
        }

        public bool colaLlena() 
        {
            return fin == MAXTAMQ - 1;
        }

        //Operaciones para trabajar con datos en la cola

        public void insertar(Object elemento) 
        {
            if (!colaLlena()) 
            {
                ListaCola[++fin] = elemento; 
            }
            else 
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //Quitar elemento de la cola
        public Object quitar() 
        {
            if (!colaVacia()) 
            {
                return ListaCola[frente++]; //Avanza hacia el frente
            }
            else 
            {
                throw new Exception("Cola Vacía");
            }
        }

        //Limpiar toda la cola
        public void borrarCola() 
        {
            frente = 0;
            fin = -1;
        }

        //Acceder al valor que está al frente de la cola
        public Object frenteCola() 
        {
            if (!colaVacia()) 
            {
                return ListaCola[frente];
            }
            else 
            {
                throw new Exception("Cola Vacía");
            }
        }
    }//end class
}
