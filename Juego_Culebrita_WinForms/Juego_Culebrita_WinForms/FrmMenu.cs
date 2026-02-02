using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Juego_Culebrita_WinForms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void bttnJugar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtWelcome.Text)) //modificado por expertos 
            {

                FrmGame game = new FrmGame(txtWelcome.Text);
                game.Owner = this;

                game.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Por favor, ingresa tu nombre.");
            }
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            // Cierra toda alv
            Application.Exit();
        }

        private void txtWelcome_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if(!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    bttnJugar.Enabled = true;
                }
                else
                {
                    bttnJugar.Enabled = false;
                }
            }

            
        }
    }
}
