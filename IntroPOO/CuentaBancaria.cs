using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO
{
    class CuentaBancaria
    {
        public string nombreTitular;
        public int numeroCuenta;
        public double saldo;

        public void Consignar() {
            Console.WriteLine("Agregando dinero!!! :)");
        }

        public void Retirar()
        {
            Console.WriteLine("Retirando dinero!!! :(");
        }
    }
}
