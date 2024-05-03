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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appointment app = new appointment();
            int id = Convert.ToInt32(textBox1.Text);
            string revdate = textBox2.Text;
            int seq =Convert.ToInt32( textBox3.Text);
            app.insert(id, revdate, seq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appointment pa = new appointment();
            int id = Convert.ToInt32(textBox4.Text);
            pa.delete(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from appointments", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appointment app = new appointment();
            if(listBox1.SelectedIndex==0)
            {
                string rev = textBox7.Text;
                int id = Convert.ToInt32(textBox6.Text);
                app.updaterev(id, rev);
            }
            else if(listBox1.SelectedIndex==1)
            {
                int seq = Convert.ToInt32(textBox7.Text);
                int id = Convert.ToInt32(textBox6.Text);
                app.updateseq(id, seq);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from appointments where patient_id like '%" + textBox5.Text.ToString() + "%'", con);
            DataTable d = new DataTable();
            da.Fill(d);
            this.dataGridView1.DataSource = d;
            con.Close();
        }
    }
}
