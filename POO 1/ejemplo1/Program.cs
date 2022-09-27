using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1:
            Persona p1 = new Persona(); // Instancio a p1 como una clase Persona

            p1.setEdad(39); // Le seteo la edad con el metodo creado en la clase Persona
            Console.WriteLine("La edad de la persona p1 és: " + p1.getEdad()); // Concateno con el metodo que retorna la variable edad ya seteada
            
            // Ejercicio 2:
            Botella a1 = new Botella(); // Instancio a1 como una clase Botella

            a1.Capacidad = 200; // A la instancia de clase a1, le aplico la propiedad Capacidad, que en su set tiene capacidad = value 
            Console.WriteLine("La capacidad de la botella a1 és: " + a1.Capacidad);

            // Ejercicio 3:
            Perro b1 = new Perro();
            b1.Nombre = "Piky";
            Console.WriteLine("El nombre del perro es: " + b1.Nombre);


            Console.ReadKey();

        }
    }
}
