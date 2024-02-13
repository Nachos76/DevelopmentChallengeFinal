using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public abstract class FormaGeometrica
    {
        public abstract string Clave { get; set; }
        public abstract decimal Area { get; set; }
        public abstract decimal Perimetro { get; set; }
    }
}
