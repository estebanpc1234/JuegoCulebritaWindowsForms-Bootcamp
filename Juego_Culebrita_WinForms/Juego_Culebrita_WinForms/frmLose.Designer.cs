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
            lblPlayerName.Location = new Point(32, 47);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(39, 15);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "Name";
            // 
            // lblFinalScore
            // 
            lblFinalScore.AutoSize = true;
            lblFinalScore.Location = new Point(32, 130);
            lblFinalScore.Name = "lblFinalScore";
            lblFinalScore.Size = new Size(36, 15);
            lblFinalScore.TabIndex = 1;
            lblFinalScore.Text = "Score";
            // 
            // bttnReiniciar
            // 
            bttnReiniciar.Location = new Point(32, 232);
            bttnReiniciar.Name = "bttnReiniciar";
            bttnReiniciar.Size = new Size(128, 56);
            bttnReiniciar.TabIndex = 2;
            bttnReiniciar.Text = "Reiniciar";
            bttnReiniciar.UseVisualStyleBackColor = true;
            bttnReiniciar.Click += bttnReiniciar_Click;
            // 
            // bttnMenu
            // 
            bttnMenu.Location = new Point(343, 232);
            bttnMenu.Name = "bttnMenu";
            bttnMenu.Size = new Size(128, 56);
            bttnMenu.TabIndex = 3;
            bttnMenu.Text = "Menu";
            bttnMenu.UseVisualStyleBackColor = true;
            bttnMenu.Click += bttnMenu_Click;
            // 
            // frmLose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 337);
            Controls.Add(bttnMenu);
            Controls.Add(bttnReiniciar);
            Controls.Add(lblFinalScore);
            Controls.Add(lblPlayerName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLose";
            ShowIcon = false;
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