namespace BlackjackSE
{
    partial class KnoppenView
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
            this.btnKaartNemen = new System.Windows.Forms.Button();
            this.btnGeenKaart = new System.Windows.Forms.Button();
            this.btnNieuwSpel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaartNemen
            // 
            this.btnKaartNemen.Location = new System.Drawing.Point(18, 180);
            this.btnKaartNemen.Name = "btnKaartNemen";
            this.btnKaartNemen.Size = new System.Drawing.Size(109, 23);
            this.btnKaartNemen.TabIndex = 0;
            this.btnKaartNemen.Text = "neem kaart";
            this.btnKaartNemen.UseVisualStyleBackColor = true;
            this.btnKaartNemen.Click += new System.EventHandler(this.btnKaartNemen_Click);
            // 
            // btnGeenKaart
            // 
            this.btnGeenKaart.Location = new System.Drawing.Point(18, 219);
            this.btnGeenKaart.Name = "btnGeenKaart";
            this.btnGeenKaart.Size = new System.Drawing.Size(109, 23);
            this.btnGeenKaart.TabIndex = 1;
            this.btnGeenKaart.Text = "geen kaart nemen";
            this.btnGeenKaart.UseVisualStyleBackColor = true;
            this.btnGeenKaart.Click += new System.EventHandler(this.btnGeenKaart_Click);
            // 
            // btnNieuwSpel
            // 
            this.btnNieuwSpel.Location = new System.Drawing.Point(111, 265);
            this.btnNieuwSpel.Name = "btnNieuwSpel";
            this.btnNieuwSpel.Size = new System.Drawing.Size(75, 23);
            this.btnNieuwSpel.TabIndex = 2;
            this.btnNieuwSpel.Text = "nieuw spel";
            this.btnNieuwSpel.UseVisualStyleBackColor = true;
            this.btnNieuwSpel.Click += new System.EventHandler(this.btnNieuwSpel_Click);
            // 
            // KnoppenView
            // 
            this.Controls.Add(this.btnNieuwSpel);
            this.Controls.Add(this.btnGeenKaart);
            this.Controls.Add(this.btnKaartNemen);
            this.Name = "KnoppenView";
            this.Size = new System.Drawing.Size(319, 328);
            this.Load += new System.EventHandler(this.KnoppenView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnKaartNemen;
        private System.Windows.Forms.Button btnGeenKaart;
        private System.Windows.Forms.Button btnNieuwSpel;
    }
}
