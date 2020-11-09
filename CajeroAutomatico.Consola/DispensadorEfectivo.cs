using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public class DispensadorEfectivo
    {
        public double DineroDisponible { get; set; }

        public double DineroLimiteXDia { get; set; }

        public bool HayDineroDisponible(int numeroCuenta)
        {
            return true;
        }
    }
}