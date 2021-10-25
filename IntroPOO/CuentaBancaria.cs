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
        private string fechaCreacion;
        private string _sucursal;
        public bool vip;//No cumple con la abstracción - No recomendable dejar el campo publico
        //Propiedades de clase
        public string NombreTitular {get => nombreTitular;set => nombreTitular = value;}
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }


        //Constructor de clase
        public CuentaBancaria(string nt, int nc, double s,bool xyz) {
            NombreTitular = nt;
            NumeroCuenta = nc;
            Saldo = s;
        }
        //segundo constructor de clase: sobrecarga del constructor
        public CuentaBancaria(string nn) {
            NombreTitular = nn;
        }
        //tercer constructo de clase
        public CuentaBancaria(int saldito) {
            Saldo = saldito;
        }

        public CuentaBancaria() {
        
        }

        public void CambiarSucursalCliente(string nuevaSucursal, string fechaCambio = "1999/01/01") {
            Console.WriteLine("Se ha cambiado la sucursal: " + fechaCambio);
        }

        //Comportamiento, acciones o métodos: funciones o procedimientos
        //Los métodos tienen delegadas responsabilidades específicas
        //Los métodos alteran o muestras los campos de la clase
        public void Retirar(double dineroPorRetirar)
        {
           
            if (dineroPorRetirar < Saldo)
            {
                Saldo = Saldo - dineroPorRetirar;
                Console.WriteLine("Retirando dinero!");
            }
            else
            {
                Console.WriteLine("Sin fondos suficientes");
            }

        }

        
        public void Consignar(double dineroPorDepositar, string fecha, string sucursal, string nombreConsignador)
        {
            Saldo = Saldo + dineroPorDepositar;
            Console.WriteLine("El día {0} se ha realizado una consignación de: " +
                              "{1} que se llevó a cabo en la sucursual: " +
                              "{2} por la persona:{3}", fecha, dineroPorDepositar, sucursal, nombreConsignador);
        }

        public void MostrarSaldoTotal() {
            Console.WriteLine("El saldo total disponible es:{0}",Saldo);
        }
    }
}
