
# Coding Challenge

### El problema

Tenemos un método que genera un reporte en base a una colección de formas geométricas, procesando algunos datos para presentar como reporte información extra. La firma del método es: 
```csharp
public static string Imprimir(List<FormaGeometrica> formas, int idioma)
```
 y se encuentra ubicado en la clase FormaGeometrica.cs

En consecuencia a como fue codificado este módulo, al equipo de desarrollo se le hace muy difícil el poder agregar una nueva forma geométrica o implementar la impresión del reporte en otro idioma. Nos gustaría poder dar soporte para que en el futuro los desarrolladores puedan agregar otros tipos de formas y obtener el reporte en otros idiomas con más agilidad. ¿Nos podrías ayudar a refactorizar la clase FormaGeometrica?

Acompañando al proyecto encontrarás una serie de tests unitarios (librería NUnit) que describen el comportamiento actual del método Imprimir. Se puede modificar absolutamente cualquier cosa del código y de los tests, con la única condición que los tests deben pasar correctamente al entregar la solución.
Dentro del código hay un TODO con los requerimientos técnicos y del usuario a satisfacer.

Se agradece también la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada.

### Tecnología
La solución fue creada con Visual Studio 2019, consta de dos proyectos en C# sobre .NET Framework 4.6.2, uno específico para Tests y otro que contiene el negocio a mejorar, el siguiente ZIP que le ofrecemos contiene lo mencionado antes y los packages de nuget:

## Solución propuesta

### Idiomas

Se organizó el código para que un nuevo idioma pueda incorporarse directamente agregando un json con la forma Clave-Valor donde cada clave es una de las frases o palabras que se desea traducir.

En la carpeta Traducciones se deben incluir/actualizar los idiomas a considerar. El nombre del archivo se definió con la notación internacional: es-ES.json, en-EN.json

A modo de ejemplo se detalla la forma del Json para el idioma Ingles:
```json
{
  "CABECERA": "<h1>Shapes report</h1>",
  "TOTAL": "TOTAL",
  "FORMA": "shape",
  "FORMA_PLURAL": "shapes",
  "PERIMETRO": "Perimeter",
  "AREA": "Area",
  "LISTAVACIA": "<h1>Empty list of shapes!</h1>",
  "CUADRADO": "Square",
  "CUADRADO_PLURAL": "Squares",
  "TRIANGULO": "Triangle",
  "TRIANGULO_PLURAL": "Triangles",
  "CIRCULO": "Circle",
  "CIRCULO_PLURAL": "Circles",
  "TRAPECIO": "Trapezoid",
  "TRAPECIO_PLURAL": "Trapezoids",
  "RECTANGULO": "Rectangle",
  "RECTANGULO_PLURAL": "Rectangles"
}
```
De acuerdo a lo requerido se incorporó el idioma italiano y frances creando sus respectivos casos de prueba.

Además se contemplaron otras situaciones:

* Si el idioma solicitado no existe, se utiliza el Inglesz como fallback

* Si alguna clave no existe en el idioma solicitado, se muestra el texto de la clave con un \* para identificarla.

* Si las claves pueden ser usadas en singular o plural, se incorporan con el mismo nombre y el sufijo _PLURAL. En el código se contempla la traducción con un parametro de cantidad para administrar cual de debe mostrar.


### Formas

Se organizó el código para que la incorporación de una nueva forma sea sencilla. Se debe crear una clase que implemente la clase abtracta FormasGeometricas y definirle los 3 atributos requeridos: Clave, Area y Perimetro.
Una vez creada esa clase y ajustadas las propiedades, ya puede ser incorporada en la lista de Formas que recibe el metodo de impresión
A modo de ejmplo se presenta la implementación de la clase Rectangulo:
```csharp
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
```	
### Test Unitarios

Se incorporarón 9 pruebas unitarias para las casuísticas incorporadas.Las miesmas se identificaron con NuevoTest como prefijo.
