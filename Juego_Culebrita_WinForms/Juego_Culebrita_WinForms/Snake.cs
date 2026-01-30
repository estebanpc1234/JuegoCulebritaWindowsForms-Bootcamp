using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_Culebrita_WinForms
{
    public class Snake
    {

        public int Length { get; set; }
        public int FoodEaten { get; set; }
        public Tuple<int> Limits { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }
        public bool IsDead { get; set; }



    }
}
