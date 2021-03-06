﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();

            List<Animal> animales = new List<Animal>();

            Animal tiburon = new AnimalAcuatico();
            tiburon.Nombre = "Tiburon";
            ((AnimalAcuatico)tiburon).Nadar();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";

            delfin.Comer();
            delfin.Nadar();

            elefante.Caminar();

            kanguro.Caminar();
            kanguro.SaltarBienAlto();
            kanguro.Comer();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
                if(animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
            }

            Console.ReadLine();
        }
    }
}
