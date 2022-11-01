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
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("Bienvenido a EXXkeletor. Pulse Intro para jugar y escape para salir");
                tecla = Console.ReadKey();
                Console.Clear();
            }
            while (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Escape);

            Salir = tecla.Key == ConsoleKey.Escape;
        }

        public bool GetSalir()
        {
            return Salir;
        }
    }
}
