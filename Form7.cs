using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalclinicpro
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            medicin med = new medicin();
            string medname = textBox1.Text;
            med.insert(medname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from medicins", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            medicin med = new medicin();
            int id = Convert.ToInt32(textBox4.Text);
            string name = textBox5.Text;
            med.updatename(id, name);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from medicins where medicin_name like '%" + textBox3.Text + "%'", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }
    }
}
