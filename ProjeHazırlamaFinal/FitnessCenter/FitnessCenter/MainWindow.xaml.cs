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
using System.Data;
namespace FitnessCenter
{
    /// <summary>
    /// Giris.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FitnessCenter;Integrated Security=True";

        private void Giris_Click(object sender, RoutedEventArgs e)
        {
            string ID = ID_txt.Text;
            string Sifre = Sifre_txt.Text;
            connection1 baglanti = new connection1();
            baglanti.GirisYap(ID, Sifre);
            this.Hide();
            
        }
    }
}