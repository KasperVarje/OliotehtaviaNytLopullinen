using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPF_testi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int hauto = 0;
        private int kauto = 0;
        public MainWindow()
        {
            InitializeComponent();

            hAutoCount.Text = hauto.ToString();
            kAutoCount.Text = kauto.ToString();
        }


        private void kAutoClick(object sender, RoutedEventArgs e)
        {
            kauto++;
            kAutoCount.Text = kauto.ToString();

        }

        private void hAutoClick(object sender, RoutedEventArgs e)
        {
            hauto++;
            hAutoCount.Text = hauto.ToString();
        }
    }
}
