namespace pryEDPrimerProyecto
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.lblListaDoble = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListaDoble
            // 
            this.lblListaDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDoble.Location = new System.Drawing.Point(12, 37);
            this.lblListaDoble.Name = "lblListaDoble";
            this.lblListaDoble.Size = new System.Drawing.Size(307, 257);
            this.lblListaDoble.TabIndex = 0;
            this.lblListaDoble.Text = resources.GetString("lblListaDoble.Text");
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 316);
            this.Controls.Add(this.lblListaDoble);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListaDoble;
    }
}