using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1  frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dolznosti frm = new Dolznosti();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zakazi frm = new Zakazi();
          
            this.Hide();
            DialogResult dialogResult = frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oproge frm = new oproge();
            frm.Show();
            this.Hide();
        }
    }
}
