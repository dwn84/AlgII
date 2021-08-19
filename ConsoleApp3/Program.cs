using System;
using System.Collections;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int na;
            //solicitar el número total de datos
            Console.WriteLine("Ordenamiento de datos");
            Console.WriteLine("Ingrese la cantidad total de datos:");
            na = Convert.ToInt32(Console.ReadLine());
            //crear un nuevo arreglo
            int[] daticos = new int[na];
            //recibir dato por dato y almacenarlo en arreglo
            for (int dd = 0; dd < na; dd++) {
                Console.WriteLine("Ingrese un valor:");
                daticos[dd] = Convert.ToInt32(Console.ReadLine());
            }

            //método de ordenación de datos en arreglo
            //Burbuja: Bubblesort
            //https://es.wikipedia.org/wiki/Ordenamiento_de_burbuja
            int aux;
            for (int z = 1; z < daticos.Length; z++) {
                for (int v = 0; v < (daticos.Length - z); v++) {
                    if (daticos[v] > daticos[v + 1])
                    {//intercambio de datos entre dos posiciones
                        aux = daticos[v];
                        daticos[v] = daticos[v + 1];
                        daticos[v + 1] = aux;                        
                    }
                }
            }
            //mostrar los datos ordenados
            Console.WriteLine("Datos ordenados");
            for (int cont = 0; cont < daticos.Length; cont++)
            {
                Console.Write(daticos[cont]);

            }
            int x;//definir la variable tipo entero
            int y = 99;//define la variable y la inicializa
            int a, b=99, c=98, d;
            double m;//definir la variable de tipo real
            String nombre;//Definir la variable de tipo caracter
            Boolean encendido;//tipo lógico: true - false
            int[] edades = new int[] {19,19,29,21,23,33,44,11,9};//definición e instancia del objeto
            edades[0] = 19;
            Console.WriteLine("***********");
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

            //condicional en corto circuito (Y)

            if (edades[0] >= 18 && (imc > 18.5 && imc < 24.9)) { 
                
            }

            //condicional en corto circuito (O)

            if (edades[0] >= 18 || (imc > 18.5 && imc < 24.9))
            {

            }

            String estadoCivil = "Casado";

            if (estadoCivil == "Casado")
            {

            }
            else if (estadoCivil == "Soltero")
            {

            }
            else if (estadoCivil == "Divorciado")
            {

            }
            else if (estadoCivil == "Viudo")
            {

            }
            else { 
            
            }

            //la anterior validación se puede simplificar con un switch o según

            switch (estadoCivil) {
                case "Casado": {
                        //
                        break; 
                    }
                case "Soltero":
                    {
                        //
                        break;
                    }
                case "Divorciado":
                    {
                        //
                        break;
                    }
                case "Viudo":
                    {
                        //
                        break;
                    }
                default: {
                        //
                        break;
                    }
            }
            //Ciclo Para
            for (int p = 0;p<=10;p++)  {
                Console.WriteLine("Hola mundo: " + p);
                
            }

            //Ciclo Para
            for (int q = 0; q < 9; q++)
            {
                Console.WriteLine(edades[q]);

            }
            Console.WriteLine("Comportamiento del contador");
            for (int s = 0; s < 9; s++)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Comportamiento del contador con incremento de 3 en 3");
            for (int g = 0; g < 9; g += 3)
            {
                Console.WriteLine(g);
            }
            //acceder a los elementos de un vector - arreglo unidimensional

            int j = 0;
            //Ciclo Mientras
            while (j <= 10) {

                j++;
            }

            //Caso de amortización:
            long A;//valor del préstamo
            double i;//valor del interes mensual
            double n;//meses para pagar el préstamo
            double R;//mensualidad o renta
            Console.WriteLine("Ingrese el valor del prestamo");
            A = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del interes");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de meses");
            n = Convert.ToDouble(Console.ReadLine());

            //calcular la mensualidad
            R = (A*i) / (1-(Math.Pow(1+i,-n)));
            //variables para amortización, interese mensual, saldo mensual
            Console.WriteLine("El valor de la mensualidad es:" + R);
            Console.WriteLine("Periodo\tRenta\t\t\tInteres\tAmortizacion\tSaldo");
            for (int k = 1; k <= n; k++) {
                //modificar amortización, interese mensual, saldo mensual
                Console.WriteLine(k+ "\t"+R);
            }
            //realizar recorrido de arreglos
            //for especializado en colecciones (estructuras de datos)
            foreach(int data in edades) {
                Console.WriteLine("Contenido del arreglo:" + data);
            }
            Console.WriteLine("Recorrido con ciclo mientras, validando con la longitud del arreglo (propiedad Length)");
            int u = 0;
            while (u < edades.Length) {
                Console.WriteLine(edades[u]);
                u++;
            }
            //Ciclo hacer - mientras
            Console.WriteLine("Recorrido con ciclo hacer - mientras");
            int w = 0;
            do {
               Console.WriteLine(edades[w]);
                w++;
            } while (w < edades.Length);

            //Recorrido con una enumeración de posición del arreglo
            Console.WriteLine("Recorrido con enumeración");
            IEnumerator indiceContenido = edades.GetEnumerator();
            while (indiceContenido.MoveNext()) {
                Console.WriteLine(indiceContenido.Current);
            }

        }

    }
}
