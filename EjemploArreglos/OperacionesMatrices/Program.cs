using System;

namespace OperacionesMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int opciones = 1;
            int filas, columnas;
            var numeroAleatorio = new Random();
           
            while (opciones!=5) {
                Console.WriteLine("Operaciones entre matrices");
                Console.WriteLine("1. Sumar dos matrices");
                Console.WriteLine("2. Restar dos matrices");
                Console.WriteLine("3. Multiplicar dos matrices");
                Console.WriteLine("4. Calcular determinante dos matrices");
                Console.WriteLine("5. salir");
                Console.Write("Ingrese un número de 1 a 5 para realizar una acción: ");
                opciones = Convert.ToInt16(Console.ReadLine());
                if (opciones > 5 || opciones < 1)
                {
                    Console.WriteLine("Opción inválida");
                }
                else {

                    if (opciones == 5)
                    {
                        Console.WriteLine("Fin del programa");
                    }
                    else
                    {

                        switch (opciones)
                        {
                            case 1://caso de la suma
                                   //Sumar dos matrices

                                Console.Write("Ingrese la cantidad de filas de las tablas para la suma: ");
                                filas = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de columnas de las tablas para la suma: ");
                                columnas = Convert.ToInt16(Console.ReadLine());
                                int[,] datos1 = new int[filas, columnas];
                                int[,] datos2 = new int[filas, columnas];
                                int[,] datosR = new int[filas, columnas];

                                //llenar la tabla de datos con números aleatorios



                                for (int i = 0; i < filas; i++)
                                {
                                    for (int j = 0; j < columnas; j++)
                                    {
                                        datos1[i, j] = numeroAleatorio.Next(30, 99);
                                        datos2[i, j] = numeroAleatorio.Next(30, 99);
                                        datosR[i, j] = datos1[i, j] + datos2[i, j];
                                        Console.Write("{0}\t", datos1[i, j]);
                                    }

                                    for (int j = 0; j < columnas; j++)
                                    {
                                        Console.Write("\t{0}", datos2[i, j]);
                                    }

                                    for (int j = 0; j < columnas; j++)
                                    {
                                        Console.Write("\t{0}", datosR[i, j]);
                                    }
                                    Console.WriteLine("");
                                }
                                /*
                                Console.WriteLine("El número aleatorio es:" + n);
                                Console.WriteLine("El número aleatorio es:" + n + " y su doble es: " + (n * 2));
                                //otra forma de generar un mensaje que combina textos y variables
                                Console.WriteLine("El número aleatorio es: {0} y su doble es:{1}", n);
                                Console.WriteLine("El número aleatorio es: {0} y su doble es:{1}",n,(n*2));
                                Console.WriteLine("El número aleatorio es: {0} y su doble es:{1} y su triple es: {2}", n, (n * 2), (n * 3));
                                */
                                break;
                            case 2:
                                //caso de la resta
                                //Restar dos matrices

                                Console.Write("Ingrese la cantidad de filas de las tablas para la resta: ");
                                filas = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de columnas de las tablas para la resta: ");
                                columnas = Convert.ToInt16(Console.ReadLine());
                                int[,] datosR1 = new int[filas, columnas];
                                int[,] datosR2 = new int[filas, columnas];
                                int[,] datosT2 = new int[filas, columnas];

                                //llenar la tabla de datos con números aleatorios                                

                                for (int i = 0; i < filas; i++)
                                {
                                    for (int j = 0; j < columnas; j++)
                                    {
                                        datosR1[i, j] = numeroAleatorio.Next(30, 99);
                                        datosR2[i, j] = numeroAleatorio.Next(30, 99);
                                        datosT2[i, j] = datosR1[i, j] - datosR2[i, j];
                                        Console.Write("{0}\t", datosR1[i, j]);
                                    }

                                    for (int j = 0; j < columnas; j++)
                                    {
                                        Console.Write("\t{0}", datosR2[i, j]);
                                    }

                                    for (int j = 0; j < columnas; j++)
                                    {
                                        Console.Write("\t{0}", datosT2[i, j]);
                                    }
                                    Console.WriteLine("");
                                }
                                break;
                            case 3:
                                //caso de la multiplicación
                                //Multiplicar  dos matrices
                                int filasM;
                                Console.Write("Ingrese la cantidad de filas de la tabla 1: ");
                                filasM = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de columnas de la tabla 1: ");
                                columnas = Convert.ToInt16(Console.ReadLine());
                                int[,] datosM1 = new int[filasM, columnas];

                                int columnasM;
                                Console.Write("Ingrese la cantidad de filas de la tabla 2: ");
                                filas = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de columnas de la tabla 2: ");
                                columnasM = Convert.ToInt16(Console.ReadLine());
                                int[,] datosM2 = new int[filas, columnasM];

                                //validar si el número de columnas de datosM1 coincide con el número de filas de datosM2
                                if (columnas == filas)
                                {
                                    //Matriz de resultados
                                    int[,] datosTM = new int[filasM, columnasM];

                                    //datos de prueba
                                    datosM1[0, 0] = 2;
                                    datosM1[0, 1] = 3;
                                    datosM1[1, 0] = 4;
                                    datosM1[1, 1] = 5;

                                    datosM2[0, 0] = 9;
                                    datosM2[0, 1] = 8;
                                    datosM2[1, 0] = 7;
                                    datosM2[1, 1] = 6;
                                    //Aplicar el producto
                                    /*
                                     * https://es.wikipedia.org/wiki/Matriz_(matem%C3%A1ticas)#Producto_de_matrices
                                     */
                                    int suma = 0;
                                    for (int i = 0; i < filasM; i++)
                                    {
                                        for (int j = 0; j < columnasM; j++)
                                        {
                                            for (int k = 0; k < columnas; k++)
                                            {
                                                suma += datosM1[i, k] * datosM2[k, j];
                                            }
                                            datosTM[i, j] = suma;
                                            suma = 0;
                                            Console.Write("{0}\t", datosM1[i, j]);
                                        }

                                        for (int j = 0; j < columnas; j++)
                                        {
                                            Console.Write("\t{0}", datosM2[i, j]);
                                        }

                                        for (int j = 0; j < columnas; j++)
                                        {
                                            Console.Write("\t{0}", datosTM[i, j]);
                                        }
                                        Console.WriteLine("");
                                    }
                                }
                                else
                                {
                                    Console.Write("No es posible realizar la multiplicación, los tamaños no cumplen requisito");
                                }


                                break;
                            case 4:
                                //calcular determinante
                                //metodo de eliminación gaussiana
                                //https://matrixcalc.org/es/det.html#determinant-Gauss(%7B%7B3,8,1,1,1%7D,%7B8,5,2,1,1%7D,%7B5,5,8,1,1%7D,%7B1,1,1,1,1%7D,%7B1,1,1,1,1%7D%7D)
                                Console.Write("Ingrese la cantidad de filas de la tabla");
                                int Ultimafila = Convert.ToInt16(Console.ReadLine());
                                Console.Write("Ingrese la cantidad de columnas de la tabla");
                                columnas = Convert.ToInt16(Console.ReadLine());
                                double[,] datosD = new double[Ultimafila, columnas];
                                if (Ultimafila == columnas)
                                {
                                    Console.WriteLine("Tabla original de datos");

                                    for (int i = 0; i < Ultimafila; i++)
                                    {
                                        for (int j = 0; j < columnas; j++)
                                        {
                                            datosD[i, j] = numeroAleatorio.Next(1, 9);
                                            Console.Write("{0}\t", datosD[i, j]);
                                        }
                                        Console.WriteLine("");
                                    }

                                    double factor;
                                    int penultima = Ultimafila - 1;

                                    for (int i = 0; i < penultima; i++)
                                    {
                                        //Realizar operaciones con las filas siguientes a la actual
                                        for (int filasSiguientes = i + 1; filasSiguientes < Ultimafila; filasSiguientes++) {
                                            //calcular que número es necesario para multiplicar al elemento de la diagonal principal
                                            //para sumarlo al elemento de las otras filas para obtener una suma igual a cero.
                                            factor = datosD[filasSiguientes, i] / datosD[i, i];
                                            //realizar operaciones de resta con todos los datos de las otras columnas
                                            for (int j = 0; j < columnas; j++) {
                                                datosD[filasSiguientes, j] = datosD[filasSiguientes, j] - (factor * datosD[i, j]);
                                            }
                                        }
                                    }

                                    Console.WriteLine("Tabla transformada a matriz triangular superior");

                                    for (int i = 0; i < Ultimafila; i++)
                                    {
                                        for (int j = 0; j < columnas; j++)
                                        {
                                            Console.Write("{0}\t", datosD[i, j]);
                                        }
                                        Console.WriteLine("");
                                    }

                                    double determinante = 1;
                                    //Recorrer la diagonla principal y multiplicar todos sus valores
                                    for (int i = 0; i < Ultimafila; i++) {
                                        determinante = determinante * datosD[i, i];
                                    }
                                    Console.WriteLine("El valor del determinante es:{0}", determinante);


                                }
                                else
                                {
                                    Console.Write("No es posible calcular el determinante, la matriz debe ser cuadrada");
                                }
                                break;


                        }
                    }
                }
               


            }
            
            
        }
    }
}
