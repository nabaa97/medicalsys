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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctor dr = new doctor();
            string na = textBox1.Text;
            string spec = textBox2.Text;
            int phno = Convert.ToInt32(textBox3.Text);
            dr.insert(na, spec, phno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor dr = new doctor();
            string dname=textBox4.Text;
            dr.delete(dname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from doctors", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctor dr = new doctor();
            if(listBox1.SelectedIndex==0)
            {
                string spec = textBox7.Text;
                string name = textBox6.Text;
                dr.updatespe(name, spec);
            }
            else if(listBox1.SelectedIndex==1)
            {
                int ph = Convert.ToInt32(textBox7.Text);
                string name = textBox6.Text;
                dr.updatepho(name, ph);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from doctors where doctor_name like '%" + textBox5.Text + "%'", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }
    }
}
