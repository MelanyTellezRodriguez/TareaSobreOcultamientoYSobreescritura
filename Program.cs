using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Word");

            //Creacion de una intancia de la clase Coche y le asigna a una variable de tipo Vehiculo.
            //Vehiculo es el tipo de variable miCoche, lo cual indica que "miCoche" puede almacenar una referencia 
            //a cualquier objeto que sea de tipo "Vehiculo" o de un tipo derivado de "Vehiculo"
            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimiento(); //Output: Realizando mantenimiento del coche: cambio de aceite 
            //revision de frenos
            Console.WriteLine("Costo del mantenimiento del coche : + " + miCoche.ObtenerCostoMantenimiento());

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento(); //Output: Realizando mantenimiento de la moto: lubricacion de cadena
            // y revision de neomaticos
            Console.WriteLine("Costo del mantenimiento de la moto: $ " + miMoto.ObtenerCostoMantenimiento());

        }
    }
}
