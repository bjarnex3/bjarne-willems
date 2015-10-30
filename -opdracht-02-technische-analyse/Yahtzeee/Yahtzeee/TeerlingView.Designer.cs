namespace Yahtzeee
{
    partial class TeerlingView
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
            this.btnWerpen = new System.Windows.Forms.Button();
            this.lblTeerlingView1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWerpen
            // 
            this.btnWerpen.Location = new System.Drawing.Point(50, 201);
            this.btnWerpen.Name = "btnWerpen";
            this.btnWerpen.Size = new System.Drawing.Size(58, 23);
            this.btnWerpen.TabIndex = 1;
            this.btnWerpen.Text = "Werp";
            this.btnWerpen.UseVisualStyleBackColor = true;
            this.btnWerpen.Click += new System.EventHandler(this.btnWerpen_Click);
            // 
            // lblTeerlingView1
            // 
            this.lblTeerlingView1.BackColor = System.Drawing.Color.LightGray;
            this.lblTeerlingView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTeerlingView1.Location = new System.Drawing.Point(20, 52);
            this.lblTeerlingView1.Name = "lblTeerlingView1";
            this.lblTeerlingView1.Size = new System.Drawing.Size(120, 114);
            this.lblTeerlingView1.TabIndex = 2;
            this.lblTeerlingView1.Text = "label1";
            this.lblTeerlingView1.Click += new System.EventHandler(this.lblTeerlingView1_Click);
            // 
            // TeerlingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblTeerlingView1);
            this.Controls.Add(this.btnWerpen);
            this.Name = "TeerlingView";
            this.Size = new System.Drawing.Size(164, 227);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWerpen;
        private System.Windows.Forms.Label lblTeerlingView1;
    }
}
