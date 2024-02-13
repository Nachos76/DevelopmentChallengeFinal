using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometrica
    {
        public override string Clave { get; set; }
        public override decimal Area { get; set; }
        public override decimal Perimetro { get; set; }
        /// <summary>
        /// Crear una Forma Circulo
        /// </summary>
        /// <param name="_radio">Radio del Círculo</param>
        public Circulo(decimal _radio)
        {
            Clave = "CIRCULO";
            CalcularArea(_radio);
            CalcularPerimetro(_radio);
        }

        private void CalcularArea(decimal _radio)
        {

            Area = (decimal)Math.PI * (_radio / 2) * (_radio / 2);
        }

        private void CalcularPerimetro(decimal _radio)
        {
            Perimetro = (decimal)Math.PI * _radio;
        }
    }
}
