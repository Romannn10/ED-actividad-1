namespace pryEDPrimerProyecto
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.lblQueEsCola = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQueEsCola
            // 
            this.lblQueEsCola.AutoSize = true;
            this.lblQueEsCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueEsCola.Location = new System.Drawing.Point(1, 9);
            this.lblQueEsCola.Name = "lblQueEsCola";
            this.lblQueEsCola.Size = new System.Drawing.Size(179, 31);
            this.lblQueEsCola.TabIndex = 0;
            this.lblQueEsCola.Text = "Que es Cola?";
            // 
            // lblCola
            // 
            this.lblCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCola.Location = new System.Drawing.Point(3, 46);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(327, 211);
            this.lblCola.TabIndex = 1;
            this.lblCola.Text = resources.GetString("lblCola.Text");
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 266);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblQueEsCola);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmCola";
            this.Text = "Cola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueEsCola;
        private System.Windows.Forms.Label lblCola;
    }
}