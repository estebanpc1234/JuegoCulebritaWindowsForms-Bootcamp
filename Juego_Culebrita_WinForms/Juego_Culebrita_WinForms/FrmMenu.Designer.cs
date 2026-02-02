namespace Juego_Culebrita_WinForms
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtWelcome = new TextBox();
            bttnSalir = new Button();
            bttnJugar = new Button();
            lbltext = new Label();
            SuspendLayout();
            // 
            // txtWelcome
            // 
            txtWelcome.Location = new Point(110, 247);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(100, 23);
            txtWelcome.TabIndex = 2;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(489, 347);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(139, 57);
            bttnSalir.TabIndex = 1;
            bttnSalir.Text = "Salir";
            bttnSalir.Click += bttnSalir_Click;
            // 
            // bttnJugar
            // 
            bttnJugar.Location = new Point(83, 347);
            bttnJugar.Name = "bttnJugar";
            bttnJugar.Size = new Size(139, 57);
            bttnJugar.TabIndex = 0;
            bttnJugar.Text = "Jugar";
            bttnJugar.Click += bttnJugar_Click;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Location = new Point(110, 28);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(7, 15);
            lbltext.TabIndex = 3;
            lbltext.Text = "\r\n";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(838, 438);
            Controls.Add(lbltext);
            Controls.Add(bttnJugar);
            Controls.Add(bttnSalir);
            Controls.Add(txtWelcome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            ShowIcon = false;
            Text = "Snake game.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWelcome;
        private Button bttnSalir;
        private Button bttnJugar;
        private Label lbltext;
    }
}