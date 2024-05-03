using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalclinicpro
{
    internal class appointment : patient
    {
        public void insert(int id, string redate, int seq)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("insert into appointments values(" + id + ",'" + redate + "'," + seq + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("!تمت اضافة الحجز بنجاح");
        }
        public void delete(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("delete from appointments where patient_id='" + id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حذف الحجز بنجاح!");
        }
        public void updaterev(int id, string rev)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update appointments set review_date='" + rev + "' where patient_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل موعد المراجعة بنجاح!");
        }
        public void updateseq(int id, int seq)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update appointments set reservation_seq='" + seq + "' where patient_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل تسلسل المريض بنجاح!");
        }

    }
}
