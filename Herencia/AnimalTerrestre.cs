﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Hola soy un " + Nombre + " y estoy caminando");
        }
    }
}
