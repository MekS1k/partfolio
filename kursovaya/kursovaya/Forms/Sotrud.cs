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
    public partial class Form1 : Form
    {
        Model1 database = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sotrudnikiBindingSource4.DataSource = database.Sotrudniki.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sotrud_add emp_add_form = new Sotrud_add();

            emp_add_form.database = database;

            DialogResult dialogResult = emp_add_form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                sotrudnikiBindingSource4.DataSource = database.Sotrudniki.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sotrudniki employe = (Sotrudniki)sotrudnikiBindingSource4.Current;

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись " + employe.ID.ToString(),
            "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                database.Sotrudniki.Remove(employe);
                try
                {
                    database.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                sotrudnikiBindingSource4.DataSource = database.Sotrudniki.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sotrud_edit sot_change = new Sotrud_edit();
            Sotrudniki sot = (Sotrudniki)sotrudnikiBindingSource4.Current;
            sot_change.database = database;
            sot_change.sot = sot;

            DialogResult dialogResult = sot_change.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                sotrudnikiBindingSource4.DataSource = database.Sotrudniki.ToList();
            }
        }
    }
}
