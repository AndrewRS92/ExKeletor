using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PersonajeMovil
{
    public class Laberinto
    {

        public Laberinto()
        {
            Paredes = new Pared[NumeroParedes];
            Paredes[0] = new Pared()
            {
                X = 0,
                Y = 0
            };
            for (int i = 0; i < NumeroParedes/4; i++)
            {
                Paredes[i] = new Pared()
                {
                    X = 0,
                    Y = i
                };
            }
            for (int i = NumeroParedes / 4; i < NumeroParedes/2; i++)
            {
                Paredes[i] = new Pared()
                {
                    X = i - NumeroParedes / 4,
                    Y = 20
                };
            }
            for (int i = NumeroParedes / 2; i < NumeroParedes*3 / 4; i++)
            {
                Paredes[i] = new Pared()
                {
                    X = 20,
                    Y = i - NumeroParedes / 2
                };
            }
            for (int i = NumeroParedes*3 / 4; i < NumeroParedes; i++)
            {
                Paredes[i] = new Pared()
                {
                    X = i- NumeroParedes * 3 / 4,
                    Y = 0
                };
            }
        }

        private const int NumeroParedes = 80;
        public Pared[] Paredes { get; set; }

        public void Dibujar()
        {
            foreach (Pared pared in Paredes)
            {
                Console.SetCursorPosition(pared.X, pared.Y);
                Console.WriteLine(pared.Ladrillo);
            }
        }
        public bool EsPared(int x, int y)
        {
            foreach(var pared in Paredes)
            {
                if ((x, y) == (pared.X, pared.Y))
                {
                    return true;
                }
               
            }
            return false;
        }
    }

    public class Pared
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Ladrillo = "#";

    }
}
