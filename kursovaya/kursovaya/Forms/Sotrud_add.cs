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
    public partial class Sotrud_add : Form
    {
        public Model1 database { get; set; }
        public Sotrud_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || dateTimePicker1.Text == "" ||
              textBox6.Text == "" || textBox3.Text == "" ||
              textBox1.Text == ""  ||
              textBox4.Text == "" || textBox9.Text == "" ||
              textBox10.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Необходимо ввести все требуемые данные!");
                return;
            }

            int  personnel_number = 0;
            bool values_not_null = int.TryParse(textBox9.Text, out personnel_number);

            if (!values_not_null)
            {
                MessageBox.Show("Проверьте корректность введённых данных");
                return;
            }

            Sotrudniki employe = new Sotrudniki();
            employe.Address = textBox2.Text;
            employe.Date = dateTimePicker1.Value;
            employe.City = textBox6.Text;
            employe.name = textBox3.Text;
            employe.Pol = textBox1.Text;
            employe.Passport = textBox4.Text;
            employe.ID = personnel_number;
            employe.Phone_number = textBox10.Text;
            employe.Zarplata = Convert.ToDecimal(textBox5.Text);
            employe.Positions = textBox7.Text;
            database.Sotrudniki.Add(employe);
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sotrud_add_Load(object sender, EventArgs e)
        {

        }
    }
}
