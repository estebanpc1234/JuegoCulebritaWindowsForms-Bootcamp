namespace Juego_Culebrita_WinForms
{
    partial class FrmGame
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
            components = new System.ComponentModel.Container();
            pbxTable = new PictureBox();
            lblScore = new Label();
            lblShowScore = new Label();
            tmGameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxTable).BeginInit();
            SuspendLayout();
            // 
            // pbxTable
            // 
            pbxTable.BackColor = SystemColors.ButtonShadow;
            pbxTable.BorderStyle = BorderStyle.Fixed3D;
            pbxTable.Location = new Point(78, 136);
            pbxTable.Name = "pbxTable";
            pbxTable.Size = new Size(863, 475);
            pbxTable.TabIndex = 0;
            pbxTable.TabStop = false;
            pbxTable.Paint += pbxTable_Paint;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 13.8F);
            lblScore.Location = new Point(75, 81);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(75, 31);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score:";
            // 
            // lblShowScore
            // 
            lblShowScore.AutoSize = true;
            lblShowScore.Font = new Font("Segoe UI", 13.8F);
            lblShowScore.Location = new Point(156, 81);
            lblShowScore.Name = "lblShowScore";
            lblShowScore.Size = new Size(26, 31);
            lblShowScore.TabIndex = 2;
            lblShowScore.Text = "0";
            // 
            // tmGameTimer
            // 
            tmGameTimer.Enabled = true;
            tmGameTimer.Tick += timer_tick;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 623);
            Controls.Add(lblShowScore);
            Controls.Add(lblScore);
            Controls.Add(pbxTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGame";
            Text = "FrmGame";
            KeyDown += FrmGame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbxTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxTable;
        private Label lblScore;
        private Label lblShowScore;
        private System.Windows.Forms.Timer tmGameTimer;
    }
}