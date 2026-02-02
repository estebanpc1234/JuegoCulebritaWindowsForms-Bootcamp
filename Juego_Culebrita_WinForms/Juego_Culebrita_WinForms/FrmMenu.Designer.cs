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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            txtWelcome = new TextBox();
            bttnSalir = new Button();
            bttnJugar = new Button();
            lbltext = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtWelcome
            // 
            txtWelcome.Location = new Point(98, 395);
            txtWelcome.Margin = new Padding(3, 4, 3, 4);
            txtWelcome.Name = "txtWelcome";
            txtWelcome.Size = new Size(159, 27);
            txtWelcome.TabIndex = 2;
            txtWelcome.TextChanged += txtWelcome_TextChanged;
            // 
            // bttnSalir
            // 
            bttnSalir.Location = new Point(98, 461);
            bttnSalir.Margin = new Padding(3, 4, 3, 4);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(159, 76);
            bttnSalir.TabIndex = 1;
            bttnSalir.Text = "Salir";
            bttnSalir.Click += bttnSalir_Click;
            // 
            // bttnJugar
            // 
            bttnJugar.Enabled = false;
            bttnJugar.Location = new Point(98, 271);
            bttnJugar.Margin = new Padding(3, 4, 3, 4);
            bttnJugar.Name = "bttnJugar";
            bttnJugar.Size = new Size(159, 76);
            bttnJugar.TabIndex = 0;
            bttnJugar.Text = "Jugar";
            bttnJugar.Click += bttnJugar_Click;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Location = new Point(126, 37);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(9, 20);
            lbltext.TabIndex = 3;
            lbltext.Text = "\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(364, 140);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(389, 550);
            Controls.Add(label1);
            Controls.Add(lbltext);
            Controls.Add(bttnJugar);
            Controls.Add(bttnSalir);
            Controls.Add(txtWelcome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake game.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWelcome;
        private Button bttnSalir;
        private Button bttnJugar;
        private Label lbltext;
        private Label label1;
    }
}