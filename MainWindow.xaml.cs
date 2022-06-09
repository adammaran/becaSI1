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

namespace AutoProdavnicaNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void korisniciClick(object sender, RoutedEventArgs e)
        {
            Korisnici korisnici = new Korisnici();
            korisnici.Show();
        }

        private void MeniTrener_Click(object sender, RoutedEventArgs e)
        {
            Vozila vozilo = new Vozila();
            vozilo.Show();
        }

        private void MeniLiga_Click(object sender, RoutedEventArgs e)
        {
            Prodaja prodaja = new Prodaja();
            prodaja.Show();
        }

        private void MeniKlub_Click(object sender, RoutedEventArgs e)
        {
            Obrisano obrisano = new Obrisano();
            obrisano.Show();
        }

        private void MeniUtakmica_Click(object sender, RoutedEventArgs e)
        {
            Sacuvano sacuvano = new Sacuvano();
            sacuvano.Show();
        }
    }
}
