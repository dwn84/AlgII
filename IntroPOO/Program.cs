using System;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto puntico = new Punto();
            Punto superPunto = new Punto();
            puntico.CoordenadaX = 11;
            puntico.CoordenadaZ = 33;
            puntico.TrasladarCoordenadaX();
            Console.WriteLine("Coordenada X:{0}", puntico.CoordenadaX);
            puntico.TrasladarCoordenadaY();
            puntico.TrasladarCoordenadaY();
            puntico.TrasladarCoordenadaY();
            Console.WriteLine("Coordenada Y:{0}", puntico.CoordenadaY);

            CuentaBancaria banpolombia = new CuentaBancaria();
            CuentaBancaria davivienda = new CuentaBancaria();
            CuentaBancaria conavi = new CuentaBancaria();
            banpolombia.saldo = 100000;
            banpolombia.nombreTitular = "Nerón Navarrete";
            banpolombia.numeroCuenta = 111221;
            banpolombia.Retirar();

            davivienda.saldo = 33000;
            davivienda.nombreTitular = "Esperanza Gómez";
            davivienda.numeroCuenta = 111223;
            davivienda.Consignar();
            davivienda.Consignar();


        }

        static public void aaa() { 
        
        }

        static private int aaaaa() {
            return 2;
        }
            
    }
}
