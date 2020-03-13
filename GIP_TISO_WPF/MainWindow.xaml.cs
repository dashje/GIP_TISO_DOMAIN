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
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Controller _controller;
        public MainWindow()
        {
            _controller = new Controller();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPF2 window2 = new WPF2();
            window2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gebruiker gebruiker = _controller.getLogin(txtnaam.Text, pwbPaswoord.Password);
            if (gebruiker != null)
            {
                WPF3 wpf2 = new WPF3();
                wpf2.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Verkeerde combinatie van ww/naam.");
            }
            
        }
    }
}
