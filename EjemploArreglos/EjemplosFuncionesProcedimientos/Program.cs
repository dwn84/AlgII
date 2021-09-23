using System;

namespace EjemplosFuncionesProcedimientos
{
    class Program
    {
               
        static void Main(string[] args)
        {

            string nom = "Edwin";
            mostrarMensajeBienvenida(nom);

            Console.WriteLine("Calcular el áea de un triángulo");
            //invocar la función, con sus diferentes sobrecargas(variantes)

            int miEdad = 19;
            //las funciones no modifican a sus parámetros
            //reciben los datos por valor
            Console.WriteLine("Edad actual: " + miEdad);
            bool resultadoValidarEdad =  validarEdad(ref miEdad);
            Console.WriteLine("Edad actual: " + miEdad);
                                 
            Console.WriteLine("Ingrese la medida del lado 1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del lado 2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida del lado 3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la base:");
            double bb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de la altura:");
            double hh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de ángulo en radianes:");
            //casting o transformación del tipo de dato
            float angulo = (float)Convert.ToDouble(Console.ReadLine());
            double areaGeneral = calcularAreaTriangulo(x1, x2, x3);
            //double areaGeneral = calcularAreaTriangulo(5, 6, 8d);
            double areaEquilatero = calcularAreaTriangulo(5);
            double total = calcularAreaTriangulo(22, 55);
            double areaConAngulo = calcularAreaTriangulo(x1,x2,angulo);
            //double areaConAngulo = calcularAreaTriangulo(5, 6, 0.0349066f);

            Console.WriteLine("EL area del triángulo rectángulo es: {0}", total);
            Console.WriteLine("EL area del triángulo equilatero es: {0}", areaEquilatero);
            Console.WriteLine("EL area del triángulo escaleno es: {0}", areaGeneral);
            Console.WriteLine("EL area del triángulo con dos lados y un ángulo entre ellos, es: {0}", areaConAngulo);


            //bool resultadoValidarEdad2 = validarEdad(33);
        }

        //funciones: bloques de código que realizan una acción específica que puede
        //ser invocada en cualquier parte del código. Puede llegar a utilizar datos 
        //especificos para lograr su cometido (parámetros de entrada). Se caracteriza
        //por retornar o entregar un resultado específico. Sinónimo de Método.

        //se define de la siguiente forma
        //modificador de acceso: public - private
        //tipo de retorno: int, float, double, String....
        //nombre: verbo - concepto - proceso
        //paréntesis
        //parámetros: datos de entrada necesarios para realizar el proceso... van dentro del paréntesis
        //bloque de código
        //retorno: valor o resultado final
        // Es posible crear una documentación para funciones y procedimientos, si se utiliza el triple slash (///) que debe estar justo antes de la definición de la función...
        /// <summary>
        /// Función para calcular el area de un triángulo rectángulo
        /// </summary>
        /// <param name="baseTriangulo">Base del triángulo</param>
        /// <param name="altura">Altura del triángulo</param>
        /// <returns>Entrega el area del triángulo</returns>
        static private double calcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            mostrarMensajeBienvenida();
            double area = (baseTriangulo*altura)/2;
            return area;            
        }

        //Sobrecarga de funciones: Tener múltiples funciones (tienen el mismo nombre
        //se diferencia en la cantidad de parámetros de entrada y el proceso interno.
        
        /// <summary>
        /// Calcular el área de un triángulo equilatero
        /// </summary>
        /// <param name="lado">Medición de uno de los lados</param>
        /// <returns></returns>
        static private double calcularAreaTriangulo(double lado)
        {
            double area = (0.433) * (lado * lado);
            return area;
        }
        /// <summary>
        /// asdf jklñ
        /// </summary>
        /// <param name="lado1">qwer</param>
        /// <param name="lado2">zxcv</param>
        /// <param name="lado3">uiop</param>
        /// <returns>hola....</returns>
        static private double calcularAreaTriangulo(double lado1, double lado2, double lado3) 
        {
            double s = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt((s*(s-lado1))*(s-lado2)*(s-lado3));
            return area;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lado1"></param>
        /// <param name="lado2"></param>
        /// <param name="angulo"></param>
        /// <returns></returns>
        static private double calcularAreaTriangulo(double lado1, double lado2, float angulo)
        {
            double area = (0.5) * (lado1 * lado2) * Math.Sin(angulo);
            return area;
        }

        /// <summary>
        /// Función que verifica que el dato cumpla la condición de que sea mayor a 10
        /// </summary>
        /// <param name="x">Dato que se va a verificar</param>
        /// <returns>Verdadero si cumple la condición o falso en caso contrario</returns>
        static private Boolean validarDato(int x) {
            if (x > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Verificar que la edad registrada es de un mayor de edad
        /// </summary>
        /// <param name="w">Años cumplidos de una persona</param>
        /// <returns>Verdadero si es mayor de 18 años, Falso, sino</returns>
        /// Si el parámetro se recibe por referencia (ref) entonces, modifica al parámetro original
        static private Boolean validarEdad(ref int w) {
            w = w * 100;
            return w >= 18;
        }
        static private string verficiarPaisResidencia(string residencia) {
            int e2 = 44;
            //En una función, también se puede invocar otra función
            validarEdad(ref e2);
            
            if (residencia == "Colombia")
            {
                return "Nacionalidad Colombiana";
            }
            else {
                return "Nacionalidad extranjero";
            }
        }

        //Procedimientos: bloques de código que realizan una acción específica que puede
        //ser invocada en cualquier parte del código. Puede llegar a utilizar datos 
        //especificos para lograr su cometido (parámetros de entrada). Se caracteriza
        //por NO retornar o entregar un resultado específico. Sinónimo de Método.
        
        //se define de la siguiente forma
        //modificador de acceso: public - private
        //tipo de retorno: void
        //nombre: verbo - concepto - proceso
        //paréntesis
        //parámetros: datos de entrada necesarios para realizar el proceso... van dentro del paréntesis
        //bloque de código

        static private void mostrarMensajeBienvenida() {
            Console.WriteLine("Hello World, Welcome home!");
        }
        /// <summary>
        /// Imprimir en consola un mensaje de bienvenida en Inglés.
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        static private void mostrarMensajeBienvenida(string nombre)
        {
            Console.WriteLine("Hello {0}, Welcome home!",nombre);
        }
    }
}
