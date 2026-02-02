using Juego_Culebrita_WinForms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Culebrita_WinForms
{
    public partial class FrmGame : Form
    {
        private string userName;
        private Random random;
        private Snake snake;
        private Point food;



        public FrmGame(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.snake = new Snake(pbxTable.Width , pbxTable.Height);
            random = new Random();

            SpawnFood();
            
            
        }

        private void timer_tick(object sender, EventArgs e)
        {

            snake.Move();

            if (snake.Body[0] == food)
            {
                snake.Grow();
                SpawnFood();
            }

            if (snake.IsDead)
            {
                tmGameTimer.Stop();

                frmLose windowlose = new frmLose(this.userName, snake.FoodEaten);
                windowlose.Owner = this;   
                this.Hide();
                
                windowlose.ShowDialog();

            }
            tmGameTimer.Interval = Snake.SpeedUp(snake.FoodEaten);
            pbxTable.Invalidate();
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            snake.SetDirection(e.KeyCode);
        }


        private void pbxTable_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, food.X, food.Y, snake.Step, snake.Step);

            for (int i = 0; i < snake.Body.Count; i++)
            {
                var p = snake.Body[i];
                var brush = (i == 0) ? Brushes.DarkGreen : Brushes.Green;
                e.Graphics.FillRectangle(brush, p.X, p.Y, snake.Step, snake.Step);
            }
        }

        private void SpawnFood()
        {
            int step = snake.Step;
            int cols = pbxTable.Width / step;
            int rows = pbxTable.Height / step;

            Point p;
            do
            {
                p = new Point(random.Next(cols) * step , random.Next(rows) * step );
            } while (snake.Body.Contains(p));

            food = p;
            txtShowScore.Text = snake.FoodEaten.ToString();
        }

        public void Reset()
        {
            snake = new Snake(pbxTable.Width, pbxTable.Height);
            SpawnFood();
            tmGameTimer.Enabled = true;
        }

    }
}
