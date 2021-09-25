using System;
using System.Linq;

namespace DemoConsoleAvanzado
{
    public class Delegado
    {
        public delegate string Reverse(string s);
        public string volcarCadena(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
