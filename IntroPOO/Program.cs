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
            banpolombia.Retirar(10000);
            banpolombia.MostrarSaldoTotal();
            banpolombia.Retirar(20000);
            banpolombia.MostrarSaldoTotal();
            banpolombia.Retirar(30000);
            banpolombia.MostrarSaldoTotal();
            banpolombia.Retirar(1000);
            banpolombia.MostrarSaldoTotal();
            banpolombia.Retirar(9999);
            banpolombia.MostrarSaldoTotal();
            banpolombia.Retirar(3000);


            davivienda.saldo = 33000;
            davivienda.nombreTitular = "Esperanza Gómez";
            davivienda.numeroCuenta = 111223;
            davivienda.saldo = 333333333;
            davivienda.Retirar(11111111);
            davivienda.Consignar(10000000,"14/10/2021","Edicio Coltejer","Edwin");
            davivienda.Consignar(2222222, "14/10/2021","Centro Comercial Premium","Esperzanza");
            davivienda.MostrarSaldoTotal();


        }

        static public void aaa() { 
        
        }

        static private int aaaaa() {
            return 2;
        }
            
    }
}
