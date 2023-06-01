namespace pryEDPrimerProyecto
{
    partial class frmBaseDeDatos
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
            this.grlMostrar = new System.Windows.Forms.DataGridView();
            this.mrcProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionDeMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.mrcSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnMultiatributo = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.mrcAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).BeginInit();
            this.mrcProyeccion.SuspendLayout();
            this.mrcSeleccion.SuspendLayout();
            this.mrcAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlMostrar
            // 
            this.grlMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlMostrar.Location = new System.Drawing.Point(12, 12);
            this.grlMostrar.Name = "grlMostrar";
            this.grlMostrar.Size = new System.Drawing.Size(820, 363);
            this.grlMostrar.TabIndex = 1;
            // 
            // mrcProyeccion
            // 
            this.mrcProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.mrcProyeccion.Controls.Add(this.btnProyeccionDeMultiatributo);
            this.mrcProyeccion.Controls.Add(this.btnJuntar);
            this.mrcProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcProyeccion.Location = new System.Drawing.Point(12, 390);
            this.mrcProyeccion.Name = "mrcProyeccion";
            this.mrcProyeccion.Size = new System.Drawing.Size(262, 109);
            this.mrcProyeccion.TabIndex = 2;
            this.mrcProyeccion.TabStop = false;
            this.mrcProyeccion.Text = "Operaciones De Proyeccion";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(6, 22);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(238, 23);
            this.btnProyeccionSimple.TabIndex = 5;
            this.btnProyeccionSimple.Text = "Proyeccion simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnProyeccionDeMultiatributo
            // 
            this.btnProyeccionDeMultiatributo.Location = new System.Drawing.Point(6, 51);
            this.btnProyeccionDeMultiatributo.Name = "btnProyeccionDeMultiatributo";
            this.btnProyeccionDeMultiatributo.Size = new System.Drawing.Size(238, 23);
            this.btnProyeccionDeMultiatributo.TabIndex = 6;
            this.btnProyeccionDeMultiatributo.Text = "Proyeccion multiatributo";
            this.btnProyeccionDeMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionDeMultiatributo.Click += new System.EventHandler(this.btnProyeccionDeMultiatributo_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 80);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(238, 23);
            this.btnJuntar.TabIndex = 7;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // mrcSeleccion
            // 
            this.mrcSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.mrcSeleccion.Controls.Add(this.btnMultiatributo);
            this.mrcSeleccion.Controls.Add(this.btnConvolucion);
            this.mrcSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcSeleccion.Location = new System.Drawing.Point(290, 390);
            this.mrcSeleccion.Name = "mrcSeleccion";
            this.mrcSeleccion.Size = new System.Drawing.Size(262, 109);
            this.mrcSeleccion.TabIndex = 3;
            this.mrcSeleccion.TabStop = false;
            this.mrcSeleccion.Text = "Operaciones De Seleccion";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 22);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(238, 23);
            this.btnSeleccionSimple.TabIndex = 8;
            this.btnSeleccionSimple.Text = "Seleccion Simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // btnMultiatributo
            // 
            this.btnMultiatributo.Location = new System.Drawing.Point(6, 51);
            this.btnMultiatributo.Name = "btnMultiatributo";
            this.btnMultiatributo.Size = new System.Drawing.Size(238, 23);
            this.btnMultiatributo.TabIndex = 9;
            this.btnMultiatributo.Text = "Seleccion Multiatributo";
            this.btnMultiatributo.UseVisualStyleBackColor = true;
            this.btnMultiatributo.Click += new System.EventHandler(this.btnMultiatributo_Click);
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(6, 80);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(238, 23);
            this.btnConvolucion.TabIndex = 10;
            this.btnConvolucion.Text = "Seleccion por convolucion";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // mrcAlgebraicas
            // 
            this.mrcAlgebraicas.Controls.Add(this.btnUnion);
            this.mrcAlgebraicas.Controls.Add(this.btnInterseccion);
            this.mrcAlgebraicas.Controls.Add(this.btnDiferencia);
            this.mrcAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAlgebraicas.Location = new System.Drawing.Point(571, 390);
            this.mrcAlgebraicas.Name = "mrcAlgebraicas";
            this.mrcAlgebraicas.Size = new System.Drawing.Size(262, 109);
            this.mrcAlgebraicas.TabIndex = 4;
            this.mrcAlgebraicas.TabStop = false;
            this.mrcAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 22);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(238, 23);
            this.btnUnion.TabIndex = 8;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 51);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(238, 23);
            this.btnInterseccion.TabIndex = 9;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 80);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(238, 23);
            this.btnDiferencia.TabIndex = 10;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 511);
            this.Controls.Add(this.mrcAlgebraicas);
            this.Controls.Add(this.mrcSeleccion);
            this.Controls.Add(this.mrcProyeccion);
            this.Controls.Add(this.grlMostrar);
            this.Name = "frmBaseDeDatos";
            this.Text = "frmBaseDeDatos";
            this.Load += new System.EventHandler(this.frmBaseDeDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlMostrar)).EndInit();
            this.mrcProyeccion.ResumeLayout(false);
            this.mrcSeleccion.ResumeLayout(false);
            this.mrcAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlMostrar;
        private System.Windows.Forms.GroupBox mrcProyeccion;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.Button btnProyeccionDeMultiatributo;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox mrcSeleccion;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnMultiatributo;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.GroupBox mrcAlgebraicas;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnDiferencia;
    }
}