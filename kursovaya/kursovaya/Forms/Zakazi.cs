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
    public partial class Zakazi : Form
    {
      
        Model1 database = new Model1();
        public Zakazi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.Show();
            this.Hide();
        }

        private void Zakazi_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = database.Order.ToList();

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
             Form2 order_add = new Form2();

            order_add.db = database;

            DialogResult dialogResult = order_add.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                orderBindingSource.DataSource = database.Order.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order order = (Order)orderBindingSource.Current;

            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись " + order.kod_zakaza.ToString(),
            "Удаление сотрудника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                database.Order.Remove(order);
                try
                {
                    database.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                orderBindingSource.DataSource = database.Order.ToList();
            }

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zakazi_edit order_change = new Zakazi_edit();
            Order order = (Order)orderBindingSource.Current;
            order_change.database = database;
            order_change.order = order;

            DialogResult dialogResult = order_change.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                orderBindingSource.DataSource = database.Order.ToList();
            }

        }
    }
}
