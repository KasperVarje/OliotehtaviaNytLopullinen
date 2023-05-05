using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_Hissi
{
    /// <summary>
    /// Interaction logic for Kerros2.xaml
    /// </summary>
    public partial class Kerros2 : Page
    {
        public Kerros2()
        {
            InitializeComponent();
            tbInputKaks.Text = "";
            tbInputKaks.MaxLength = 1;

        }

        private void tbvalidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex1 = new Regex("[^0-6]+");
            e.Handled = regex1.IsMatch(e.Text);
        }

        private void NextKeros(object sender, RoutedEventArgs e)
        {
            if (tbInputKaks.Text == "1")
            {
                this.NavigationService.Navigate(new Kerros1());

            }
            if (tbInputKaks.Text == "3")
            {
                this.NavigationService.Navigate(new Kerros3());

            }
            if (tbInputKaks.Text == "4")
            {
                this.NavigationService.Navigate(new Kerros4());

            }
            if (tbInputKaks.Text == "5")
            {
                this.NavigationService.Navigate(new Page5());

            }
        }

    }
}
