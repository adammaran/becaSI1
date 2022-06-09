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
    /// Interaction logic for Vozila.xaml
    /// </summary>
    public partial class Vozila : Window
    {
        public Vozila()
        {
            InitializeComponent();
            prikaziVozial();
        }

        private void prikaziVozial()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Vozilo, Korisnik WHERE Vozilo.prodavac_ID = Korisnik.korisnik_id";
            //command.Parameters.AddWithValue("@korisnicko_ime", cbsKorisnikId.Text);
            command.Connection = connection;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable("Vozila");
            dataAdapter.Fill(dataTable);

            DataGridVozila.ItemsSource = dataTable.DefaultView;
        }

        private void DataGridVozila_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txtMarka.Text = dr["marka"].ToString();
                txtCena.Text = dr["cena"].ToString();
                txtModel.Text = dr["model"].ToString();
                txtGodiste.Text = dr["godiste"].ToString();
                txtKilometraza.Text = dr["kilometraza"].ToString();
                cbsProdavac.Text = dr["korisnicko_ime"].ToString();
            }
        }

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Vozilo (marka, cena, model, godiste, kilometraza, prodavac_ID) VALUES (@Marka, @Cena, @Model, @Godiste, @Kilometraza, @prodavac_ID)";
            command.Parameters.AddWithValue("@Marka", txtMarka.Text);
            command.Parameters.AddWithValue("@Cena", txtCena.Text);
            command.Parameters.AddWithValue("@Model", txtModel.Text);
            command.Parameters.AddWithValue("@Godiste", txtGodiste.Text);
            command.Parameters.AddWithValue("@Kilometraza", txtKilometraza.Text);
            command.Parameters.AddWithValue("@prodavac_ID", getUserId(cbsProdavac.Text));
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o Vozilu su uspešno upisani");
                prikaziVozial();
            }
            ponistiUnosTxt();
            loadCbx();
        }

        private void BtnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Vozilo SET Marka = @marka, cena = @cena, model = @model, godiste = @godiste, kilometraza = @kilometraza, prodavac_ID = @prodavac_ID WHERE model = @model";
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@cena", txtCena.Text);
            command.Parameters.AddWithValue("@model", txtModel.Text);
            command.Parameters.AddWithValue("@godiste", txtGodiste.Text);
            command.Parameters.AddWithValue("@kilometraza", txtKilometraza.Text);
            command.Parameters.AddWithValue("@prodavac_ID", cbsProdavac.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o Vozilu su uspešno izmenjeni");
                prikaziVozial();
            }
            ponistiUnosTxt();
            loadCbx();
        }


        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO sacuvano (marka, cena, model, godiste, kilometraza, korisnicko_ime) VALUES (@Marka, @Cena, @Model, @Godiste, @Kilometraza, @prodavac_ID)";
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@cena", txtCena.Text);
            command.Parameters.AddWithValue("@model", txtModel.Text);
            command.Parameters.AddWithValue("@godiste", txtGodiste.Text);
            command.Parameters.AddWithValue("@kilometraza", txtKilometraza.Text);
            command.Parameters.AddWithValue("@prodavac_ID", cbsProdavac.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o Vozilu su uspešno sacuvani");
                prikaziVozial();
            }
            ponistiUnosTxt();
            loadCbx();
        }

        private void BtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            addToObrisi();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Vozilo WHERE marka = @marka AND model = @model";
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@model", txtModel.Text);
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o Vozilu su uspešno obrisani");
                prikaziVozial();
            }
            ponistiUnosTxt();
            loadCbx();
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

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return (int)reader["korisnik_ID"];
                }
            }

            return 1;
        }

        private void addToObrisi()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO obrisano (marka, cena, model, godiste, kilometraza, prodavac_ID) VALUES (@Marka, @Cena, @Model, @Godiste, @Kilometraza, @prodavac_ID)";
            command.Parameters.AddWithValue("@marka", txtMarka.Text);
            command.Parameters.AddWithValue("@cena", txtCena.Text);
            command.Parameters.AddWithValue("@model", txtModel.Text);
            command.Parameters.AddWithValue("@godiste", txtGodiste.Text);
            command.Parameters.AddWithValue("@kilometraza", txtKilometraza.Text);
            command.Parameters.AddWithValue("@prodavac_ID", getUserId(cbsProdavac.Text));
            command.Connection = connection;
            int provera = command.ExecuteNonQuery();
            if (provera == 1)
            {
                MessageBox.Show("Podaci o Vozilu su uspešno obrisani");
                prikaziVozial();
            }
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

        private void CbxProdavac_Loaded(object sender, RoutedEventArgs e)
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
            txtMarka.Text = "";
            txtCena.Text = "";
            txtModel.Text = "";
            txtGodiste.Text = "";
            txtKilometraza.Text = "";
            cbsProdavac.Text = "";
        }

        private void btnIzaberi_Click(object sender, RoutedEventArgs e)
        {
            prikaziVozial();
        }
    }
}
