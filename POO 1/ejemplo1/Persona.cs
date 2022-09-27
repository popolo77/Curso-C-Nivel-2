using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        // Persona : edad, sueldo, nombre Ejercicio 1
        // Atributos
        // Visibilidad (principales) private y public
      
       private  int edad;
       private   float sueldo;
       private string nombre;

       // Mecanismo (herramientas) para cambiar visibilidad
        public void setEdad(int e) // Use void como el tipo de valor devuelto de un método (o una función local) para especificar que el método no devuelve un valor. También puede usar void como un tipo de referente para declarar un puntero a un tipo desconocido
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }
    }
}
