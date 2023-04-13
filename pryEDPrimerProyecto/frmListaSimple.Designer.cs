namespace pryEDPrimerProyecto
{
    partial class frmListaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaSimple));
            this.lblListaSimple = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListaSimple
            // 
            this.lblListaSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaSimple.Location = new System.Drawing.Point(12, 9);
            this.lblListaSimple.Name = "lblListaSimple";
            this.lblListaSimple.Size = new System.Drawing.Size(313, 261);
            this.lblListaSimple.TabIndex = 0;
            this.lblListaSimple.Text = resources.GetString("lblListaSimple.Text");
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 271);
            this.Controls.Add(this.lblListaSimple);
            this.Name = "frmListaSimple";
            this.Text = "frmListaSimple";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListaSimple;
    }
}