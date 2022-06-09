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
    /// Interaction logic for Sacuvano.xaml
    /// </summary>
    public partial class Sacuvano : Window
    {
        public Sacuvano()
        {
            InitializeComponent();
            prikaziSacuvano();
        }

        private void prikaziSacuvano()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            if (cbsKorisnikId.Text == "")
            {
                command.CommandText = "SELECT * FROM sacuvano";
            }
            else
            {
                command.CommandText = "SELECT * FROM sacuvano WHERE korisnicko_ime = @korisnicko_ime";
                command.Parameters.AddWithValue("@korisnicko_ime", cbsKorisnikId.Text);
            }
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("sacuvano");
            dataAdapter.Fill(dataTable);

            DataGridSacuvano.ItemsSource = dataTable.DefaultView;
        }

        private void DataGridSacuvano_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                sacuvanoId = dr.Row["sacuvano_ID"].ToString();
            }
        }

        private String sacuvanoId;

        private void BtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM sacuvano WHERE sacuvano_ID = @id";
            command.Parameters.AddWithValue("@id", sacuvanoId);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o cuvanju su uspešno obrisani");
                prikaziSacuvano();
            }
            ponistiUnosTxt();
            loadCbx();
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

        private void loadCbx()
        {
            cbsKorisnikId.Items.Clear();
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
            prikaziSacuvano();
        }
    }
}
