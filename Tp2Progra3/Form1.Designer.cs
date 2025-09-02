namespace Tp2Progra3
{
    partial class Form1
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
            this.ingresarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingresarbutton
            // 
            this.ingresarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ingresarbutton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ingresarbutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.ingresarbutton.Location = new System.Drawing.Point(939, 514);
            this.ingresarbutton.Name = "ingresarbutton";
            this.ingresarbutton.Size = new System.Drawing.Size(75, 23);
            this.ingresarbutton.TabIndex = 1;
            this.ingresarbutton.Text = "ingresar";
            this.ingresarbutton.UseVisualStyleBackColor = true;
            this.ingresarbutton.Click += new System.EventHandler(this.ingresarbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(783, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "para ingresar al sistema,enter en ingresar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tp2Progra3.Properties.Resources.fondo4;
            this.ClientSize = new System.Drawing.Size(1495, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresarbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ingresarbutton;
        private System.Windows.Forms.Label label2;
    }
}

