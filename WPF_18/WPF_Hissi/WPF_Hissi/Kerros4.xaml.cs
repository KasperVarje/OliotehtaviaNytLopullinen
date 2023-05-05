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
    /// Interaction logic for Kerros4.xaml
    /// </summary>
    public partial class Kerros4 : Page
    {
        public Kerros4()
        {
            InitializeComponent();
            tbInputNel.Text = "";
            tbInputNel.MaxLength = 1;
        }


        private void tbvalidation2(object sender, TextCompositionEventArgs e)
        {
            Regex regex1 = new Regex("[^0-6]+");
            e.Handled = regex1.IsMatch(e.Text); 
        }

        private void NextKeros3(object sender, RoutedEventArgs e)
        {
            if (tbInputNel.Text == "3")
            {
                this.NavigationService.Navigate(new Kerros3());

            }
            if (tbInputNel.Text == "2")
            {
                this.NavigationService.Navigate(new Kerros2());

            }
            if (tbInputNel.Text == "1")
            {
                this.NavigationService.Navigate(new Kerros1());

            }
            if (tbInputNel.Text == "5")
            {
                this.NavigationService.Navigate(new Page5());

            }
        }
    }
}
