using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Estudiante : Persona //Herencia ":"
    {
        public string carnetUniversitario { get; set; }

        // Polimorfismo opción 1 con new
        public new void saludar() {
            Console.WriteLine($"Mi nombre es {nombres} y mi CU es {carnetUniversitario}");
        }

        /* Polimorfismo opción 2 con virtual en clase padre (Persona) y 
         * override en clase hija (Estudiante) */
        public override void presentarMiDocumento()
        {
            Console.WriteLine($"Hola mi número de documento es {carnetUniversitario}");
        }
    }
}
