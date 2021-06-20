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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace FitnessCenter
{
    /// <summary>
    /// DigerGiris.xaml etkileşim mantığı
    /// </summary>
    public partial class DigerGiris : Window
    {
        public DigerGiris()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True";
        

        private void D_Bilgiler_Kaydet_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into DigerBilgiler (ID2,KayitTarihi,KayitSure) values ('" + ID_txt2.Text.ToString() + "','" + K_Tarihi_txt.Text.ToString() + "', '" + K_Suresi_txt.Text.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
            }
        }

        private void DEVAM2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Kisi_Ara ss = new Kisi_Ara();
            ss.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            IletisimGiris ss = new IletisimGiris();
            ss.Show();
        }
    }

      
    }
