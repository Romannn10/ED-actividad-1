﻿namespace pryEDPrimerProyecto
{
    partial class frmEstructuraDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNoLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesConTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repasoDeOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSistemaToolStripMenuItem,
            this.menuLinealesToolStripMenuItem,
            this.menuNoLinealesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuSistemaToolStripMenuItem
            // 
            this.menuSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosProgramadorToolStripMenuItem});
            this.menuSistemaToolStripMenuItem.Name = "menuSistemaToolStripMenuItem";
            this.menuSistemaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.menuSistemaToolStripMenuItem.Text = "Menu Sistema";
            // 
            // datosProgramadorToolStripMenuItem
            // 
            this.datosProgramadorToolStripMenuItem.Name = "datosProgramadorToolStripMenuItem";
            this.datosProgramadorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.datosProgramadorToolStripMenuItem.Text = "Datos programador";
            this.datosProgramadorToolStripMenuItem.Click += new System.EventHandler(this.datosProgramadorToolStripMenuItem_Click);
            // 
            // menuLinealesToolStripMenuItem
            // 
            this.menuLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilaToolStripMenuItem,
            this.colaToolStripMenuItem,
            this.lIstaToolStripMenuItem});
            this.menuLinealesToolStripMenuItem.Name = "menuLinealesToolStripMenuItem";
            this.menuLinealesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.menuLinealesToolStripMenuItem.Text = "Menu Lineales";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.pilaToolStripMenuItem.Text = "Pila";
            this.pilaToolStripMenuItem.Click += new System.EventHandler(this.pilaToolStripMenuItem_Click);
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.colaToolStripMenuItem.Text = "Cola";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // lIstaToolStripMenuItem
            // 
            this.lIstaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleToolStripMenuItem,
            this.dobleToolStripMenuItem});
            this.lIstaToolStripMenuItem.Name = "lIstaToolStripMenuItem";
            this.lIstaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.lIstaToolStripMenuItem.Text = "LIsta";
            // 
            // simpleToolStripMenuItem
            // 
            this.simpleToolStripMenuItem.Name = "simpleToolStripMenuItem";
            this.simpleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.simpleToolStripMenuItem.Text = "Simple";
            this.simpleToolStripMenuItem.Click += new System.EventHandler(this.simpleToolStripMenuItem_Click);
            // 
            // dobleToolStripMenuItem
            // 
            this.dobleToolStripMenuItem.Name = "dobleToolStripMenuItem";
            this.dobleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dobleToolStripMenuItem.Text = "Doble";
            this.dobleToolStripMenuItem.Click += new System.EventHandler(this.dobleToolStripMenuItem_Click);
            // 
            // menuNoLinealesToolStripMenuItem
            // 
            this.menuNoLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem});
            this.menuNoLinealesToolStripMenuItem.Name = "menuNoLinealesToolStripMenuItem";
            this.menuNoLinealesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.menuNoLinealesToolStripMenuItem.Text = "Menu no lineales";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol Binario";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesConTablaToolStripMenuItem,
            this.consultasEnBaseDeDatosToolStripMenuItem,
            this.repasoDeOperacionesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem1.Text = "Base de datos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // operacionesConTablaToolStripMenuItem
            // 
            this.operacionesConTablaToolStripMenuItem.Name = "operacionesConTablaToolStripMenuItem";
            this.operacionesConTablaToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.operacionesConTablaToolStripMenuItem.Text = "Operaciones con tablas de bases de datos";
            this.operacionesConTablaToolStripMenuItem.Click += new System.EventHandler(this.operacionesConTablaToolStripMenuItem_Click);
            // 
            // consultasEnBaseDeDatosToolStripMenuItem
            // 
            this.consultasEnBaseDeDatosToolStripMenuItem.Name = "consultasEnBaseDeDatosToolStripMenuItem";
            this.consultasEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.consultasEnBaseDeDatosToolStripMenuItem.Text = "Consultas en base de datos";
            this.consultasEnBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultasEnBaseDeDatosToolStripMenuItem_Click);
            // 
            // repasoDeOperacionesToolStripMenuItem
            // 
            this.repasoDeOperacionesToolStripMenuItem.Name = "repasoDeOperacionesToolStripMenuItem";
            this.repasoDeOperacionesToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.repasoDeOperacionesToolStripMenuItem.Text = "Repaso de operaciones..";
            this.repasoDeOperacionesToolStripMenuItem.Click += new System.EventHandler(this.repasoDeOperacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmEstructuraDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 358);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstructuraDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobleToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNoLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operacionesConTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasEnBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repasoDeOperacionesToolStripMenuItem;
    }
}

