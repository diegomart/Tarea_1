using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tarea_1
{
    class Persona
    {
         public void leerDatos(){

            Console.WriteLine("Nombre:");
            string nombre =  Console.ReadLine();
              Console.WriteLine("Telefono:");
            string telefono =  Console.ReadLine();
              Console.WriteLine("Email:");
            string email =  Console.ReadLine();
              Console.WriteLine("Domicilio:");
            string domicilio =  Console.ReadLine();

                     
        }

        public static void Main (string[] args)
		    {
         Persona persona = new Persona();
         Console.WriteLine("Nombre: "+ nombre);
         Console.WriteLine("Nombre: "+ telefono);
         Console.WriteLine("Nombre: "+ email);
         Console.WriteLine("Nombre: "+ domicilo);
}
}
