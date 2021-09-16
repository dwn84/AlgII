using System;

namespace EjemplosFuncionesProcedimientos
{
    class Program
    {
               
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //invocar la función
            double total = calcularAreaTriangulo(22, 55);
            Console.WriteLine("EL area del triángulo es: {0}", total);
           
        }

        //funciones: bloques de código que realizan una acción específica que puede
        //ser invocada en cualquier parte del código. Puede llegar a utilizar datos 
        //especificos para lograr su cometido (parámetros de entrada). Se caracteriza
        //por retornar o entregar un resultado específico. Sinónimo de Método.

        //se define de la siguiente forma
        //modificador de acceso: public - private
        //tipo de retorno: int, float, double, String....
        //nombre: verbo
        //paréntesis
        //parámetros: datos de entrada necesarios para realizar el proceso... van dentro del paréntesis
        //bloque de código
        //retorno: valor o resultado final

        static private double calcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double area = (baseTriangulo*altura)/2;
            return area;            
        }



    }
}
