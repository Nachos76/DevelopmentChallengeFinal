using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado: FormaGeometrica
    {
        public override string Clave { get; set; }
        public override decimal Area { get; set; }
        public override decimal Perimetro { get; set; }
        /// <summary>
        /// Crea una forma Cuadrada
        /// </summary>
        /// <param name="_lado">Lado del Cuadrado</param>
        public Cuadrado(decimal _lado)
        {
            Clave = "CUADRADO";
            CalcularArea(_lado);
            CalcularPerimetro(_lado);
        }

        private void CalcularArea(decimal _lado)
        {
            Area = _lado * _lado;
        }

        private void CalcularPerimetro(decimal _lado)
        {
            Perimetro = _lado * 4;
        }
    }
}
