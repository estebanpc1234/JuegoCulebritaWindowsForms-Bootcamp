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
            lblScore = new Label();
            lblRecord = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Segoe UI", 15F);
            lblScore.Location = new Point(12, 604);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(112, 45);
            lblScore.TabIndex = 20;
            lblScore.Text = "Score: ";
            // 
            // lblRecord
            // 
            lblRecord.Font = new Font("Segoe UI", 15F);
            lblRecord.Location = new Point(193, 604);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(112, 45);
            lblRecord.TabIndex = 21;
            lblRecord.Text = "Record: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 658);
            Controls.Add(pictureBox1);
            Controls.Add(lblRecord);
            Controls.Add(lblScore);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGame";
            Text = "FrmGame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblScore;
        private Label lblRecord;
        private PictureBox pictureBox1;
    }
}