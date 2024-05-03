using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicalclinicpro
{
    internal class medicin : patient
    {
        public void insert(string medname)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("insert into medicins values('" + medname + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("!تمت اضافة العلاج بنجاح");
        }
        public void delete(int mid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("delete from medicins where medicin_id='" + mid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم حذف العلاج بنجاح!");
        }
        public void updatename(int id,string name)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=DESKTOP-HA4CBP8\\SQLEXPRESS01;database=DB_clinic;integrated security=true";
            SqlCommand cmd = new SqlCommand("update medicins set medicin_name='" + name + "' where medicin_id=" + id + " ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم تعديل اسم العلاج بنجاح!");
        }
    }
}
