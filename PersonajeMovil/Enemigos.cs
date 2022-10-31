using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Enemigos
    {
        public Enemigos(int n)
        {
            Lista = new Enemigo[n];
            for(int i=0;i< n; i++)
            {
                Lista[i] = new Enemigo();
            }

        }
        public Enemigo[] Lista { get; set;  }
        
        public void Dibujar()
        {
            foreach(Enemigo enemigo in Lista)
            {
                enemigo.Dibujar();
            }
        }
        public void Mover(Laberinto laberinto)
        {
            foreach (Enemigo enemigo in Lista)
            {
                enemigo.Mover(laberinto);
            }
        }

        public bool Contacto(Personaje jugador)
        {
            foreach (var enemigo in Lista)
            {
                if (jugador.X== enemigo.X && jugador.Y==enemigo.Y)
                {
                    return true;
                }

            }
            return false;
        }

    }
}
