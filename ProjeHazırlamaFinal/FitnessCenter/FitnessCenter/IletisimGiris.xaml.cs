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
    /// IletisimGiris.xaml etkileşim mantığı
    /// </summary>
    public partial class IletisimGiris : Window
    {
        public IletisimGiris()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True";
       
      

        private void DEVAM1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
           DigerGiris ss = new DigerGiris();
            ss.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into Tbl_Iletisim (ID1,TelNo,Email) values ('" + ID_txt1.Text.ToString() + "','" + TelNo_txt.Text.ToString() + "', '" + Email_txt.Text.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!");
            }
        }

        private void I_Geri_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            KullanıcıGiris ss = new KullanıcıGiris();
            ss.Show();
        }
    }
}
