using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), "es-ES"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), "en-EN"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, "es-ES");

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Cuadrado( 1),
                new Cuadrado( 3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, "en-EN");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "en-EN");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero(9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "es-ES");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), "it-IT"));
        }

        [TestCase]
        public void NuevoTestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste vide de formes!</h1>",
                ReporteFormaGeometrica.Imprimir(new List<FormaGeometrica>(), "fr-FR"));
        }

        [TestCase]
        public void NuevoTestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero(9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "it-IT");

            Assert.AreEqual(
                 "<h1>Rapporto sui moduli</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaConMasTiposEnFrances()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero(9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "fr-FR");

            Assert.AreEqual(
                "<h1>Rapport sur les formes</h1>2 Carrés | Surface 29 | Périmètre 28 <br/>2 Cercles | Surface 13,01 | Périmètre 18,06 <br/>3 Triangles | Surface 49,64 | Périmètre 51,6 <br/>TOTAL:<br/>7 formes Périmètre 97,66 Surface 91,65",
                resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaConMasTiposIdiomaNoExistente()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero(9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "gr-GR");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }
        [TestCase]
        public void NuevoTestResumenListaConUnCuadradoenItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, "it-IT");

            Assert.AreEqual("<h1>Rapporto sui moduli</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTALE:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaConUnTrapecioenItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(4, 2, 1, 3) };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, "it-IT");

            Assert.AreEqual("<h1>Rapporto sui moduli</h1>1 Trapezio | Area 9 | Perimetro 8 <br/>TOTALE:<br/>1 forma Perimetro 8 Area 9", resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaConMasTiposIncluidosRectanguloyTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Rectangulo(5,2.9m),
                new Cuadrado(5),
                new Circulo( 3),
                new TrianguloEquilatero( 4),
                new Cuadrado( 2),
                new TrianguloEquilatero( 9),
                new Circulo( 2.75m),
                new TrianguloEquilatero( 4.2m),
                new Trapecio(4, 2, 1, 3),
                new Rectangulo(6,2),
                new Trapecio(4, 2, 1, 3)
            };

            var resumen = ReporteFormaGeometrica.Imprimir(formas, "en-EN");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Rectangles | Area 26,5 | Perimeter 31,8 <br/>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Trapezoids | Area 18 | Perimeter 16 <br/>TOTAL:<br/>11 shapes Perimeter 145,46 Area 136,15",
                resumen);
        }

        [TestCase]
        public void NuevoTestResumenListaConUnTrapecioenIdiomaVacio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(4, 2, 1, 3) };

            var resumen = ReporteFormaGeometrica.Imprimir(cuadrados, "idioma-vacio");

            Assert.AreEqual("CABECERA*1 TRAPECIO* | AREA* 9 | PERIMETRO* 8 <br/>TOTAL*:<br/>1 FORMA* PERIMETRO* 8 AREA* 9", resumen);
        }
    }
}
