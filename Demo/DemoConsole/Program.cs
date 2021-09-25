using System;
using System.Collections.Generic;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // POO (esto lo hicimos al final)
            Persona persona = new Persona("123456");
            persona.nombres = "Juan";
            persona.primerApellido = "Perez";
            persona.segundoApellido = "Suárez";
            persona.fechaNacimiento = DateTime.Parse("25/12/2000");
            persona.saludar();
            Console.WriteLine($"La edad de {persona.nombres} es {persona.edad()}");

            Persona persona2 = new Persona()
            {
                cedulaIdentidad = "456",
                nombres = "Maria",
                primerApellido = "Moreno",
                segundoApellido = "Roca"
            };
            persona2.saludar();
            persona2.presentarMiDocumento();

            Estudiante estudiante = new Estudiante();
            estudiante.cedulaIdentidad = "254456";
            estudiante.nombres = "Daniel";
            estudiante.primerApellido = "Sánchez";
            estudiante.segundoApellido = "Nagata";
            estudiante.carnetUniversitario = "78-54546";
            estudiante.saludar();
            estudiante.presentarMiDocumento();

            //List<Persona> personas = new List<Persona>();
            //for (int j = 0; j < 50; j++) {
            //    Persona p = new Persona();
            //    p.cedulaIdentidad = Console.ReadLine();
            //    personas.Add(p);
            //    p.saludar();
            //}

            // Contastantes
            const int CONSTANTE_A = 3;
            const float PI = 3.1416f;

            // Variales
            int a = 0, b = 1, c = 2;
            int contador = 0, cantidad = 4, tamanio = 0;
            string strA, strB = string.Empty, strC = "Hola Mundo", A = "0";
            double precio = 5.2d, precioTotal;
            bool bandera = true;
            string texto = "Saludo ", verifcar = "false";

            /* Operadores 
             * y Conversiones
             */
            var suma = b + c;
            var restar = c - b;
            restar -= 5;
            contador++;
            var pruebaLogica = !bandera;
            bool pruebaLogica2 = (a == Convert.ToInt32(A) || b != c || Convert.ToBoolean(verifcar));
            precioTotal = precio * Convert.ToDouble(cantidad);
            string enteroACadena = c.ToString();

            // Cadenas
            string concatenado = "Forma 1: " + texto + " " + strC;
            concatenado = $"   Forma 2: {texto} {strC}  2";
            string sinEspaciosExtremos = concatenado.Trim();
            string reemplazar = sinEspaciosExtremos.Replace(" ", "*").Replace("2", "Dos");
            string minusculas = reemplazar.ToLower();
            string mayusculas = reemplazar.ToUpper();
            tamanio = sinEspaciosExtremos.Length;
            string concatenado2 = $"Tamaño: {tamanio} de la cadena: {sinEspaciosExtremos}";

            // Arreglos y Listas
            int[] arregloEstaciones = { 1, 2, 3, 4 };
            string[] arregloEstaciones2 = new string[4];
            arregloEstaciones2[0] = "Primavera";
            arregloEstaciones2[1] = "Verano";
            arregloEstaciones2[2] = "Otoño";
            arregloEstaciones2[3] = "Inverno";

            List<int> listaEstaciones = new List<int>() { 1, 2, 3, 4 };
            List<string> listaEstaciones2 = new List<string>();
            listaEstaciones2.Add("Primavera");
            listaEstaciones2.Add("Verano");
            listaEstaciones2.Add("Otoño");
            listaEstaciones2.Add("Invierno");
            listaEstaciones2.Add("Algo");
            listaEstaciones2.Remove("Algo");

            // *** Estructuras de Control ***
            // if, else if, else
            if (texto.Trim().ToLower().Equals("saludo1")) Console.WriteLine("Es igual");
            else if (strC.Length >= 5) Console.WriteLine("Su longitud es mayor o igual a 5");
            else Console.WriteLine("No cumple ninguna condición");

            Console.WriteLine("Introduzca un número de estación: ");
            int numeroEstacion = Convert.ToInt32(Console.ReadLine());
            // switch
            switch (numeroEstacion)
            {
                case 1: Console.WriteLine(arregloEstaciones2[0]); break;
                case 2: Console.WriteLine(arregloEstaciones2[1]); break;
                case 3: Console.WriteLine(listaEstaciones2[2]); break;
                case 4: Console.WriteLine(listaEstaciones2[3]); break;
                default: Console.WriteLine("No existe la estación"); break;
            }

            //while y do while
            Console.WriteLine("Introduzca un número > 0, caso contrario finalizará el ciclo while: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                Console.WriteLine($"El número introducido es: {a}");
                a = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Introduzca un número > 0, caso contrario finalizará el ciclo do while: ");
            } while (Convert.ToInt32(Console.ReadLine()) > 0);

            // for y foreach
            var respuesta = pruebaFor(arregloEstaciones2, listaEstaciones2);

            Console.WriteLine(respuesta);
        }

        private static string pruebaFor(string[] arregloEstaciones2, List<string> listaEstaciones2)
        {
            Console.WriteLine($"\nLista de estaciones visualizadas con ciclo for de un arreglo");
            for (int i = 0; i < arregloEstaciones2.Length; i++)
            {
                Console.WriteLine(arregloEstaciones2[i]);
            }

            Console.WriteLine($"\nLista de estaciones visualizadas con ciclo foreach de una lista");
            listaEstaciones2.Reverse();
            foreach (var estacion in listaEstaciones2)
            {
                Console.WriteLine(estacion);
            }

            return "Metodo for y foreach ejecutado con éxito";
        }
    }
}
