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
            Console.WriteLine("Objeto creado con una clase sin constructor:");
            CuentaBancaria colmena = new CuentaBancaria();
            colmena.CambiarSucursalCliente("Laureles");
            Console.WriteLine(colmena.Saldo);
            colmena.MostrarSaldoTotal();

            CuentaBancaria banpolombia = new CuentaBancaria("wtf");
            CuentaBancaria davivienda = new CuentaBancaria("Oelo");
            CuentaBancaria conavi = new CuentaBancaria(54635364);
            banpolombia.Saldo = 100000;
            banpolombia.NombreTitular = "Nerón Navarrete";
            banpolombia.NumeroCuenta = 111221;
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


            davivienda.Saldo = 33000;
            davivienda.NombreTitular = "Esperanza Gómez";
            davivienda.NumeroCuenta = 111223;
            davivienda.Saldo = 333333333;
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
