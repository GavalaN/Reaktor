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
using System.Media;

namespace AtomReaktor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool aktiv_e = false;

        static Random rnd = new Random();
        static int hom;
        static double aram;

        public int Hom { get => Hom; private set => rnd.Next(40, 101); }
        public double Aram { get => aram; set => aram = rnd.NextDouble() * (2.5 - 1) + 1; }

        public void HutovizBenged()
        {
            hom = 40;
            lbhofok.Content = $"Hőfok: {hom} °C";
        }

        public void GenealtEnergia()
        {
            aram += Math.Round(rnd.NextDouble() * (2.5 - 1) + 1,2);
            lbgeneraltenergia.Content = $"Generált Energia: {aram} GW";
        }

        public MainWindow()
        {
            InitializeComponent();
            btnLeallitas.IsEnabled = false;
            btnHutovizBeengedese.IsEnabled = false;
            btnGeneraltEnergia.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("pack://application:,,,/Images/ep.jpg", UriKind.Absolute);
            bitmap.EndInit();

            imgReaktor.Source = bitmap;
        }

        private void btnBeinditas_Click(object sender, RoutedEventArgs e)
        {
            btnBeinditas.IsEnabled = false;
            btnLeallitas.IsEnabled = true;
            btnHutovizBeengedese.IsEnabled = true;
            btnGeneraltEnergia.IsEnabled = true;
            aktiv_e = true;
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("pack://application:,,,/Images/ep.jpg", UriKind.Absolute);
            bitmap.EndInit();

            imgReaktor.Source = bitmap;

            try
            {
                Uri uri = new Uri(@"C:\Users\GavalaN\source\repos\GavalaN\Reaktor\dirrdurr.mp3");
                var player = new MediaPlayer();
                player.Open(uri);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba: {ex.Message}");
            }
        }

        private void btnLeallitas_Click(object sender, RoutedEventArgs e)
        {
            if (hom >= 70)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("pack://application:,,,/Images/felrobbant.jpg", UriKind.Absolute);
                bitmap.EndInit();

                imgReaktor.Source = bitmap;
            }
            else
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri("pack://application:,,,/Images/ep.jpg", UriKind.Absolute);
                bitmap.EndInit();

                imgReaktor.Source = bitmap;
            }
        }

        private void btnGeneraltEnergia_Click(object sender, RoutedEventArgs e)
        {
            if (aktiv_e)
            {
                GenealtEnergia();
            }
        }

        private void btnHutovizBeengedese_Click(object sender, RoutedEventArgs e)
        {
            if (aktiv_e)
            {
                HutovizBenged();
            }
        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
