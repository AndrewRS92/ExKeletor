using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Bienvenida
    {
        public bool Salir { get; set; }
        public void Lanzar()
        {
            Console.WriteLine("Bienvenido a EXXkeletor. Pulse Intro para jugar y escape para salir");
            ConsoleKeyInfo tecla = Console.ReadKey();
            Salir = tecla.Key == ConsoleKey.Escape;
            Console.Clear();
        }

        public bool GetSalir()
        {
            return Salir;
        }
    }
}
