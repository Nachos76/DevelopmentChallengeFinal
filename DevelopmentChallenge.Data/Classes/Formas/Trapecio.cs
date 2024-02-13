using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio:FormaGeometrica
    {
        public override string Clave { get; set; }
        public override decimal Area { get; set; }
        public override decimal Perimetro { get; set; }
        /// <summary>
        /// Crea una forma Trapecio
        /// </summary>
        /// <param name="_lado1">Lado inferior del Trapecio</param>
        /// <param name="_lado2">Lado lado superior  del Trapecio</param>
        /// <param name="_laterales">Laterales del Trapecio</param>
        /// <param name="_h">Altura  del Trapecio</param>
        public Trapecio(decimal _lado1, decimal _lado2, decimal _laterales, decimal _h)
        {
            Clave = "TRAPECIO";
            CalcularArea(_lado1, _lado2, _h);
            CalcularPerimetro(_lado1, _lado2, _laterales);
        }

        private void CalcularArea(decimal _lado1, decimal _lado2, decimal _h)
        {
            Area = ((_lado1 + _lado2) * _h) / 2;
        }

        private void CalcularPerimetro(decimal _lado1, decimal _lado2, decimal _laterales)
        {
            Perimetro = _lado1 + _lado2 + (_laterales * 2);
        }
    }
}
