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
        public MainWindow()
        {
            InitializeComponent();
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
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("pack://application:,,,/Images/felrobbant.jpg", UriKind.Absolute);
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
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("pack://application:,,,/Images/ep.jpg", UriKind.Absolute);
            bitmap.EndInit();

            imgReaktor.Source = bitmap;
        }

        private void btnGeneraltEnergia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHutovizBeengedese_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnKilepes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
