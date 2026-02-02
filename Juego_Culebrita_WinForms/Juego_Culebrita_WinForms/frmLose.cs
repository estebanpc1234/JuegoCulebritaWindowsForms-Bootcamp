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
            
            lblFinalScore.Text = score.ToString();

        }

        private void bttnReiniciar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // volver a jugar
            this.Close();
        }

        private void bttnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // ir al menú
            this.Close();
        }
    }
}
