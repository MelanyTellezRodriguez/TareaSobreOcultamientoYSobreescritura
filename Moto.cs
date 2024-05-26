using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    //creacion de la clase hija o clase derivada Moto, la cual hereda de la clase base o padre Vehiculo
    internal class Moto : Vehiculo
    {
        //override: Se utiliza en la clase derivada para indicar que un método o propiedad está sobrescribiendo
        //un método o propiedad virtual de la clase base.
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento de la moto : Lubricacion de cadena y revision de neomaticos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0; //Costo del mantenimiento de la moto
        }
    }
}
