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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
            tbInputVis.Text = "";
            tbInputVis.MaxLength = 1;
        }

        private void tbvalidation3(object sender, TextCompositionEventArgs e)
        {
            Regex regex1 = new Regex("[^0-6]+");
            e.Handled = regex1.IsMatch(e.Text);
        }

        private void NextKeros4(object sender, RoutedEventArgs e)
        {
            if (tbInputVis.Text == "1")
            {
                this.NavigationService.Navigate(new Kerros1());

            }
            if (tbInputVis.Text == "3")
            {
                this.NavigationService.Navigate(new Kerros3());

            }
            if (tbInputVis.Text == "4")
            {
                this.NavigationService.Navigate(new Kerros4());

            }
            if (tbInputVis.Text == "2")
            {
                this.NavigationService.Navigate(new Kerros2());

            }
        }
    }
}
