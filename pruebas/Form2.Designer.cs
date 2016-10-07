namespace pruebas
{
    partial class Form2
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
            this.laberinto1 = new pruebas.Laberinto();
            this.laberinto21 = new pruebas.Laberinto2();
            this.SuspendLayout();
            // 
            // laberinto1
            // 
            this.laberinto1.Location = new System.Drawing.Point(12, 12);
            this.laberinto1.Name = "laberinto1";
            this.laberinto1.Size = new System.Drawing.Size(194, 172);
            this.laberinto1.TabIndex = 0;
            // 
            // laberinto21
            // 
            this.laberinto21.Location = new System.Drawing.Point(212, 12);
            this.laberinto21.Name = "laberinto21";
            this.laberinto21.Size = new System.Drawing.Size(417, 350);
            this.laberinto21.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 502);
            this.Controls.Add(this.laberinto21);
            this.Controls.Add(this.laberinto1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Laberinto laberinto1;
        private Laberinto2 laberinto21;

    }
}