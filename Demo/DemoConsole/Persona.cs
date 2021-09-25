using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Persona
    {
        public Persona() { }
        public Persona(string cedulaIdentidad) {
            this.cedulaIdentidad = cedulaIdentidad;
        }
        public string cedulaIdentidad { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Int64 celular { get; set; }

        public void saludar()
        {
            Console.WriteLine($"Hola me llamo {nombres} {primerApellido} {segundoApellido}");
        }

        public virtual void presentarMiDocumento()
        {
            Console.WriteLine($"Hola mi número de documento es {cedulaIdentidad}");
        }

        public int edad()
        {
            return Convert.ToInt32(DateTime.Now.Date.Subtract(fechaNacimiento.Date).TotalDays / 365);
        }
    }
}
