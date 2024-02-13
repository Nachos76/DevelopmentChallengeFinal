using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        public override string Clave { get; set; }
        public override decimal Area { get; set; }
        public override decimal Perimetro { get; set; }
        /// <summary>
        /// Crear una Forma Rectángulo
        /// </summary>
        /// <param name="_base">Base del Rectangulo</param>
        /// <param name="_base">Altura del Rectangulo</param>
        public Rectangulo(decimal _base, decimal _altura)
        {
            Clave = "RECTANGULO";
            CalcularArea(_base, _altura);
            CalcularPerimetro(_base, _altura);
        }

        private void CalcularArea(decimal _base, decimal _altura)
        {

            Area = _base * _altura;
        }

        private void CalcularPerimetro(decimal _base, decimal _altura)
        {
            Perimetro = (_base * 2) + (_altura * 2);
        }
    }
}
