namespace Tp2Progra3
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArtiuclosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArtiuclosvariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtiuclosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeLosArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menutoolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menutoolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeArtiuclosToolStripMenuItem,
            this.buscarArtiuclosvariosToolStripMenuItem,
            this.agregarArtiuclosToolStripMenuItem,
            this.modificarArticulosToolStripMenuItem,
            this.eliminarArticulosToolStripMenuItem,
            this.detallesDeLosArticulosToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.articulosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // listadoDeArtiuclosToolStripMenuItem
            // 
            this.listadoDeArtiuclosToolStripMenuItem.Name = "listadoDeArtiuclosToolStripMenuItem";
            this.listadoDeArtiuclosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listadoDeArtiuclosToolStripMenuItem.Text = "Listado de Artiuclos";
            // 
            // buscarArtiuclosvariosToolStripMenuItem
            // 
            this.buscarArtiuclosvariosToolStripMenuItem.Name = "buscarArtiuclosvariosToolStripMenuItem";
            this.buscarArtiuclosvariosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscarArtiuclosvariosToolStripMenuItem.Text = "Buscar Artiuclos (varios)";
            // 
            // agregarArtiuclosToolStripMenuItem
            // 
            this.agregarArtiuclosToolStripMenuItem.Name = "agregarArtiuclosToolStripMenuItem";
            this.agregarArtiuclosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.agregarArtiuclosToolStripMenuItem.Text = "Agregar Artiuclos";
            // 
            // modificarArticulosToolStripMenuItem
            // 
            this.modificarArticulosToolStripMenuItem.Name = "modificarArticulosToolStripMenuItem";
            this.modificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modificarArticulosToolStripMenuItem.Text = "Modificar Articulos";
            // 
            // eliminarArticulosToolStripMenuItem
            // 
            this.eliminarArticulosToolStripMenuItem.Name = "eliminarArticulosToolStripMenuItem";
            this.eliminarArticulosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eliminarArticulosToolStripMenuItem.Text = "Eliminar articulos";
            // 
            // detallesDeLosArticulosToolStripMenuItem
            // 
            this.detallesDeLosArticulosToolStripMenuItem.Name = "detallesDeLosArticulosToolStripMenuItem";
            this.detallesDeLosArticulosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.detallesDeLosArticulosToolStripMenuItem.Text = "Detalles de los Articulos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutoolStripStatusLabel2,
            this.menutoolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menutoolStripStatusLabel2
            // 
            this.menutoolStripStatusLabel2.Name = "menutoolStripStatusLabel2";
            this.menutoolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.menutoolStripStatusLabel2.Text = "toolStripStatusLabel1";
            // 
            // menutoolStripStatusLabel1
            // 
            this.menutoolStripStatusLabel1.Name = "menutoolStripStatusLabel1";
            this.menutoolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.menutoolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArtiuclosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarArtiuclosvariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtiuclosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeLosArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel menutoolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel menutoolStripStatusLabel1;
    }
}