﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_41b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c = c + l1;
                Console.WriteLine("Llamada agregada con exito");
            }
            catch(CentralitaExcepcion e)
            {
                Console.WriteLine("ERROR: " + e.Message + "Clase -> " + e.NombreClase + "Metodo -> " + e.NombreMetodo);
            }
            try
            {
                c = c + l2;
                Console.WriteLine("Llamada agregada con exito");
            }
            catch (CentralitaExcepcion e)
            {
                Console.WriteLine("ERROR: " + e.Message + "Clase -> " + e.NombreClase + "Metodo -> " + e.NombreMetodo);
            }
            try
            {
                c = c + l3;
                Console.WriteLine("Llamada agregada con exito");
            }
            catch (CentralitaExcepcion e)
            {
                Console.WriteLine("ERROR: " + e.Message + "Clase -> " + e.NombreClase + "Metodo -> " + e.NombreMetodo);
            }
            try
            {
                c = c + l4;
                Console.WriteLine("Llamada agregada con exito");
            }
            catch (CentralitaExcepcion e)
            {
                Console.WriteLine("ERROR: " + e.Message + "Clase -> " + e.NombreClase + "Metodo -> " + e.NombreMetodo);
            }
            try
            {
                c = c + l4;
                Console.WriteLine("Llamada agregada con exito");
            }
            catch (CentralitaExcepcion e)
            {
                Console.WriteLine("ERROR: " + e.Message + "Clase -> " + e.NombreClase + "Metodo -> " + e.NombreMetodo);
            }

            //Console.WriteLine(c.ToString());
            //c = c + l2;
            //Console.WriteLine(c.ToString());
            //c = c + l3;
            //Console.WriteLine(c.ToString());
            //c = c + l4;
            //Console.WriteLine(c.ToString());
            //c = c + l4;
            //Console.WriteLine(c.ToString());

            c.OrdenarLlamada();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
