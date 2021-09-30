using ClassLibraryNetStandard;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoConsoleAvanzado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Librería
            int result = Calculadora.multiplicar(5, 6);
            Console.WriteLine($"El resultado es: {result}");

            //testAsycAwaitMethod();

            // Manejo de excepciones
            int a = 5, b = 0;
            try
            {
                var division = a / b;
                Console.WriteLine($"La división de {a} y {b} es: {division}");
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("finally");
            }

            // Clases Abstractas
            Cuadrado cuandrado = new Cuadrado(5);
            Console.WriteLine($"El área del cuadrado es {cuandrado.area()}");
            Console.WriteLine($"El perímetro del cuadrado es {cuandrado.perimetro()}");

            // Interfaces
            Avion avion = new Avion();
            avion.acelerar(2000);
            avion.girar(45);
            avion.frenar();

            // Genéricos
            Generico<string> cadena = new Generico<string>();
            cadena.campo = "Hola";

            Generico<Cuadrado> gCuadrado = new Generico<Cuadrado>();
            gCuadrado.campo = new Cuadrado(5);

            Generico<Avion> gAvion = new Generico<Avion>();
            gAvion.campo = new Avion();

            // Delegado
            Reverse rev = volcarCadena;
            Console.WriteLine(rev("hola"));

            Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
            int valor = multiplicacion(3, 2);
            Console.WriteLine($"El resultado es { valor}");

            Predicate<int> mayorDeEdad = e => e >= 18;
            bool esMayorDeEdad = mayorDeEdad(21);
            Console.WriteLine($"Es mayor de edad { esMayorDeEdad}");

            Console.WriteLine("Hola Mundo");
            Console.ReadLine();
        }

        public delegate string Reverse(string s);
        static string volcarCadena(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static async void testAsycAwaitMethod() {
            await longRunningMethod();
        }

        public static async Task<int> longRunningMethod() {
            Console.WriteLine("Iniciando ejecución de método");
            await Task.Delay(2000);
            Console.WriteLine("Finalizando ejecución del método");
            return 1;
        }

        class Generico<T> {
            public T campo;
        }

        class Edad {
            readonly int anio;
            Edad(int anio) {
                this.anio = anio;
            }

            void cambioAnio() {
                //this.anio = 1990; Error de compilación
            }
        }
    }
}
