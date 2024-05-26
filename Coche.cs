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


        //new es una palabra clave que indica que este metodo oculta un miembro heredado de una clase base con el
        //mismo nombre ambos metodos
        //La clase derivada crea una nueva definicion del metodo que no sobreescribe el metodo sino que lo oculta
        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y Shampoo especial");
        }

    }
        
}
