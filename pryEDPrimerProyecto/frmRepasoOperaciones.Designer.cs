﻿namespace pryEDPrimerProyecto
{
    partial class frmRepasoOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstElegir = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.grlMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion a realizar en la base de datos:";
            // 
            // lstElegir
            // 
            this.lstElegir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstElegir.FormattingEnabled = true;
            this.lstElegir.Location = new System.Drawing.Point(285, 21);
            this.lstElegir.Name = "lstElegir";
            this.lstElegir.Size = new System.Drawing.Size(367, 21);
            this.lstElegir.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(680, 21);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(29, 50);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(740, 131);
            this.txtConsulta.TabIndex = 4;
            // 
            // grlMostrar
            // 
            this.grlMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlMostrar.Location = new System.Drawing.Point(29, 204);
            this.grlMostrar.Name = "grlMostrar";
            this.grlMostrar.Size = new System.Drawing.Size(740, 213);
            this.grlMostrar.TabIndex = 5;
            // 
            // frmRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grlMostrar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstElegir);
            this.Controls.Add(this.label1);
            this.Name = "frmRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepasoOperaciones";
            this.Load += new System.EventHandler(this.frmRepasoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstElegir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView grlMostrar;
    }
}