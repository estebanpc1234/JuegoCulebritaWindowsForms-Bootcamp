using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_Culebrita_WinForms
{
    public  class Manzana
    {
        public int PosX { get; set; }   
        public int PosY { get; set; }
        Random random = new Random();

        public Manzana(int Width, int Height)  // Se necesitan las dimensiones del área de juego
        {
            PosX = random.Next(2 , Width);
            PosY = random.Next(2 , Height);
        }

    }
}
