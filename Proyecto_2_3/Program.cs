using System;

namespace Proyecto_2_3
{
    class Program
    {
        static int x = 5;// Variable global
        static void Main(string[] args)
        {
            int y = 13; //variable local
            bool esImpar;
            Console.WriteLine("\nx = " + x);
            Metodo(ref y, out esImpar);
            Console.WriteLine("\nx = " + x);
            Console.WriteLine("\ny = " + y);
            if (esImpar)
                Console.WriteLine("\ny es un numero impar");
            else
                Console.WriteLine("\ny es un numero par");
            Console.WriteLine((esImpar) ? "\ny es un numero impar" : "\ny es un numero par");
            Console.ReadKey();
        }
        //El parametro "a" recibe la referencia de "y" y el parametro de salida sirve para determinar si el parametro enviado es Impar
        static void Metodo(ref int a, out bool Impar)
        {
            a += 3;
            Console.WriteLine("\na = " + a);
            /*if (a % 2 != 0)
                Impar = true;
            else
                Impar = false;*/
            Impar = (a % 2 != 0);
        }
    }
}
