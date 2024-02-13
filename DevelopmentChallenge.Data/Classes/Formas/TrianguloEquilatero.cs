using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero:FormaGeometrica
    {
        public override string Clave { get; set; }
        public override decimal Area { get; set; }
        public override decimal Perimetro { get; set; }
        /// <summary>
        /// Crear una Forma Triángulo Equilatero
        /// </summary>
        /// <param name="_lado"></param>
        public TrianguloEquilatero(decimal _lado)
        {
            Clave = "TRIANGULO";
            CalcularArea(_lado);
            CalcularPerimetro(_lado);
        }

        private void CalcularArea(decimal _lado)
        {
            Area = ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        private void CalcularPerimetro(decimal _lado)
        {
            Perimetro = _lado * 3;
        }
    }
}
