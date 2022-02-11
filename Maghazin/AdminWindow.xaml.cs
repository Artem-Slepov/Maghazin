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
using System.Diagnostics;
using System.Windows.Navigation;

namespace Maghazin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        public AdminWindow()
        {
            InitializeComponent();
        }

        private void BTNNazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mm = new MainWindow();
            mm.Show();
            Close();
        }
       
        private void BTNMonetki_Click(object sender, RoutedEventArgs e)
        {
            MoyaRamka.Navigate(new Coins());
             
        }

        private void BTNVoda_Click(object sender, RoutedEventArgs e)
        {
            MoyaRamka.Navigate(new Drinks());
        }

        private void BTNOtchet_Click(object sender, RoutedEventArgs e)
        {
            MoyaRamka.Navigate(new Otchet());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mm = new MainWindow();
            mm.Show();
            Close();
        }
    }
}
