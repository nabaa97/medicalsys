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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient pa = new patient();
            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            string gender = textBox3.Text;
            int phone = Convert.ToInt32(textBox4.Text);
            pa.insert(name, age, gender, phone);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from patients", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patient pa = new patient();
            if(listBox1.SelectedIndex==0)
            {
                int age = Convert.ToInt32(textBox8.Text);
                string name = textBox8.Text;
                pa.updateage(name, age);
            }
            else if(listBox1.SelectedIndex==1)
            {
                string gen = textBox8.Text;
                string name = textBox8.Text;
                pa.updategen(name, gen);
            }
            else if(listBox1.SelectedIndex==2)
            {
                int ph = Convert.ToInt32(textBox8.Text);
                string name = textBox8.Text;
                pa.updateph(name, ph);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from patients where patient_name like '%" + textBox6.Text + "%'", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }
    }
}
