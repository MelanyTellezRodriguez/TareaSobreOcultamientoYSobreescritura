using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{

    //Creacion de la clase padre Vehiculo o clase base
    internal class Vehiculo
    {
        //creacion del metodo RealizarMantenimiento de un vehiculo general
        //La palabra clave virtual se utiliza para controlar y gestionar la sobreescritura de metodos y propiedades
        //Virtual: Se utiliza en la clase base para indicar que un método o propiedad puede ser sobrescrito en
        //una clase derivada.
        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo");

        }

        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0; //Costo base de mantenimiento general

        }
    }
}
