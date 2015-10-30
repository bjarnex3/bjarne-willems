namespace BlackjackSE
{
    partial class ScoreBordView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.lblWinStreak = new System.Windows.Forms.Label();
      this.lblScorePC = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Score: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Winstreak: ";
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.Location = new System.Drawing.Point(80, 9);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(19, 13);
      this.lblScore.TabIndex = 2;
      this.lblScore.Text = "20";
      // 
      // lblWinStreak
      // 
      this.lblWinStreak.AutoSize = true;
      this.lblWinStreak.Location = new System.Drawing.Point(80, 55);
      this.lblWinStreak.Name = "lblWinStreak";
      this.lblWinStreak.Size = new System.Drawing.Size(13, 13);
      this.lblWinStreak.TabIndex = 3;
      this.lblWinStreak.Text = "0";
      
      // 
      // lblScorePC
      // 
      this.lblScorePC.AutoSize = true;
      this.lblScorePC.Location = new System.Drawing.Point(80, 32);
      this.lblScorePC.Name = "lblScorePC";
      this.lblScorePC.Size = new System.Drawing.Size(19, 13);
      this.lblScorePC.TabIndex = 5;
      this.lblScorePC.Text = "20";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 31);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Score PC: ";
      // 
      // ScoreBordView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblScorePC);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lblWinStreak);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "ScoreBordView";
      this.Size = new System.Drawing.Size(110, 83);
      this.Load += new System.EventHandler(this.ScoreBordView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWinStreak;
        private System.Windows.Forms.Label lblScorePC;
        private System.Windows.Forms.Label label4;
    }
}
