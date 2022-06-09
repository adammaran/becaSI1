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
    /// Interaction logic for Prodaja.xaml
    /// </summary>
    public partial class Prodaja : Window
    {
        public Prodaja()
        {
            InitializeComponent();
            prikaziKorisnike();

        }

        private void modelcbx_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand commandCbX = new SqlCommand();
            commandCbX.CommandText = "SELECT * FROM Vozilo ORDER BY proizvod_ID";
            commandCbX.Connection = connection;
            SqlDataAdapter dataAdapterCbx = new SqlDataAdapter(commandCbX);
            DataTable dataTableCbx = new DataTable("Vozilo");
            dataAdapterCbx.Fill(dataTableCbx);

            for (int i = 0; i < dataTableCbx.Rows.Count; i++)
            {
                modelcbx.Items.Add(dataTableCbx.Rows[i]["model"]);
            }
        }

        private void DataGridFudbaler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void prikaziKorisnike()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM prodaja INNER JOIN Vozilo ON vozilo_ID = vozilo.proizvod_ID INNER JOIN korisnik ON prodaja.prodavac_ID = korisnik_ID";
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("prodaja");
            dataAdapter.Fill(dataTable);

            DataGridFudbaler.ItemsSource = dataTable.DefaultView;
        }

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO prodaja (prodavac_ID, kupac_ID, vozilo_ID) VALUES (@prodavac, @kupac, @vozilo)";
            command.Parameters.AddWithValue("@prodavac", getUserId(cbsProdavac.Text));
            command.Parameters.AddWithValue("@kupac", getUserId(cbsKupac.Text));
            command.Parameters.AddWithValue("@vozilo", getVehicleId());
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o transakciji su uspešno upisani");
                prikaziKorisnike();
            }
            loadCbx();
        }

        private int getVehicleId()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT proizvod_ID FROM Vozilo WHERE marka = @marka AND model = @model";
            command.Parameters.AddWithValue("@marka", markacbx.Text);
            command.Parameters.AddWithValue("@model", modelcbx.Text);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return (int)reader["proizvod_ID"];
                }
            }

            return 1;
        }

        private int getUserId(String korisnicko_ime)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT korisnik_ID FROM korisnik WHERE korisnicko_ime = @korisnicko_ime";
            command.Parameters.AddWithValue("@korisnicko_ime", korisnicko_ime);
            command.Connection = connection;

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return (int)reader["korisnik_ID"];
                }
            }

            return 1;
        }

        private void BtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM prodaja WHERE prodaja_ID = @prodaja_ID";
            command.Parameters.AddWithValue("@prodaja_ID", getProdajaID());
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o transakciji su uspešno obrisani");
                prikaziKorisnike();
            } else
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja");
            }
            loadCbx();
        }

        private int getProdajaID()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT prodaja_ID FROM prodaja WHERE vozilo_ID = @vozilo_ID AND kupac_ID = @kupac_ID AND prodavac_ID = @prodavac_ID";
            command.Parameters.AddWithValue("@vozilo_ID", getVehicleId());
            command.Parameters.AddWithValue("@kupac_ID", getUserId(cbsKupac.Text));
            command.Parameters.AddWithValue("@prodavac_ID", getUserId(cbsProdavac.Text));
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return (int)reader["prodaja_ID"];
                }
            }

            return 1;
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
                cbsProdavac.Items.Add(dataTableCbx.Rows[i]["korisnicko_ime"]);
            }
        }

        private void CbxKupac_Loaded(object sender, RoutedEventArgs e)
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
                cbsKupac.Items.Add(dataTableCbx.Rows[i]["korisnicko_ime"]);
            }
        }

        private void loadCbx()
        {
            cbsProdavac.Items.Clear();
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
                cbsProdavac.Items.Add(dataTableCbx.Rows[i]["korisnicko_ime"]);
            }
        }


        private void markacbx_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand commandCbX = new SqlCommand();
            commandCbX.CommandText = "SELECT * FROM Vozilo ORDER BY proizvod_ID";
            commandCbX.Connection = connection;
            SqlDataAdapter dataAdapterCbx = new SqlDataAdapter(commandCbX);
            DataTable dataTableCbx = new DataTable("prodaja");
            dataAdapterCbx.Fill(dataTableCbx);

            for (int i = 0; i < dataTableCbx.Rows.Count; i++)
            {
                markacbx.Items.Add(dataTableCbx.Rows[i]["marka"]);
            }
        }
    }
}
