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

namespace Maghazin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        int kaka1; 
        internal int coins;
        
        public static int vor1;
        public static int vor2;
        public static int vor3;
        public static int vor4;

        Coins coni = new Coins();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTNAdmin_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (Parol.Text == "1234") 
                {
                    AdminWindow ad = new AdminWindow();
                    ad.Show();
                    Close();
                }
                else if (Parol.Text == null)
                {
                    MessageBox.Show("Введи хоть что-нибудь");
                }
                else
                {
                    MessageBox.Show("Неверный код");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }


        private void BTN1_Click(object sender, RoutedEventArgs e)
        {
            kaka1++;
            TXVvod.Text = kaka1.ToString();

        }

        private void BTN2_Click(object sender, RoutedEventArgs e)
        {
            kaka1 = kaka1 + 2;
            TXVvod.Text = kaka1.ToString();
            
        }

        private void BTN10_Click(object sender, RoutedEventArgs e)
        {
            kaka1 = kaka1 + 10;
            TXVvod.Text = kaka1.ToString();
           
        }

        private void BTN5_Click(object sender, RoutedEventArgs e)
        {
            kaka1 = kaka1 + 5;
            TXVvod.Text = kaka1.ToString();
            
        }
    }
}
