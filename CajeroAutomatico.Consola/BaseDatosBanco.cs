using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public class BaseDatosBanco
    {
        public Cuenta [] Cuentas { get; set; }

        public Cuenta Cuenta
        {
            get => default;
            set
            {
            }
        }

        public BaseDatosBanco()
        {
            Cuentas = new Cuenta[5];
            Cuentas[0] = new Cuenta(0101,1,5000m,100000m);
            Cuentas[1] = new Cuenta(0202, 2, 5000m, 100000m);
            Cuentas[2] = new Cuenta(0303, 3, 5000m, 100000m);
            Cuentas[3] = new Cuenta(0404, 4, 5000m, 100000m);
            Cuentas[4] = new Cuenta(0505, 5, 5000m, 100000m);

        }
        public int GetCuenta()
        {
            foreach (var cuenta in Cuentas)
            {
                 return cuenta.NumeroCuenta;
            }
            return 0;

        }

        public bool VerificarCuenta(int contraseña)
        {
            bool validar = false;
            foreach (var cuenta in Cuentas)
            {
                validar=cuenta.ValidarContraseña(contraseña);
                if (validar)
                {
                    break;
                }
            }
            return validar;
        }

        public decimal GetSaldoDisponible(int numeroCuenta)
        {
            foreach (var cuenta in Cuentas)
            {
                if (cuenta.NumeroCuenta==numeroCuenta)
                {
                    return cuenta.SaldoDisponible;
                }
            }
            return 0;
        }

        public decimal GetSaldoTotal(int numeroCuenta)
        {
            foreach (var cuenta in Cuentas)
            {
                if (cuenta.NumeroCuenta == numeroCuenta)
                {
                    return cuenta.SaldoTotal;
                }
            }
            return 0;
        }

        public void Abonar(decimal saldo,int numeroCuenta)
        {
            foreach (var cuenta in Cuentas)
            {
                if (cuenta.NumeroCuenta == numeroCuenta)
                {
                    cuenta.Abonar(saldo);
                }
            }
        }

        public void Cargar(decimal saldo, int numeroCuenta)
        {
            foreach (var cuenta in Cuentas)
            {
                if (cuenta.NumeroCuenta == numeroCuenta)
                {
                    cuenta.Cargar(saldo);
                }
            }
        }
    }
}