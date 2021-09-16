using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumAleatorio = new Random();
            int[] NumA = new int[9];
            /*
                        NumA[0] = NumAleatorio.Next(1, 22);
                        NumA[1] = NumAleatorio.Next(1, 22);
                        NumA[2] = NumAleatorio.Next(1, 22);
                        NumA[3] = NumAleatorio.Next(1, 22);
                        NumA[4] = NumAleatorio.Next(1, 22);
                        NumA[5] = NumAleatorio.Next(1, 22);
                        NumA[6] = NumAleatorio.Next(1, 22);
                        NumA[7] = NumAleatorio.Next(1, 22);
                        NumA[8] = NumAleatorio.Next(1, 22);
                        */
            int n = 9;
            for (int i=0;i<n;i++) {
                NumA[i] = NumAleatorio.Next(1, 22);
                Console.Write(NumA[i] + " ");
            }

            Console.WriteLine(" Datos invertidos ");
            /*
            for (int i = 8; i >= 0; i--)
            {             
                Console.Write(NumA[i] + " ");
            }
            */
        
            int temp;
            int j = (n - 1);

            for (int i=0;i<(n/2);i++) {
                temp = NumA[i];
                NumA[i] = NumA[j];
                NumA[j--] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(NumA[i] + " ");
            }


            //Adjunta de la matriz
            var NumAle = new Random();
            int Filas;
            int Columnas;
            Filas = 2;
            Columnas = 2;


            Console.WriteLine("La adjunta de la matriz");
            Console.WriteLine("");
            Console.WriteLine("");

            int[,] dato1 = new int[Filas, Columnas];
            int[,] dato2 = new int[Filas, Columnas];

            dato1[0, 0] =1;
            dato1[0, 1] =2;
            dato1[1, 0] =-2;
            dato1[1, 1] =3;
            int a = 1, b = 1;//indices decrementales para el proceso
            for (int i = 0; i < Filas; i++)
            {
                for (int k = 0; k < Columnas; k++)
                {
                    //dato1[i, k] = NumAle.Next(1, 22);

                    Console.Write("{0}\t", dato1[i, k]);

                }
                for (int k = 0; k < Columnas; k++)
                {
                    dato2[i, k] = (int)Math.Pow(-1, i + k) * dato1[a, b];
                    b--;
                }
                a--;
                b = 1;
                for (int k = 0; k < Columnas; k++)
                {
                    Console.Write("\t{0}", dato2[i, k]);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }
    }
}
