using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalclinicpro
{
    internal class diagnotic : patient
    {
        public void insert(int pid, string diag, int medid, string test)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("insert into diagnotics values(" + pid + ",'" + diag + "'," + medid + ",'" + test + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تمت اضافة التشخيص بنجاح!");
        }
        public void delete(int pid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("delete from diagnotics where patient_id='" + pid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حذف التشخيص بنجاح!");
        }
        public void updatedia(int id,string dia)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update diagnotics set pathocase='" + dia + "' where patient_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل التشخيص بنجاح!");
        }
        public void updatemed(int id, int medid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update diagnotics set medicin_id=" + medid + " where patient_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل العلاج بنجاح!");
        }
        public void updatetest(int id, string test)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update diagnotics set tests='" + test + "' where patient_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل الفحوصات بنجاح!");
        }
    }
}
