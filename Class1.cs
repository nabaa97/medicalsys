using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medicalclinicpro
{
    internal class patient
    {
        public void insert(string na, int ag, string gen, int phno)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("insert into patients values('" + na + "'," + ag + ",'" + gen + "'," + phno + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت اضافة مريض بنجاح!");

        }
        public void delete(string pname)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("delete from patients where patient_name='" + pname + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حذف المريض بنجاح!");
        }
        public void updateage(string name,int age)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update patients set patient_age=" + age + " where patient_name='" + name + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل عمر المريض بنجاح!");
        }
        public void updategen(string name, string gen)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update patients set patient_gender='" + gen + "' where patient_name='" + name + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل جنس المريض بنجاح!");
        }
        public void updateph(string name, int ph)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update patients set patient_phoneno=" + ph + " where patient_name='" + name + "' ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل رقم هاتف المريض بنجاح!");
        }
    }
}
