using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2Progra3
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar foto";
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaElegida = ofd.FileName;

                    // 1) Mostrar la foto en el PictureBox (sin bloquear el archivo original)
                    using (var imgTemp = Image.FromFile(rutaElegida))
                    {
                        fotopictureBox1.Image = new Bitmap(imgTemp);
                    }

                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void fotopictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
