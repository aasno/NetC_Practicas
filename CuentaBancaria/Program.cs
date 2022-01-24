using System;

namespace CuentaBancaria
{
    internal class Program
    {
        // Declaracion y creacion de objetos en una sola linea de forma global
        CuentaBancariaClass cuentaChequesGlobal2 = new();

        static void Main(string[] args)
        {
            //Declaracion de objeto en partes
            CuentaBancariaClass cuentaCheques; //Declara el objeto
            cuentaCheques = new CuentaBancariaClass(); //Creacion de objeto
            // Declaracion y creacion de objetos en una sola linea
            CuentaBancariaClass cuentaCheques2 = new CuentaBancariaClass();
        }
    }
}
