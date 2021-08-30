using System;

namespace OperacionesMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int opciones = 1;
            int filas, columnas;

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
                    switch (opciones) {
                        case 1:
                            //Sumar dos matrices
                              Console.Write("Ingrese la cantidad de filas de las tablas para la suma: ");
                            filas = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Ingrese la cantidad de columnas de las tablas para la suma: ");
                            columnas = Convert.ToInt16(Console.ReadLine());
                            int[,] datos1 = new int[filas, columnas];
                            int[,] datos2 = new int[filas, columnas];
                            int[,] datosR = new int[filas, columnas];

                            //llenar la tabla de datos con números aleatorios

                            var numeroAleatorio = new Random();

                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    datos1[i,j]= numeroAleatorio.Next(30, 99);
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
                        case 3:
                        case 4:
                            Console.Write("Fin del programa");
                            break;


                    }
                }
               


            }
            
            
        }
    }
}
