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
using System.Configuration;
using System.Windows.Navigation;

namespace FitnessCenter
{
    /// <summary>
    /// Kisi_Ara.xaml etkileşim mantığı
    /// </summary>
    public partial class Kisi_Ara : Window
    {
        
        public Kisi_Ara()
        {
            
            InitializeComponent();
            FillDataGrid();
        }
        

        private void FillDataGrid()

        {

            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            string CmdString = string.Empty;

            using (SqlConnection con = new SqlConnection(ConString))

            {

                CmdString = "SELECT * FROM Tbl_KisiselBilgiler INNER JOIN Tbl_Iletisim ON Tbl_KisiselBilgiler.ID = Tbl_Iletisim.ID1 INNER JOIN DigerBilgiler ON Tbl_Iletisim.ID1 = DigerBilgiler.ID2";

                SqlCommand cmd = new SqlCommand(CmdString, con);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("tbl_Iletisim");

                sda.Fill(dt);

                grdEmployee.ItemsSource = dt.DefaultView;

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DigerGiris ss = new DigerGiris();
            ss.Show();
        }
        
        
    }
}
