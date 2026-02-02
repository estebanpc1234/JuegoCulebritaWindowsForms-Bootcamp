using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;

namespace Juego_Culebrita_WinForms.Entities
{
    public class Snake
    {
        public List<Point> Body { get; set; }
        public int Step { get; set; } = 10;
        public int Speed { get; set; }
        public int FoodEaten { get; set; } = 0;
        public int LimitX { get; set; }
        public int LimitY { get; set; }    
        public bool IsDead { get; set; }
        public string Direction { get; set; }

        public bool IsGrowInNextMove { get; set; } 

        public Snake(int limitX, int limitY)
        {
            LimitX = limitX;
            LimitY = limitY;
            

            Body = new List<Point>();

            int x = (limitX / Step / 2) * Step;
            int y = (limitY / Step / 2) * Step;

            Body.Add(new Point(x, y));
        }

        public void SetDirection(Keys key)
        {
            if (key == Keys.Up && Direction != "Down") Direction = "Up";
            else if (key == Keys.Down && Direction != "Up") Direction = "Down";
            else if (key == Keys.Left && Direction != "Right") Direction = "Left";
            else if (key == Keys.Right && Direction != "Left") Direction = "Right";

        }

        public void Grow()
        {
            IsGrowInNextMove = true;
            FoodEaten++;
            SpeedUp(FoodEaten);
        }

        public void Move() 
        {
            if (IsDead) return;
            var head = Body[0];
            Point newHead = head;

            if (Direction == "Up") newHead = new Point(head.X, head.Y - Step);
            else if (Direction == "Down") newHead = new Point(head.X, head.Y + Step);
            else if (Direction == "Left") newHead = new Point(head.X - Step, head.Y);
            else if (Direction == "Right") newHead = new Point(head.X + Step, head.Y);

            Body.Insert(0, newHead);

            if (!IsGrowInNextMove) Body.RemoveAt(Body.Count - 1);
            else IsGrowInNextMove = false;

            CheckIsDead();
            
            

        }
        public static int SpeedUp(int FoodEaten)
        {

            if (FoodEaten >= 5)
            {
                return 80;
            }
            else if (FoodEaten >= 10)
            {
                return 60;
            }
            else if (FoodEaten >= 20)
            {
                return 30;
            }
            else
            {
                return 100;
            }
        }

        public void CheckIsDead()
        {
            var head = Body[0];

            if (head.X < 0 || head.Y < 0 || head.X >= LimitX || head.Y >= LimitY)
            {
                IsDead = true;
                return;
            }

            for (int i = 1; i < Body.Count; i++)
                if (Body[i] == head) { IsDead = true; return; }
        }


    }
}
