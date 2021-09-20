using System;

namespace EjemplosFuncionesProcedimientos
{
    class Program
    {
               
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el áea de un triángulo");
            //invocar la función, con sus diferentes sobrecargas(variantes)
            
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


        }

        //funciones: bloques de código que realizan una acción específica que puede
        //ser invocada en cualquier parte del código. Puede llegar a utilizar datos 
        //especificos para lograr su cometido (parámetros de entrada). Se caracteriza
        //por retornar o entregar un resultado específico. Sinónimo de Método.

        //se define de la siguiente forma
        //modificador de acceso: public - private
        //tipo de retorno: int, float, double, String....
        //nombre: verbo - concepto
        //paréntesis
        //parámetros: datos de entrada necesarios para realizar el proceso... van dentro del paréntesis
        //bloque de código
        //retorno: valor o resultado final

        static private double calcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double area = (baseTriangulo*altura)/2;
            return area;            
        }

        //Sobrecarga de funciones: Tener múltiples funciones (tienen el mismo nombre
        //se diferencia en la cantidad de parámetros de entrada y el proceso interno.

        static private double calcularAreaTriangulo(double lado)
        {
            double area = (0.433) * (lado * lado);
            return area;
        }

        static private double calcularAreaTriangulo(double lado1, double lado2, double lado3) 
        {
            double s = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt((s*(s-lado1))*(s-lado2)*(s-lado3));
            return area;
        }

        static private double calcularAreaTriangulo(double lado1, double lado2, float angulo)
        {
            double area = (0.5) * (lado1 * lado2) * Math.Sin(angulo);
            return area;
        }

    }
}
