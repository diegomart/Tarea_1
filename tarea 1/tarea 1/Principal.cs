using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tarea_1
{
    class Principal
    {



        public static void Main(string[] args)
        {
            Persona persona = new Persona();
           Console.WriteLine("Nombre: " +  persona.datos.nombre();
            Console.WriteLine("Telefono: " + persona.datos.telefono);
            Console.WriteLine("Email: " + persona.datos.email);
            Console.WriteLine("Domicilio: " + persona.datos.domicilo);
        }
    }
}