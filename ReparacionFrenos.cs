using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    //Creacion de la clase derivada ReparacionFrenos la cual hereda de la clase base Servicio.
    internal class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos");
        }

        public override double CalcularCosto()
        {
            return 100.0; //Costo de la reparacion de frenos
        }
    }
}
