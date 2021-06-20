using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace FitnessCenter
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class KullanıcıGiris : Window
    {
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True";
        


        public void K_Bilgiler_Kaydet_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Tbl_KisiselBilgiler (ID,AdSoyad,Yas,Cinsiyet,BoyKilo,TcNo) values ('" + ID_txt.Text.ToString() + "','" + AdSoyad_txt.Text.ToString() + "', '" + Yas_txt.Text.ToString() + "' , '" + Cinsiyet_txt.Text.ToString() + "' , '" + BoyKilo_txt.Text.ToString() + "' ,  '" + TcNo_txt.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
            }

        }

        private void DEVAM_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            IletisimGiris ss = new IletisimGiris();
            ss.Show();
        }

    }

}