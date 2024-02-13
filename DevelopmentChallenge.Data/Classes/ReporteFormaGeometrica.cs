/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.Formas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ReporteFormaGeometrica
    {
        public static string Imprimir(List<FormaGeometrica> formas, string idioma)
        {
            Idioma idiomaSolicitado = new Idioma(idioma);

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idiomaSolicitado.Traducir("LISTAVACIA"));
            }
            else
            {
                int totalFormas = formas.Count;
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idiomaSolicitado.Traducir("CABECERA"));

                var r = formas.GroupBy(t => t.GetType())
                            .Select(t => new
                            {
                                t.First().Clave,
                                Cantidad = t.Count(),
                                Area = t.Sum(ta => ta.Area),
                                Perimetro = t.Sum(ta => ta.Perimetro)
                            }).ToList();

                r.ForEach(row => sb.Append($"{row.Cantidad} {idiomaSolicitado.Traducir(row.Clave, row.Cantidad) } | {idiomaSolicitado.Traducir("AREA")} {row.Area:#.##} | {idiomaSolicitado.Traducir("PERIMETRO")} {row.Perimetro:#.##} <br/>"));

                sb.Append($"{idiomaSolicitado.Traducir("TOTAL")}:<br/>{totalFormas} {idiomaSolicitado.Traducir("FORMA", totalFormas)} {idiomaSolicitado.Traducir("PERIMETRO")} {formas.Sum(d => d.Perimetro):#.##} {idiomaSolicitado.Traducir("AREA")} {formas.Sum(d => d.Area):#.##}");
            }

            return sb.ToString();
        }
    }
}
