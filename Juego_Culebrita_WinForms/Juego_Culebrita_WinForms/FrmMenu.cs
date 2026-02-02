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

            // Configuramos el mensaje de bienvenida e instrucciones al iniciar
            lbltext.Text =
                "¡Bienvenido al juego de Serpiente !\n\n" +
                 "Instrucciones:\n" +
                 "* Ingresa tu nombre para comenzar.\n" +
                 "* Usa las flechas del teclado para moverte.\n" +
                 "* come las manzanas para crecer " +
                 "* ¡No choques con las paredes ni con tu cuerpo!";

        }

        private void bttnJugar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtWelcome.Text)) //modificado por expertos 
            {

                FrmGame game = new FrmGame(txtWelcome.Text);

   
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
    }
}
