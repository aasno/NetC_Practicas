using System;

namespace Proyecto_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Radio, Area;
            Console.Write("Teclee el valor del radio: ");
            Radio = double.Parse(Console.ReadLine());
            Area = CalcularArea(Radio);
            Console.WriteLine("El area es : " + Area + " unidades cuadradas");
            Console.ReadKey();
        }
        static double CalcularArea(double r)
        {
            return (Math.PI * Math.Pow(r, 2));
        }
    }
}
