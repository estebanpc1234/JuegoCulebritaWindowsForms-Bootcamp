using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Culebrita_WinForms
{
    public partial class frmLose : Form
    {
        public frmLose(string userName, int score)
        {
            InitializeComponent();
            
            lblPlayerName.Text = "Game Over: " + userName;
            
            lblFinalScore.Text = "Score:" + score.ToString();

        }

        private void bttnReiniciar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // volver a jugar

            if (this.Owner is FrmGame game) game.Reset();
            this.Owner.Show();
            this.Close();
        }

        private void bttnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // ir al menú

            this.Owner.Owner.Show();
            this.Owner.Close();
            this.Close();
        }
    }
}
