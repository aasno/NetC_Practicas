using System;

namespace Proyecto_2_1
{
    class Program
    {
        static int x = 5;//Variable Global
        static void Main(string[] args)
        {
            int y = 13;//Variable local
            Console.WriteLine("x = " + x);

            //Parametro por valor (copia el valor)
            Metodo(y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            //Parametro por referencia (manda la direccion de memoria de la variable)
            MetodoReferencia(ref y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
        static void Metodo(int a)
        {
            a += 3;
            Console.WriteLine("a = " + a);
            x *= 2;
        }
        static void MetodoReferencia(ref int a)
        {
            a += 3;
            Console.WriteLine("a = " + a);
            x *= 2;
        }
    }
}
