namespace pryEDPrimerProyecto
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.lblQueEsP = new System.Windows.Forms.Label();
            this.lblPila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQueEsP
            // 
            this.lblQueEsP.AutoSize = true;
            this.lblQueEsP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueEsP.Location = new System.Drawing.Point(12, 9);
            this.lblQueEsP.Name = "lblQueEsP";
            this.lblQueEsP.Size = new System.Drawing.Size(168, 31);
            this.lblQueEsP.TabIndex = 0;
            this.lblQueEsP.Text = "Que es Pila?";
            // 
            // lblPila
            // 
            this.lblPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPila.Location = new System.Drawing.Point(12, 50);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(326, 276);
            this.lblPila.TabIndex = 1;
            this.lblPila.Text = resources.GetString("lblPila.Text");
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 341);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.lblQueEsP);
            this.Name = "frmPila";
            this.Text = "Pila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueEsP;
        private System.Windows.Forms.Label lblPila;
    }
}