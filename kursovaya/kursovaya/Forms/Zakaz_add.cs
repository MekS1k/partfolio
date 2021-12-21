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
    public partial class Form2 : Form
    {

        public Model1 db { get; set; }
      

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakazi frm = new Zakazi();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
                textBox3.Text == "" || dateTimePicker1.Text == "" ||
                textBox4.Text == "" )
            {
                MessageBox.Show("Необходимо ввести все требуемые данные!");
                return;
            }

            int order_code;
            bool order_code_changed = int.TryParse(textBox1.Text, out order_code);
            if (!order_code_changed)
            {
                MessageBox.Show("Неверный формат кода!");
                return;
            }

           Order order = new Order();

            order.Cost = Convert.ToDecimal(textBox4.Text);
            order.Pokupatel = textBox2.Text;
            order.kod_zakaza = order_code;
            order.Date = dateTimePicker1.Value;
            order.Number = int.Parse(textBox3.Text.ToString());


            db.Order.Add(order);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            
        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
