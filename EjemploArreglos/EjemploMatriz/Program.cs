using System;

namespace EjemploMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 
            * La empresa UXZ Ltda requiere controlar la existencia de 17 productos, 
            * los cuales se almacenan en un vector A, mientras que los pedidos 
            * de los clientes de estos productos se almacenan en un vector B. 
            * Se requiere generar un tercer vector C con base en los anteriores 
            * que represente lo que se requiere comprar para mantener el stock 
            * de inventario, para esto se considera lo siguiente: si los valores 
            * correspondientes de los vectores A y B son iguales se almacena 
            * este mismo valor, si el valor de B es mayor que el de A se 
            * almacena el doble de la diferencia entre B y A, si se da el caso 
            * de que A es mayor que B, se almacena B, que indica lo que se 
            * requiere comprar para mantener el stock de inventario. 
            * Realice el algoritmo que permita almacenar la información 
            * pertinente en los vectores A, B y C. 

            Mostrar:
            Listado de datos originales
            Listado de datos ordenados por pedidos de mayor a menor
            */
            int n = 3;//representa el total de productos
            string[] nombreProductos = new string[n];
            //matriz(tabla) de datos
            int[,] datosNumericos = new int[n,3];
            //La columna 0 de la tabla almacenará las existencias.
            //La columna 1 de la tabla almacenará los pedidos.
            //La columna 2 de la tabla almacenará el stock.
            //las filas representan cada producto.

            //solicitar datos
            for (int i = 0; i < nombreProductos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto:");
                nombreProductos[i] = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad de existencias del producto:");
                datosNumericos[i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pedidos del producto:");
                datosNumericos[i, 1] = Convert.ToInt32(Console.ReadLine());
                //validar el cálculo del stock
                if (datosNumericos[i, 0] == datosNumericos[i, 1])
                {
                    datosNumericos[i, 2] = datosNumericos[i, 0];
                }
                else if (datosNumericos[i, 1] > datosNumericos[i, 0])
                {
                    datosNumericos[i, 2] = 2 * (datosNumericos[i, 1] - datosNumericos[i, 0]);
                }
                else
                {
                    datosNumericos[i, 2] = datosNumericos[i, 1];
                }
            }


                //Listado de datos originales
                //Titulares
                Console.WriteLine("Producto    Existencias   Pedidos    Stock");
                for (int i = 0; i < nombreProductos.Length; i++)
                {
                    Console.WriteLine(nombreProductos[i]
                                        + "    "
                                        + datosNumericos[i,0]
                                        + "    "
                                        + datosNumericos[i,1]
                                        + "    "
                                        + datosNumericos[i,2]);

                }
            int aux;
            string auxNombreProducto;
            Console.WriteLine("");
            //ordenar la matriz de datos.
            for (int z = 1; z < n; z++)
            {
                for (int v = 0; v < (n - z); v++)
                {
                    if (datosNumericos[v, 1] < datosNumericos[(v+1), 1])
                    {//intercambio de datos entre dos posiciones de pedidos
                        aux = datosNumericos[v, 1];
                        datosNumericos[v, 1] = datosNumericos[(v + 1), 1];
                        datosNumericos[(v + 1), 1] = aux;

                        aux = datosNumericos[v, 0];
                        datosNumericos[v, 0] = datosNumericos[(v+1), 0];
                        datosNumericos[(v + 1), 0] = aux;

                        aux = datosNumericos[v, 2];
                        datosNumericos[v, 2] = datosNumericos[(v + 1), 2];
                        datosNumericos[(v + 1), 2] = aux;

                        auxNombreProducto = nombreProductos[v];
                        nombreProductos[v] = nombreProductos[v + 1];
                        nombreProductos[v + 1] = auxNombreProducto;


                    }
                }
            }
            Console.WriteLine("");



        }
    }
}
