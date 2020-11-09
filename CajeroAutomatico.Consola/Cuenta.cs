using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public class Cuenta
    {
        private int contraseña;

        private int numeroCuenta;

        private decimal saldoDisponible;

        private decimal saldoTotal;

        public Cuenta(int NumeroCuenta,int Contraseña,decimal SaldoDisponible,decimal SaldoTotal)
        {
            this.Contraseña = Contraseña;
            this.NumeroCuenta = NumeroCuenta;
            this.SaldoDisponible = SaldoDisponible;
            this.SaldoTotal = SaldoTotal;
        }

        public int Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public decimal SaldoTotal
        {
            get { return saldoTotal; }
            set { saldoTotal = value; }
        }


        public decimal SaldoDisponible
        {
            get { return saldoDisponible; }
            set { saldoDisponible = value; }
        }


        public int NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        public void Abonar(decimal dinero)
        {
            saldoTotal += dinero;
        }

        public void Cargar(decimal dinero)
        {
            saldoDisponible -= dinero;
            saldoTotal -= dinero;
        }

   
        public bool ValidarContraseña(int c)
        {
            return (contraseña == c);           
        }
    }
}