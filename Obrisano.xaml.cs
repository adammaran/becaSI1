using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace AutoProdavnicaNew
{
    /// <summary>
    /// Interaction logic for Obrisano.xaml
    /// </summary>
    public partial class Obrisano : Window
    {
        public Obrisano()
        {
            InitializeComponent();
        }

        private void prikaziVozila()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM obrisano, korisnik WHERE obrisano.prodavac_ID = korisnik.korisnik_id;";
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("obrisano");
            dataAdapter.Fill(dataTable);

            DataGridDeleted.ItemsSource = dataTable.DefaultView;
        }

        private void DataGridDeleted_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CbxKorisnik_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand commandCbX = new SqlCommand();
            commandCbX.CommandText = "SELECT * FROM korisnik ORDER BY korisnik_id";
            commandCbX.Connection = connection;
            SqlDataAdapter dataAdapterCbx = new SqlDataAdapter(commandCbX);
            DataTable dataTableCbx = new DataTable("korisnik");
            dataAdapterCbx.Fill(dataTableCbx);

            for (int i = 0; i < dataTableCbx.Rows.Count; i++)
            {
                cbsKorisnikId.Items.Add(dataTableCbx.Rows[i]["korisnicko_ime"]);
            }
        }

        private void ponistiUnosTxt()
        {

        }

        private void btnIzaberi_Click(object sender, RoutedEventArgs e)
        {
            prikaziVozila();
        }
    }
}
