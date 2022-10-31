using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Juego
    {
        public void EmpezarJuego()
        {
            Bienvenida bienvenida = new Bienvenida();
            while (bienvenida.GetSalir() == false)
            {
                bienvenida.Lanzar();

                if (bienvenida.GetSalir() == false)
                {
                    Partida partida = new Partida();
                    partida.Lanzar();
                }
            }
        }
    }
}
