using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalclinicpro
{
    internal class doctor
    {
        public void insert(string na, string spec, int phno)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("insert into doctors values('" + na + "','" + spec + "'," + phno + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت اضافة الطبيب بنجاح!");
        }
        public void delete(string dname)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("delete from doctors where doctor_name='" + dname + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حذف الطبيب بنجاح!");
        }
        public void updatespe(string name,string spe)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update doctors set doctor_spec='" + spe + "' where doctor_name='" + name + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل التخصص بنجاح!");
        }
        public void updatepho(string name,int ph)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update doctors set doctor_phoneno=" + ph + " where doctor_name='" + name + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل رقم الهاتف بنجاح!");
        }
    }
}
