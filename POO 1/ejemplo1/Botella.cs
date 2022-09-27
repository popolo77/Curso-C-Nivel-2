using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        // Botella : capacidad, color, material Ejercicio 2

        private int capacidad;
        private string color;
        private string material;


        // Voy a crear una PROPIEDAD (public int Capacidad, es como lo maneja C#) para modificar la visibilidad
        public int Capacidad // Una vez creado la propiedad Capacidad (la puedo llamar directamente desde el program)
        {
            get{ return capacidad; } // Retorna el atributo privado capacidad
            set{ capacidad = value; } // El set le asigna un valor(value, palabra reservada) a capacidad
        }
    }
}
