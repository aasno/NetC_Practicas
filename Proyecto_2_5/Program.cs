using System;

namespace Proyecto_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del tamaño del arreglo
            int Tamaño;
            //Declaracion del arreglo
            int[] Arreglo;
            //Generar un número aleatorio
            Random NumeroAleatorio = new Random(int.MaxValue);
            Console.WriteLine("Teclee el tamaño del arreglo");
            Tamaño = int.Parse(Console.ReadLine());
            //Creacion del arreglo
            Arreglo = new int[Tamaño];
            //Llenar el arreglo con numeros generados aleatoriamente
            Console.WriteLine("\nARREGLO DESORDENADO\n");
            for (int i = 0; i < Tamaño; i++)
            {
                //Genera Número aleatorio y lo almacena en la celda "i" del arreglo
                Arreglo[i] = NumeroAleatorio.Next();
                //Imprime el numero generado
                Console.WriteLine("{0:N0}", Arreglo[i]);
            }
            Console.WriteLine("\nOprima cualquier tecla para ordenar el arreglo...");
            Console.ReadKey();
            //Invoca el procedimiento "ordenar" y le envia el "Arreglo" y el "Tamaño"
            Ordenar(ref Arreglo, Tamaño);
            //Limpia la pantalla
            Console.Clear();
            //Imprime el arreglo
            Console.WriteLine("ARREGLO ORDENADO\n");
            for (int i = 0; i < Tamaño; i++)
            {
                Console.WriteLine("{0:N0}", Arreglo[i]);
            }
            Console.WriteLine("Oprima cualquier tecla para salir");
            Console.ReadKey();
        }
        //Procedimiento para ordenar un arreglo recibido como parámetro
        static void Ordenar(ref int[] A, int T)
        {
            for (int p = 0; p < T - 1; p++)
            {
                for (int e = p + 1; e < T; e++)
                {
                    if (A[e] < A[p])
                    {
                        int temp = A[p];
                        A[p] = A[e];
                        A[e] = temp;
                    }
                }
            }
        }
    }
}
