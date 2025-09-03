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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

           

           menutoolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
            menutoolStripStatusLabel2.Text = DateTime.Now.ToString("dd/mm/yyyy");

            this.BackColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
