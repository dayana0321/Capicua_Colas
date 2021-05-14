using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        //Ejemplo con estructura de Cola Queue 
        static void Ejemplo_Cola1() 
        {
            Queue qt = new Queue();
            qt.Enqueue("Hola");
            qt.Enqueue("esta");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"La cola tiene {qt.Count} elementos");
            Console.WriteLine($"Desencolando {qt.Dequeue()}");
            Console.WriteLine($"La cola ahora tiene{qt.Count} elementos");
        }
        static void Ejercicio1() 
        {
            bool capicua;
            String numero;

            Stack pila = new Stack(); //Stack
            Queue cola_circular = new Queue();
            try
            {
                capicua = false;

                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("Teclea un número");
                        numero = Console.ReadLine();
                    } while (!validar(numero));

                    //Pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        char c;
                        c = numero[i];
                        cola_circular.Enqueue(c);
                        pila.Push(c);
                    }

                    //Desencolar, se retira la cola y pila para comparar
                    do
                    {
                        char d;
                        d = (Char)cola_circular.Dequeue();
                        capicua = d.Equals(pila.Pop());//Compara la igualdad
                    } while (capicua && cola_circular.Count!=0);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero} no es capicua");
                        Console.WriteLine("Intente otro :)");
                    }

                    //cola_circular.Clear();
                    //pila.Clear();

                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en{errores.Message} ");
            }
        }
        static void Capicua_original() 
        {
            bool capicua;
            String numero;

            PilaLista pila = new PilaLista();
            ColaCircular circular_cola = new ColaCircular();

            try
            {
                capicua = false;

                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("Teclea un número");
                        numero = Console.ReadLine();
                    } while (!validar(numero));

                    //Pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        char c;
                        c = numero[i];
                        circular_cola.insertar(c);
                        pila.insertarPila(c);
                    }

                    //Desencolar, se retira la cola y pila para comparar
                    do
                    {
                        char d;
                        d = (Char)circular_cola.quitar();
                        capicua = d.Equals(pila.quitar());//Compara la igualdad
                    } while (capicua && !circular_cola.colaVacia());

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numero} no es capicua");
                        Console.WriteLine("Intente otro :)");
                    }

                    circular_cola.borrarCola();
                    pila.LimpiarPila();

                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en{errores.Message} ");
            }
        }
        
       

        //Ejercicio 1
        private static bool validar(String numero) 
        {
            bool sw = true;
            int i = 0;

            while(sw && (i < numero.Length)) 
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }
        static void Main(string[] args)
        {
            //Programa Capicua usando Queue y Stack
          //  Ejemplo_Cola1();
            Ejercicio1();
           
        }
    }
}
