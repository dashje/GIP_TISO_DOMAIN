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

namespace GIP_TISO_WPF
{
    /// <summary>
    /// Interaction logic for WPF3.xaml
    /// </summary>
    public partial class WPF3 : Window
    {
        public WPF3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPF4 wpf4 = new WPF4();
            wpf4.Show();
            this.Close();
        }
    }
}
