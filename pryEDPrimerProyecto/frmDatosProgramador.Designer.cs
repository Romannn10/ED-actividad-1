namespace pryEDPrimerProyecto
{
    partial class frmDatosProgramador
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDni2 = new System.Windows.Forms.Label();
            this.lblEstructuraDatos = new System.Windows.Forms.Label();
            this.lblAnalistaSistemas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Lavender;
            this.lblNombre.Location = new System.Drawing.Point(176, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(158, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Roman Mamondez";
            // 
            // imgFoto
            // 
            this.imgFoto.Image = global::pryEDPrimerProyecto.Properties.Resources._425ee2aa_bfe2_49fe_a7ca_0e87f57ad5df;
            this.imgFoto.Location = new System.Drawing.Point(12, 12);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(158, 245);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 1;
            this.imgFoto.TabStop = false;
            this.imgFoto.Click += new System.EventHandler(this.imgFoto_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDNI.Location = new System.Drawing.Point(233, 62);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(90, 22);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "44900246";
            // 
            // lblDni2
            // 
            this.lblDni2.AutoSize = true;
            this.lblDni2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDni2.Location = new System.Drawing.Point(182, 62);
            this.lblDni2.Name = "lblDni2";
            this.lblDni2.Size = new System.Drawing.Size(45, 22);
            this.lblDni2.TabIndex = 3;
            this.lblDni2.Text = "DNI:";
            this.lblDni2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEstructuraDatos
            // 
            this.lblEstructuraDatos.AutoSize = true;
            this.lblEstructuraDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstructuraDatos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstructuraDatos.Location = new System.Drawing.Point(177, 187);
            this.lblEstructuraDatos.Name = "lblEstructuraDatos";
            this.lblEstructuraDatos.Size = new System.Drawing.Size(166, 22);
            this.lblEstructuraDatos.TabIndex = 4;
            this.lblEstructuraDatos.Text = "Estructura de datos";
            // 
            // lblAnalistaSistemas
            // 
            this.lblAnalistaSistemas.AutoSize = true;
            this.lblAnalistaSistemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalistaSistemas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnalistaSistemas.Location = new System.Drawing.Point(177, 152);
            this.lblAnalistaSistemas.Name = "lblAnalistaSistemas";
            this.lblAnalistaSistemas.Size = new System.Drawing.Size(177, 22);
            this.lblAnalistaSistemas.TabIndex = 5;
            this.lblAnalistaSistemas.Text = "Analista de Sistemas";
            // 
            // frmDatosProgramador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.lblAnalistaSistemas);
            this.Controls.Add(this.lblEstructuraDatos);
            this.Controls.Add(this.lblDni2);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.imgFoto);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmDatosProgramador";
            this.Text = "Datos de programador";
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDni2;
        private System.Windows.Forms.Label lblEstructuraDatos;
        private System.Windows.Forms.Label lblAnalistaSistemas;
    }
}