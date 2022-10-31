using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Entidad
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Imagen { get; set; }
        public Entidad(string imagen, int? x = null, int? y = null)
        {
            Random generador = new Random();

            if (x == null)
            {
                X = generador.Next(1,20);
            }
            else
            {
                X = x.Value;
            }
            if (y == null)
            {
                Y = generador.Next(1, 20);

            }
            else
            {
                Y = y.Value;
            }

            Imagen = imagen;
        }


        public void Dibujar()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Imagen);
        }
    }
}

