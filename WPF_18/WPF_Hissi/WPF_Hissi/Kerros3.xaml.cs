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
    /// Interaction logic for Kerros3.xaml
    /// </summary>
    public partial class Kerros3 : Page
    {
        public Kerros3()
        {
            InitializeComponent();
            tbInputKol.Text = "";
            tbInputKol.MaxLength = 1;
        }

        private void NextKeros2(object sender, RoutedEventArgs e)
        {
            if (tbInputKol.Text == "4")
            {
                this.NavigationService.Navigate(new Kerros4());

            }
            if (tbInputKol.Text == "2")
            {
                this.NavigationService.Navigate(new Kerros2());

            }
            if (tbInputKol.Text == "1")
            {
                this.NavigationService.Navigate(new Kerros1());

            }
            if (tbInputKol.Text == "5")
            {
                this.NavigationService.Navigate(new Page5());

            }
        }

        private void tbvalidation1(object sender, TextCompositionEventArgs e)
        {
            Regex regex1 = new Regex("[^0-6]+");
            e.Handled = regex1.IsMatch(e.Text);
        }
    }
}
