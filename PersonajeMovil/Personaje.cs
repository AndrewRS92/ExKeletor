using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonajeMovil.Movimiento;

namespace PersonajeMovil
{
    public class Personaje : Entidad
    {
        public int Vidas { get; set; }
        public bool Vivo { get { return Vidas > 0; } }
       
        public Personaje() : base("X")
        {
            Vidas = 3;
        }

        public void Mover(Direccion direccion, Laberinto laberinto)
        {
            (int x, int y) valorInicial = (X, Y);
            if (direccion == Direccion.Arriba && !laberinto.EsPared(X, Y - 1))
            {
                Y--;
            }
            if (direccion == Direccion.Abajo && !laberinto.EsPared(X, Y + 1))
            {
                Y++;
            }
            if (direccion == Direccion.Derecha && !laberinto.EsPared(X + 1, Y))
            {
                X++;
            }
            if (direccion == Direccion.Izquierda && !laberinto.EsPared(X - 1, Y))
            {
                X--;
            }

            if (valorInicial == (X, Y))
            {
                Console.Beep();
            }
        }
    }
}
