using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAvanzado
{
    public abstract class FiguraGeometrica
    {
        public abstract decimal area();
        public abstract decimal perimetro();
    }

    public class Cuadrado : FiguraGeometrica
    {
        readonly decimal lado;
        public Cuadrado(decimal lado) {
            this.lado = lado;
        }

        public override decimal area() => lado * lado;

        public override decimal perimetro() => lado * 4;
    }
}
