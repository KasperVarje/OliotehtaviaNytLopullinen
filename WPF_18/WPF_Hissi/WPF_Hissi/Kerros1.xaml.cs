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
    /// Interaction logic for Kerros1.xaml
    /// </summary>
    public partial class Kerros1 : Page
    {
        public Kerros1()
        {
            InitializeComponent();
            tbNumberField.Text = "";
            tbNumberField.MaxLength = 1;
        }

        private void validationinput(object sender, TextCompositionEventArgs e)
        {
                Regex regex1 = new Regex("[^0-6]+");
                e.Handled = regex1.IsMatch(e.Text);
            
        }

        private void NextKerros1(object sender, RoutedEventArgs e)
        {
            if (tbNumberField.Text == "2")
            {
                this.NavigationService.Navigate(new Kerros2());

            }
            if (tbNumberField.Text == "3")
            {
                this.NavigationService.Navigate(new Kerros3());

            }
            if (tbNumberField.Text == "4")
            {
                this.NavigationService.Navigate(new Kerros4());

            }
            if (tbNumberField.Text == "5")
            {
                this.NavigationService.Navigate(new Page5());

            }
        }
    }
}
