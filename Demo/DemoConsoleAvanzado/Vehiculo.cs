using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAvanzado
{
    public interface IVehiculo
    {
        void acelerar(int kmh);
        void frenar();
        void girar(int grados);
    }

    public class Avion : IVehiculo
    {
        public void acelerar(int kmh)
        {
            Console.WriteLine($"Acelerando a {kmh} km/h");
        }

        public void frenar()
        {
            Console.WriteLine("Reduciendo velocidad");
        }

        public void girar(int grados)
        {
            Console.WriteLine($"Girando {grados} grados");
        }
    }
}
