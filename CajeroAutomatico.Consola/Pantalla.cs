using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CajeroAutomatico.Consola
{
    public class Pantalla
    {
        public void MostrarMensaje(string mensaje)
        {
            Console.Write(mensaje);
        }
        public void MostrarLineaMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public void MostrarMontoEPesos(decimal monto)
        {
            Console.Write("{0:C}", monto);
        }
    }
}