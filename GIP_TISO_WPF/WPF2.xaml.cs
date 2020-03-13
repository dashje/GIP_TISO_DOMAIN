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
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_WPF
{
    /// <summary>
    /// Interaction logic for WPF2.xaml
    /// </summary>
    public partial class WPF2 : Window
    {
        bool hasBeenClicked = false;
        private Controller _controller;
        public WPF2()
        {
            _controller = new Controller();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gebruiker gebr = new Gebruiker(txtNaam.Text, txtemail.Text, Convert.ToInt16(txtLeeftijd.Text),cbxGeslacht.SelectedItem.ToString(), txtPaswoord.Text);
            _controller.addGebruikersToDB(gebr);
            MessageBox.Show("Gebruiker is toegevoegd.");
        }

        private void TxtNaam_Focus(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
            hasBeenClicked = true;
        }
        private void txtPaswoord_Focus(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
            hasBeenClicked = true;
        }
        private void txtLeeftijd_Focus(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
            hasBeenClicked = true;
        }
        private void txtemail_Focus(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
            hasBeenClicked = true;
        }
    }
}
