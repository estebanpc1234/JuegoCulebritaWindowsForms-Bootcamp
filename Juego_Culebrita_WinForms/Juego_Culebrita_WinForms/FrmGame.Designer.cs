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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            pbxTable = new PictureBox();
            lblScore = new Label();
            tmGameTimer = new System.Windows.Forms.Timer(components);
            txtShowScore = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxTable).BeginInit();
            SuspendLayout();
            // 
            // pbxTable
            // 
            pbxTable.BackColor = SystemColors.ButtonShadow;
            pbxTable.BorderStyle = BorderStyle.Fixed3D;
            pbxTable.Image = (Image)resources.GetObject("pbxTable.Image");
            pbxTable.Location = new Point(78, 136);
            pbxTable.Name = "pbxTable";
            pbxTable.Size = new Size(552, 487);
            pbxTable.SizeMode = PictureBoxSizeMode.AutoSize;
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
            // tmGameTimer
            // 
            tmGameTimer.Enabled = true;
            tmGameTimer.Tick += timer_tick;
            // 
            // txtShowScore
            // 
            txtShowScore.Enabled = false;
            txtShowScore.Font = new Font("Segoe UI", 15F);
            txtShowScore.HideSelection = false;
            txtShowScore.Location = new Point(156, 75);
            txtShowScore.Name = "txtShowScore";
            txtShowScore.ReadOnly = true;
            txtShowScore.Size = new Size(67, 41);
            txtShowScore.TabIndex = 2;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 623);
            Controls.Add(txtShowScore);
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
        private System.Windows.Forms.Timer tmGameTimer;
        private TextBox txtShowScore;
    }
}