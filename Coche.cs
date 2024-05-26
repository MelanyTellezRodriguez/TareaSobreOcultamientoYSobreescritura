using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    //creacion de la clase hija o clase derivada Coche, la cual hereda de la clase base Vehiculo.
    internal class Coche : Vehiculo
    {
        //creacion de la clase hija o clase derivada Coche, la cual hereda de la clase base Vehiculo.


        //override: Se utiliza en la clase derivada para indicar que un método o propiedad está sobrescribiendo
        //un método o propiedad virtual de la clase base.
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento del coche: cambio de aceite y revision de frenos");

        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;//Costo del mantenimiento del coche

        }
    }
        
}
