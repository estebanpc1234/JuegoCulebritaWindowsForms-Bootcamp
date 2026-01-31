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
            this.snake = new Snake(pbxTable.Width , pbxTable.Height );
            random = new Random();

            SpawnFood();
            tmGameTimer.Interval = snake.Speed;
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
                frmLose lose = new frmLose();
                this.Hide();
                lose.Show();    
            }

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
        }

    }
}
