using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public abstract class Transaccion
    {
        private Pantalla pantalla;
        private BaseDatosBanco baseDatos;
        private Cuenta cuenta;

        public Transaccion(Pantalla pantalla,Cuenta cuenta,BaseDatosBanco baseDatos)
        {
            this.baseDatos = baseDatos;
            this.pantalla = pantalla;
            this.cuenta = cuenta;
        }
        public Pantalla Pantalla
        {
            get { return pantalla; }
            set { pantalla = value; }
        }

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public BaseDatosBanco BaseDatos
        {
            get { return baseDatos; }
            set { baseDatos = value; }
        }

        public abstract bool VerificarCuenta(int numeroCuenta);
    }
}