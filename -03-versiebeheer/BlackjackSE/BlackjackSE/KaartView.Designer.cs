namespace BlackjackSE
{
    partial class KaartView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaartView));
      this.picKaart = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picKaart)).BeginInit();
      this.SuspendLayout();
      // 
      // picKaart
      // 
      this.picKaart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKaart.BackgroundImage")));
      this.picKaart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picKaart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picKaart.Location = new System.Drawing.Point(18, 15);
      this.picKaart.Name = "picKaart";
      this.picKaart.Size = new System.Drawing.Size(97, 141);
      this.picKaart.TabIndex = 0;
      this.picKaart.TabStop = false;
      // 
      // KaartView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.picKaart);
      this.Name = "KaartView";
      this.Size = new System.Drawing.Size(134, 173);
      ((System.ComponentModel.ISupportInitialize)(this.picKaart)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picKaart;
    }
}
