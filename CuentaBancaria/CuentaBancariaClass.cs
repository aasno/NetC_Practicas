using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class CuentaBancariaClass
    {
        public String strNombreCliente { get; set; }
        public DateTime dtmFechaInversion { get; set; }
        private Double _dblSaldo { set; get; }
        public CuentaBancariaClass()
        {
            //Este es un constructor
        }
        public int CalcularDiasDeInversion()
        {
            //Retorna un valor entero (los dias de inversion)
            return 0;
        }
        public Double ConsultaSaldo()
        {
            //Retorna el valor Double del saldo
            return _dblSaldo;
        }
        public void Depositar(Double dblCantidad,DateTime dtmFecha)
        {
            //Función para depositar
        }
        public bool OtorgarBono()
        {
            //Returna un valor booleano
            return false;
        }
    }
}
