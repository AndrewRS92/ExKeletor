using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static PersonajeMovil.Movimiento;

namespace PersonajeMovil
{
    public class Partida
    {
        public int Puntos { get; set; }
        public void Lanzar()
        {
            Laberinto laberinto = new Laberinto();
            Personaje jugador = new Personaje();
            Enemigos adversarios = new Enemigos(6);
            Objetivo objetivo = new Objetivo();
            bool vivo = true;
            while (vivo)
            {
                jugador.Dibujar();       
                laberinto.Dibujar();
                adversarios.Dibujar();
                objetivo.Dibujar();
                Mover(jugador,laberinto);
                adversarios.Mover(laberinto);
                Console.Clear();
                if (objetivo.Contacto(jugador))
                {
                    Puntos += 100;
                    objetivo = new Objetivo();
                }
                if (adversarios.Contacto(jugador))
                {
                    jugador.Vidas--;
                    if (!jugador.Vivo )
                    {
                        vivo = false;
                    }
                }
                PintarPuntuacion();
                Console.WriteLine();
            }
            FinalizarPartida();

            using (StreamWriter fichero = new StreamWriter(@"Puntuacion.txt", true))
            {
                fichero.WriteLine(Puntos);
                fichero.Close();

            }

        }
        private void FinalizarPartida()
        {
            var credito = new Creditos();
            
        }
        private void Mover(Personaje jugador,Laberinto laberinto)
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.UpArrow||tecla.Key == ConsoleKey.W)
            {
                jugador.Mover(Direccion.Arriba,laberinto);
            }
            if (tecla.Key == ConsoleKey.DownArrow || tecla.Key == ConsoleKey.S)
            {
                jugador.Mover(Direccion.Abajo,laberinto);
            }
            if (tecla.Key == ConsoleKey.LeftArrow || tecla.Key == ConsoleKey.A)
            {
                jugador.Mover(Direccion.Izquierda,laberinto);
            }
            if (tecla.Key == ConsoleKey.RightArrow || tecla.Key == ConsoleKey.E)
            {
                jugador.Mover(Direccion.Derecha,laberinto);
            }
        }

        private void PintarPuntuacion()
        {
            Console.SetCursorPosition(0, 22);
            Console.Write("Puntuación: " + Puntos);
        }
    }

}
