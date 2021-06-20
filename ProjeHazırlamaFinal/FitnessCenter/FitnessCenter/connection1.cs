using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace FitnessCenter
{
    class connection1
    {
        string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True";
        public void GirisYap (string ID , string Sifre)
        {

            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Giris where  ID='" + ID.ToString() + "' AND  NAME ='" + Sifre.ToString() + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
              
                KullanıcıGiris ss = new KullanıcıGiris();
                ss.Show();
            }
            else
            {
                MessageBox.Show("YANLIŞ ŞİFRE VEYA KULLANICI ADI GİRİŞİ!!! BİLGİLERİN DOĞRU OLDUĞUNA EMİN OLUP TEKRAR DENEYİNİZ!!!");
            }
        }
    }
}
