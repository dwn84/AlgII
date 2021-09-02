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

            while (opciones!=4) {
                Console.WriteLine("Operaciones entre matrices");
                Console.WriteLine("1. Sumar dos matrices");
                Console.WriteLine("2. Restar dos matrices");
                Console.WriteLine("3. Multiplicar dos matrices");
                Console.WriteLine("4. salir");
                Console.Write("Ingrese un número de 1 a 4 para realizar una acción: ");
                opciones = Convert.ToInt16(Console.ReadLine());
                if (opciones > 4 || opciones < 1)
                {
                    Console.WriteLine("Opción inválida");
                }
                else {

                    if (opciones == 4)
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
                                            for(int k=0;k< columnas; k++)
                                            {
                                                suma += datosM1[i,k] * datosM2[k, j];
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


                        }
                    }
                }
               


            }
            
            
        }
    }
}
