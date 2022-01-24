using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_4_1
{
    internal class Circunferencia
    {
        private double _dblRadio;//Atributo privado


        public void ModificarRadio(double dblRadio)
        {
            //Mutator
            _dblRadio = dblRadio;
        }
        public double ConsultarRadio()
        {
            //Accessor
            return _dblRadio;
        }
        //Métodos publicos
        public double CalcularArea()
        {
            double dblArea = 0;
            dblArea = Math.PI * Math.Pow(_dblRadio, 2);
            return dblArea;
        }
        public double CalcularPerimetro()
        {
            double dblPerimetro = 0;
            dblPerimetro = Math.PI * _dblRadio * 2;
            return dblPerimetro;
        }
    }
}
