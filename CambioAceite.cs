using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    //Creacion de la clase derivada CambioAceite, la cual hereda de la clase base Servicio 
    internal class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite");

        }

        public override double CalcularCosto()
        {
            return 50.0; //Costo del cambio de Aceite
        }
    }
}
