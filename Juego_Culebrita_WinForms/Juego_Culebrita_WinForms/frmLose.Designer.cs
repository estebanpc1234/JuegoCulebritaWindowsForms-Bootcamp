namespace Juego_Culebrita_WinForms
{
    partial class frmLose
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
            lblPlayerName = new Label();
            lblFinalScore = new Label();
            bttnReiniciar = new Button();
            bttnMenu = new Button();
            SuspendLayout();
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(37, 148);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(49, 20);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Name";
            // 
            // lblFinalScore
            // 
            lblFinalScore.AutoSize = true;
            lblFinalScore.Location = new Point(37, 195);
            lblFinalScore.Name = "lblFinalScore";
            lblFinalScore.Size = new Size(46, 20);
            lblFinalScore.TabIndex = 1;
            lblFinalScore.Text = "Score";
            // 
            // bttnReiniciar
            // 
            bttnReiniciar.Location = new Point(37, 309);
            bttnReiniciar.Margin = new Padding(3, 4, 3, 4);
            bttnReiniciar.Name = "bttnReiniciar";
            bttnReiniciar.Size = new Size(146, 75);
            bttnReiniciar.TabIndex = 2;
            bttnReiniciar.Text = "Reiniciar";
            bttnReiniciar.UseVisualStyleBackColor = true;
            bttnReiniciar.Click += bttnReiniciar_Click;
            // 
            // bttnMenu
            // 
            bttnMenu.Location = new Point(202, 309);
            bttnMenu.Margin = new Padding(3, 4, 3, 4);
            bttnMenu.Name = "bttnMenu";
            bttnMenu.Size = new Size(146, 75);
            bttnMenu.TabIndex = 3;
            bttnMenu.Text = "Menu";
            bttnMenu.UseVisualStyleBackColor = true;
            bttnMenu.Click += bttnMenu_Click;
            // 
            // frmLose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 449);
            Controls.Add(bttnMenu);
            Controls.Add(bttnReiniciar);
            Controls.Add(lblFinalScore);
            Controls.Add(lblPlayerName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLose";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fin del juego ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerName;
        private Label lblFinalScore;
        private Button bttnReiniciar;
        private Button bttnMenu;
    }
}