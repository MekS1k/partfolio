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
    public partial class Sotrud_edit : Form
    {
        public Model1 database { get; set; }
        public Sotrudniki sot { get; set; }
      
        public Sotrud_edit()
        {
            InitializeComponent();
        }

        private void Sotrud_edit_Load(object sender, EventArgs e)
        {

            textBox7.Text = sot.Positions.ToString();

            textBox5.Text = sot.Zarplata.ToString();

            textBox9.Text = sot.ID.ToString();
            textBox2.Text = sot.Address.ToString();

            dateTimePicker1.Value = sot.Date;
            textBox6.Text = sot.City.ToString();
            textBox3.Text = sot.name.ToString();
            textBox1.Text = sot.Pol.ToString();


            textBox4.Text = sot.Passport.ToString();

            textBox10.Text = sot.Phone_number.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sot.Positions =  textBox7.Text ;

          sot.Zarplata = Convert.ToDecimal(textBox5.Text) ;

             sot.ID = int.Parse(textBox9.Text.ToString());
            sot.Address = textBox2.Text ;

             sot.Date = dateTimePicker1.Value ;
            sot.City = textBox6.Text;
             sot.name = textBox3.Text ;
            sot.Pol  = textBox1.Text  ;
            sot.Passport = textBox4.Text ;

            sot.Phone_number = textBox10.Text  ;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
