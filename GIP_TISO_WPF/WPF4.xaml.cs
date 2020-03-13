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
    /// Interaction logic for WPF4.xaml
    /// </summary>
    public partial class WPF4 : Window
    {
        private Controller _controller;
        public WPF4()
        {
            _controller = new Controller();
            //lbxCadeau.ItemsSource = _controller.getCadeausFromDB();
            InitializeComponent();
            fillControls();
        }

        private void fillControls()
        {
            lbxCadeau.ItemsSource = _controller.getCadeausFromDB();
            lbxCadeau.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string gekochtjaofnee = "";
            if (rbnJa.IsChecked == true)
            {
                gekochtjaofnee = "JA";
            }
            else if (rbnNee.IsChecked == true)
            {
                gekochtjaofnee = "NEE";
            }

            Cadeau cadeau = new Cadeau(txtnaam.Text, txtomschrijving.Text, txtwebsite.Text,gekochtjaofnee );
            _controller.addCadeausToDB(cadeau);
            fillControls();
        }

        private void TxtVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            _controller.deleteCadeauToDB(lbxCadeau.SelectedIndex);
            fillControls();
        }
    }
}
