using System;

namespace EjemploArreglos
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
            //Console.WriteLine("Ingrese la cantidad de productos:");
            //n = Convert.ToInt32(Console.ReadLine());
            int[] existencias = new int[n];//Valor conocido
            int[] pedidos = new int[n];//Valor conocido
            int[] stock = new int[n];//Valos calculado
            string[] nombreProductos = new string[n];
            //solicitar datos

            for (int i = 0; i < nombreProductos.Length; i++) {
                Console.WriteLine("Ingrese el nombre del producto:");
                nombreProductos[i] = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad de existencias del producto:");
                existencias[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pedidos del producto:");
                pedidos[i] = Convert.ToInt32(Console.ReadLine());
                //validar el cálculo del stock
                if (existencias[i] == pedidos[i])
                {
                    stock[i] = existencias[i];
                }
                else if (pedidos[i] > existencias[i])
                {
                    stock[i] = 2 * (pedidos[i] - existencias[i]);
                }
                else {
                    stock[i] = pedidos[i];
                }
                Console.WriteLine("");//Punto de depuración: prueba de escritorio
            }
            //Listado de datos originales
            //Titulares
            Console.WriteLine("Producto    Existencias   Pedidos    Stock");
            for (int i = 0; i < nombreProductos.Length; i++)
            {
                Console.WriteLine(nombreProductos[i]
                                    + "    " 
                                    + existencias[i]
                                    + "    "
                                    + pedidos[i]
                                    + "    "
                                    +stock[i]);

            }

            //Ordenar los datos por pedidos

            //método de ordenación de datos en arreglo
            //Burbuja: Bubblesort
            //https://es.wikipedia.org/wiki/Ordenamiento_de_burbuja
            int aux;
            string auxNombreProducto;
            for (int z = 1; z < pedidos.Length; z++)
            {
                for (int v = 0; v < (pedidos.Length - z); v++)
                {
                    if (pedidos[v] < pedidos[v + 1])
                    {//intercambio de datos entre dos posiciones de pedidos
                        aux = pedidos[v];
                        pedidos[v] = pedidos[v + 1];
                        pedidos[v + 1] = aux;

                        aux = existencias[v];
                        existencias[v] = existencias[v + 1];
                        existencias[v + 1] = aux;

                        aux = stock[v];
                        stock[v] = stock[v + 1];
                        stock[v + 1] = aux;

                        auxNombreProducto = nombreProductos[v];
                        nombreProductos[v] = nombreProductos[v + 1];
                        nombreProductos[v + 1] = auxNombreProducto;


                    }
                }
            }

            //Listado ordenado por pedidos
            //Titulares
            Console.WriteLine("Producto    Existencias   Pedidos    Stock");
            for (int i = 0; i < nombreProductos.Length; i++)
            {
                Console.WriteLine(nombreProductos[i]
                                    + "    "
                                    + existencias[i]
                                    + "    "
                                    + pedidos[i]
                                    + "    "
                                    + stock[i]);

            }

        }
     }
}
