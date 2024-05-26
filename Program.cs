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

            //Creacion de una instancia de la clase Coche y le asigna a una variable de tipo Vehiculo.
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

            miCoche.Lavar(); //output Lavando el vehiculo
            

            //De esta forma podemos mandar a llamar al metodo el cual se encuentra oculto en la clase Coche
            //creacion de una instancia de la Clase coche y asignandola a la variable miCocheReal.
            Coche miCocheReal = new Coche();
            miCocheReal.Lavar(); //output: Lavando el coche con cera y shampoo especial

            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio(); //Output: Realizando cambio de aceite
            Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalcularCosto());

            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio(); //Output: Realizando reparacion de frenos
            Console.WriteLine("Costo de la reparacion de frenos: $" + servicioFrenos.CalcularCosto());



            //Una clase abstracta es una de las principales de la POO. Una clase abstracta es una clase que 
            //contiene metodos sin implementacion, esto quiere decir que contiene definiciones de metodos y propiedades
            //pero no su implementacion.

            //Los metodos abstractos son definidos por la clase abstracta pero no son implementados por ella, estos 
            //metodos son implementados por clases derivadas que heredan de la clase abstracta. Esto significa 
            //que una clase abstracta puede contener una funcionalidad basica, a la que las otras clases pueden
            //agregar su propia funcionalidad

            //Una clase abstractac no se puede instanciar, es decir, no se pueden crear objetos de ella. Lo cual
            //se debe a que una clase abstracta no es completa, sino que se ha diseñado para ser una clase base 
            //para otras clases.

            //Servicio ser = new Servicio();

            Program prog = new Program();

            int opcion = 0;
            int intentos = 0;

            Console.WriteLine("");
            Console.WriteLine(".......................................................");
            Console.WriteLine("...   CALCULO DEL TIEMPO TOTAL DE LOS SERVICIOS     ...");
            Console.WriteLine("...          Tipos de vehiculos                     ...");
            Console.WriteLine("...               1.Coche                           ...");
            Console.WriteLine("...               2.Moto                            ...");
            Console.WriteLine("...      Seleccione un tipo de vehiculo             ...");
            Console.WriteLine(".......................................................");

            while (intentos < 3)
            {
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (opcion > 0 && opcion <= 2)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        throw new Exception("Numero no valido");

                    }


                }
                catch (Exception)
                {
                    intentos++;
                    Console.WriteLine("Error!! debe ingresar un numero entero que lo encuentre entre las opciones");


                }
                if (intentos == 3)
                {
                    Console.WriteLine("La cantidad de intentos se han agotado");
                    return;

                }


            }

            switch (opcion)
            {
                case 1:
                    prog.CalcularTiempoDeServicioCoche();
                    break;

                case 2:
                    prog.CalcularTiempoDeServicioMoto();
                    break;

            }


        }


        //Metodo para calcular el tiempoTotal de los servicios para el coche.
        public void CalcularTiempoDeServicioCoche()
        {
            Console.WriteLine("******  REALIZACION DEL MANTENIMIENTO DEL COCHE  ******");
            Console.WriteLine("--> Cambio de aceite y revision de frenos");
            Console.WriteLine("");
            string tiempoCambioAceite = "45 minutos";
            string tiempoRevisionFrenos = "30 minutos ";
            Console.WriteLine("¿Desea lavar el coche?");
            Console.WriteLine("-> si quiere lavar el coche escriba (si)");
            Console.WriteLine("-> si no quiere lavar el coche escriba (no)");
            string respuestaLavar = Console.ReadLine();
            Console.WriteLine("");

            if (respuestaLavar == "si")
            {

                Coche miCocheReal = new Coche();
                Console.WriteLine(">>>  El coche será lavado con cera y shampoo especial  <<<");
                string tiempoLavar = "60 minutos";
                Console.WriteLine("");

                double sumaTiempoTotal = 135;

                //conversion a hora para dar un tiempos especifico


                int minutos = 60;
                double calcuTotalTiempoHoras = sumaTiempoTotal / minutos;

                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Tiempo necesario para el cambio del aceite es de: " + tiempoCambioAceite);
                Console.WriteLine("Tiempo necesario para la Reparacion de frenos es de: " + tiempoRevisionFrenos);
                Console.WriteLine("Tiempo necesario para lavar el coche es de: " + tiempoLavar);
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("............................................................");
                Console.WriteLine("El tiempo total para realizar los servicios es de:" + calcuTotalTiempoHoras + "Horas");
                Console.WriteLine(">>>> ES DECIR 2 HORAS Y 15 MINUTOS <<<<");
                Console.WriteLine("........................................................... ");
                Console.WriteLine("");


                Vehiculo miCoche = new Coche();

                miCoche.RealizarMantenimiento();//mandamos a llamar al metodo RealizarMantenimiento de la clase Coche
                Console.WriteLine("");


                Console.WriteLine(":::::  Servicio adicional: Lavado de Coche  :::::");
                miCocheReal.Lavar();//mandamos a llamar al metodo Lavar de la clase coche
                Console.WriteLine("");

            }
            if (respuestaLavar == "no")
            {

                double SumaTiempoTotal = 75;

                int minutos = 60;
                double calcuTotalTiempoHoras = SumaTiempoTotal / minutos;
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Tiempo necesario para el cambio del aceite es de: " + tiempoCambioAceite);
                Console.WriteLine("Tiempo necesario para la Reparacion de frenos es de: " + tiempoRevisionFrenos);
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("..............................................................");
                Console.WriteLine("El tiempo total para realizar los servicios es de:" + calcuTotalTiempoHoras + "Horas");
                Console.WriteLine(">>>  ES DECIR 1 HORA Y 15 MINUTOS  <<<");
                Console.WriteLine("..............................................................");
                Console.WriteLine("");

                Vehiculo miCoche = new Coche();
                miCoche.RealizarMantenimiento();


            }




        }

        public void CalcularTiempoDeServicioMoto()
        {

            Console.WriteLine("******  REALIZACION DEL MANTENIMIENTO DE LA MOTO  ******");
            Console.WriteLine("--> Lubricacion de cadena y revision de neomaticos");
            string tiempoLubricacion = "30 minutos";
            string tiempoRevisionNeomaticos = "50 minutos";
            Console.WriteLine("");

            double sumaTiempoTotalMoto = 80;
            int minutosMoto = 60;

            double calculoTotalTiempoHoras = sumaTiempoTotalMoto / minutosMoto;

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Tiempo necesario para la Lubricacion de la cadena es de: " + tiempoLubricacion);
            Console.WriteLine("Tiempo necesario para la revsion de neomaticos: " + tiempoRevisionNeomaticos);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("..........................................................................");
            Console.WriteLine("El Tiempo total para realizar los servicios es de: " + calculoTotalTiempoHoras + "Horas");
            Console.WriteLine(">>>  ES DECIR 1 HORA Y 20 MINUTOS  <<<");
            Console.WriteLine("..........................................................................");
            Console.WriteLine("");

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimiento();//mandamos a llamar al metodo RealizarMantenimiento de la clase Moto
            Console.WriteLine("");


        }
    }


}
    