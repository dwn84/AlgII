using System;
using System.Collections.Generic;
using System.Text;

namespace IntroPOO
{
    class CuentaBancaria
    {
        //Campos o características para los objetos
        public string nombreTitular;
        public int numeroCuenta;
        public double saldo;

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
