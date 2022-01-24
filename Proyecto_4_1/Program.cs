using System;

namespace Proyecto_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable local
            double dblRadio;
            //Declaracion de objeto
            Circunferencia rueda;
            Console.WriteLine("Este programa solicita al usuario capturar el valor númerico real del radio de una circunferencia y calcula el área y el perímetro");
            Console.Write("Introduzca el valor del radio ---> ");
            //Leectura del valor del radio digitado por el usuario
            dblRadio = double.Parse(Console.ReadLine());
            //creaciond e objeto rueda
            rueda = new Circunferencia();
            //Mutator
            rueda.ModificarRadio(dblRadio);
            //Accessor
            Console.WriteLine("\n\nRadio de la rueda = " + rueda.ConsultarRadio().ToString("N2"));
            //Funciones para calcular el área y el perimetro
            Console.WriteLine("Área = " + rueda.CalcularArea().ToString("N2"));
            Console.WriteLine("Perimetro = " + rueda.CalcularPerimetro().ToString("N2"));
            Console.ReadKey();
            //No es la forma más recomendable de accesar a los atributos, ya que empobrece la legibilidad del codigo y puede crear confusión
            //En C# .NET la forma más apropiada de hacerlo es a tráves de propiedades
        }
    }
}
