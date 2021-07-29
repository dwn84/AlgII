using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;//definir la variable tipo entero
            int y = 99;//define la variable y la inicializa
            int a, b=99, c=98, d;
            double m;//definir la variable de tipo real
            String nombre;//Definir la variable de tipo caracter
            Boolean encendido;//tipo lógico: true - false
            int[] edades = new int[] {19,19,29,21,23,33,44,11,9};//definición e instancia del objeto
            edades[0] = 19;
            Console.WriteLine(edades[8]);
            double[] notas = new double[15];
            //Console.WriteLine("Ingrese su nombre:");
            //leer nombre
            //nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese un valor para la variable b:");
            //leer b
            //b = Convert.ToInt32(Console.ReadLine());
            int contadorMayoresEdad = 44;
            int acumuladorEdades = 0;
            a = b + c;
            //Console.WriteLine(edades[0]%2);
            Console.WriteLine("Resultado del incremento");
            Console.WriteLine(contadorMayoresEdad++);

            acumuladorEdades = acumuladorEdades + edades[0];
            acumuladorEdades += edades[0];

            acumuladorEdades = acumuladorEdades - edades[1];
            acumuladorEdades -= edades[1];

            acumuladorEdades = acumuladorEdades * edades[2];
            acumuladorEdades *= edades[1];

            acumuladorEdades = acumuladorEdades + edades[3];

            //Ejemplo de condicional doble
            if (edades[0] >= 18)
            {
                Console.WriteLine("Bienvenido a bordo");
                //contadorMayoresEdad = contadorMayoresEdad + 1;
                contadorMayoresEdad++;//post incremento
                ++contadorMayoresEdad;//pre incremente
            }
            else
            {
                Console.WriteLine("No se permite el ingreso");
            }

            String mensaje = "";
            if (edades[0] >= 18)
            {
                mensaje = "Bienvenido a bordo";                
            }
            else
            {
                mensaje = "No se permite el ingreso";
            }
            Console.WriteLine(mensaje);


            //reescribir el condicional anterior con el 
            //operador ternario: https://es.wikipedia.org/wiki/Operador_ternario

            mensaje = (edades[0] >= 18) ? "Bienvenido a bordo" : "No se permite el ingreso";

            //ejemplo de condicional anidado
            //verifica si un dato se encuentra en un rango determinado
            // clasificar la edad de una persona, indicando si
            //es niño, adolescente, adulto, tercera edad
            if (edades[0] < 12)
            {
                Console.WriteLine("Niño");
            }
            else if (edades[0] < 18)
            {
                Console.WriteLine("adolescente");
            }
            else if (edades[0] < 60)
            {
                Console.WriteLine("adulto");
            }
            else {
                Console.WriteLine("tercera edad");
            }

            //Calcular el índice de masa corporal de una persona.
            double peso, estatura, imc;
            string clasificacion;
            Console.WriteLine("Calculadora IMC");
            Console.WriteLine("Ingrese su peso en kilogramos:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese su estatura en metros");
            estatura = Convert.ToDouble(Console.ReadLine());

            imc = (peso) / (estatura * estatura);

            if (imc < 18.5)
            {
                clasificacion = "bajo peso";
            }
            else if (imc < 24.9)
            {
                clasificacion = "peso normal";
            }
            else if (imc < 29.9)
            {
                clasificacion = "sobrepeso";
            }
            else
            {
                clasificacion = "Obesidad";
            }
            Console.WriteLine(clasificacion);
        }

    }
}
