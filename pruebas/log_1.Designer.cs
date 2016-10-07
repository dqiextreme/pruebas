namespace pruebas
{
    partial class log_1
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
            this.Pnl_Res = new System.Windows.Forms.Panel();
            this.Pnl_Q = new System.Windows.Forms.Panel();
            this.Pnl_Eval = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pnl_Res
            // 
            this.Pnl_Res.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Res.Location = new System.Drawing.Point(0, 268);
            this.Pnl_Res.Name = "Pnl_Res";
            this.Pnl_Res.Size = new System.Drawing.Size(482, 92);
            this.Pnl_Res.TabIndex = 0;
            // 
            // Pnl_Q
            // 
            this.Pnl_Q.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Q.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Q.Name = "Pnl_Q";
            this.Pnl_Q.Size = new System.Drawing.Size(212, 268);
            this.Pnl_Q.TabIndex = 1;
            // 
            // Pnl_Eval
            // 
            this.Pnl_Eval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Eval.Location = new System.Drawing.Point(212, 0);
            this.Pnl_Eval.Name = "Pnl_Eval";
            this.Pnl_Eval.Size = new System.Drawing.Size(270, 268);
            this.Pnl_Eval.TabIndex = 2;
            // 
            // log_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 360);
            this.Controls.Add(this.Pnl_Eval);
            this.Controls.Add(this.Pnl_Q);
            this.Controls.Add(this.Pnl_Res);
            this.Name = "log_1";
            this.Text = "log_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Res;
        private System.Windows.Forms.Panel Pnl_Q;
        private System.Windows.Forms.Panel Pnl_Eval;
    }
}