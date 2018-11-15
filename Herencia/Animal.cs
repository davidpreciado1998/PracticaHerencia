using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Animal
    {
        public string Nombre { get; set; }

        public void Comer()
        {
            Console.WriteLine("Hola sout un " + Nombre + " y Estoy comiendo");
        }
    }
}
