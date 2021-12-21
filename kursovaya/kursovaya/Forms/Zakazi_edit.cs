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
    public partial class Zakazi_edit : Form
    {
        public Model1 database { get; set; }
        public Order order { get; set; } 
        public Zakazi_edit()
        {
            InitializeComponent();
        }

        private void Zakazi_edit_Load(object sender, EventArgs e)
        {
           

            textBox1.Text = order.kod_zakaza.ToString();
            textBox2.Text = order.Pokupatel.ToString();
            dateTimePicker1.Value = order.Date;
            textBox4.Text = order.Cost.ToString();
            textBox3.Text = order.Number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = order.kod_zakaza.ToString();
            order.Cost= Convert.ToDecimal(textBox4.Text);
            order.Pokupatel = textBox2.Text;
            order.Date = dateTimePicker1.Value;
            order.Number = int.Parse(textBox3.Text.ToString());

            try
            {
                database.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakazi frm = new Zakazi();
            frm.Show();
            this.Hide();
        }
    }
}
