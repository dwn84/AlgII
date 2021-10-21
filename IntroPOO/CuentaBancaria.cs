using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO
{
    class CuentaBancaria
    {
        //Campos o características para los objetos
        private string nombreTitular;
        private int numeroCuenta;
        private double saldo;

        //Constructor de clase
        public CuentaBancaria(string nt, int nc, double s,bool xyz) {
            nombreTitular = nt;
            numeroCuenta = nc;
            saldo = s;
        }
        //segundo constructor de clase: sobrecarga del constructor
        public CuentaBancaria(string nn) {
            nombreTitular = nn;
        }
        //tercer constructo de clase
        public CuentaBancaria(int saldito) {
            saldo = saldito;
        }

        //Comportamiento, acciones o métodos: funciones o procedimientos
        //Los métodos tienen delegadas responsabilidades específicas
        //Los métodos alteran o muestras los campos de la clase
        public void Retirar(double dineroPorRetirar)
        {
            if (dineroPorRetirar < saldo)
            {
                saldo = saldo - dineroPorRetirar;
                Console.WriteLine("Retirando dinero!");
            }
            else
            {
                Console.WriteLine("Sin fondos suficientes");
            }

        }

        
        public void Consignar(double dineroPorDepositar, string fecha, string sucursal, string nombreConsignador)
        {
            saldo = saldo + dineroPorDepositar;
            Console.WriteLine("El día {0} se ha realizado una consignación de: " +
                              "{1} que se llevó a cabo en la sucursual: " +
                              "{2} por la persona:{3}", fecha, dineroPorDepositar, sucursal, nombreConsignador);
        }

        public void MostrarSaldoTotal() {
            Console.WriteLine("El saldo total disponible es:{0}",saldo);
        }
    }
}
