using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public class SolicitudSaldo : Transaccion
    {
        public override bool VerificarCuenta(int numeroCuenta)
        {
            throw new NotImplementedException();
        }
    }
}