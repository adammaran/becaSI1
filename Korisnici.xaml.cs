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
    /// Interaction logic for Korisnici.xaml
    /// </summary>
    public partial class Korisnici : Window
    {
        public Korisnici()
        {
            InitializeComponent();
            prikaziSveKorisnike();
        }

        private void prikaziSveKorisnike()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM korisnik";
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("korisnik");
            dataAdapter.Fill(dataTable);

            DataGridFudbaler.ItemsSource = dataTable.DefaultView;
        }

        private void DataGridFudbaler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtIme.Text = dr["korisnicko_ime"].ToString();
                txtPrezime.Text = dr["sifra"].ToString();
            }
        }

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO korisnik (korisnicko_ime, sifra) VALUES (@Ime, @sifra)";
            command.Parameters.AddWithValue("@Ime", txtIme.Text);
            command.Parameters.AddWithValue("@sifra", txtPrezime.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o korisniku su uspešno upisani");
            }
            prikaziSveKorisnike();
            ponistiUnosTxt();
            loadCbx();
        }

        private void BtnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE korisnik SET korisnicko_ime = @Ime, sifra = @sifra WHERE korisnicko_ime = @korisnik_ID";
            command.Parameters.AddWithValue("@Ime", txtIme.Text);
            command.Parameters.AddWithValue("@sifra", txtPrezime.Text);
            command.Parameters.AddWithValue("@korisnik_ID", cbsKorisnikId.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o korisniku su uspešno izmenjeni");
                prikaziSveKorisnike();
            }
            ponistiUnosTxt();
            loadCbx();
        }

        private void BtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Korisnik WHERE korisnicko_ime = @korisnik_ID";
            command.Parameters.AddWithValue("@korisnik_ID", cbsKorisnikId.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o korisniku su uspešno obrisani");
                prikaziSveKorisnike();
            }
            ponistiUnosTxt();
            loadCbx();
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
            txtIme.Text = "";
            txtPrezime.Text = "";
        }
    }
}
