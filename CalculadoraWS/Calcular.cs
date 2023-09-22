using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS
{
    public class Calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public decimal areaCuadrado(decimal lado)
        {
            return lado * lado;
        }
        public decimal areaTriangulo(decimal baseT, decimal altura)
        {
            var resultado = (baseT * altura) / 2;
            return resultado;
        }
        public double areaCirculo(double radio)
        {
            var resultado = 3.1416 * (radio * radio);
            return resultado;
        }
    }
}