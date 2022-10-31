using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonajeMovil
{
    public class Objetivo : Entidad
    {
        public int Puntos = 100;
        public Objetivo(int? x = null, int? y = null) : base("*", x, y)
        {
        }
        public bool Contacto(Personaje jugador)
        {
            if(X==jugador.X && Y== jugador.Y)
            {
                return true;
            }
            return false;
        }

    }
}
