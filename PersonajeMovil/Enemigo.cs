using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Enemigo : Entidad
    {
        public Enemigo(int? x = null, int? y = null) : base("^", x, y)
        {
        }
        public void Mover(Laberinto laberinto)
        {
            Random generador = new Random();
            int aleatorio = generador.Next(0, 5);
            (int x, int y) valorInicial = (X, Y);
            switch (aleatorio)
            {
                case 0: break;
                case 1: Y--; break;
                case 2: Y++; break;
                case 3: X--; break;
                case 4: X++; break;
            }
            if (laberinto.EsPared(X, Y))
            {
                X = valorInicial.x;
                Y = valorInicial.y;
                Console.Beep(247,400);
            }
        }
    }
}
