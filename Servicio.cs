using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSobreOcultamientoYSobreescritura
{
    //Las clases abstractas en C# son clases que no pueden ser instanciadas directamente
    //Actuan como plantillaso moldes para otras clases, proporcionan una estructura y comportamiento 
    //basico que las clases derivadas para pueden utilizar y personalizar
    //Son una forma de definir una clase base que requiere que las clases deriavadas definan algunos
    //detalles especificos.
    public abstract class Servicio
    {
        //abstract indica que el metodo es abstracto, el cual no tiene implementacion en la clase en que se declara
        //el punto y coma al final indica que no hay implementacion del metodo en esta clase.
        public abstract void RealizarServicio();

        public abstract double CalcularCosto();
    }
}
