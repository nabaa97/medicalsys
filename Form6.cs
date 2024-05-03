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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diagnotic di = new diagnotic();
            int id = Convert.ToInt32(textBox1.Text);
            string diag = textBox2.Text;
            int med = Convert.ToInt32(textBox3.Text);
            string test = textBox4.Text;
            di.insert(id, diag, med, test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diagnotic di = new diagnotic();
            int id = Convert.ToInt32(textBox5.Text);
            di.delete(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from diagnotics", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diagnotic di = new diagnotic();
            if(listBox1.SelectedIndex==0)
            {
                string dia = textBox8.Text;
                int id = Convert.ToInt32(textBox7.Text);
                di.updatedia(id, dia);
            }
            else if(listBox1.SelectedIndex == 1)
            {
                int medid = Convert.ToInt32(textBox8.Text);
                int id = Convert.ToInt32(textBox7.Text);
                di.updatemed(id, medid);
            }
            else if(listBox1.SelectedIndex==2)
            {
                string test = textBox8.Text;
                int id = Convert.ToInt32(textBox7.Text);
                di.updatetest(id, test);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from diagnotics where patient_id like '%" + textBox6.Text.ToString() + "%' ", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }
    }
}
