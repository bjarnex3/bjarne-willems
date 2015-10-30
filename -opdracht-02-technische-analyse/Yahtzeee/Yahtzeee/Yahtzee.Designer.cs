namespace Yahtzeee
{
    partial class Yahtzee
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
            this.btnWerpen = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWerpen
            // 
            this.btnWerpen.Location = new System.Drawing.Point(15, 240);
            this.btnWerpen.Name = "btnWerpen";
            this.btnWerpen.Size = new System.Drawing.Size(75, 23);
            this.btnWerpen.TabIndex = 0;
            this.btnWerpen.Text = "werpen";
            this.btnWerpen.UseVisualStyleBackColor = true;
            this.btnWerpen.Click += new System.EventHandler(this.btnWerpen_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(12, 21);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: ";
            // 
            // Yahtzee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(268, 289);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnWerpen);
            this.Name = "Yahtzee";
            this.Text = "Yahtzee";
            this.Load += new System.EventHandler(this.Yahtzee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWerpen;
        private System.Windows.Forms.Label lblScore;

    }
}

