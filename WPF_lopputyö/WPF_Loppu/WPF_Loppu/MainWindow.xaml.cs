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

namespace WPF_Loppu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bool cbox = 
        }

        private void lisää_koriin(object sender, RoutedEventArgs e)
        {
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = (string)Eka.Content;
            Paneli.Children.Add(printTextBlock);
            
        }

        private void lisää_koriin2(object sender, RoutedEventArgs e)
        {
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = (string)Toka.Content;
            Paneli.Children.Add(printTextBlock);
        }

        private void lisää_koriin3(object sender, RoutedEventArgs e)
        {
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = (string)Kolmas.Content;
            Paneli.Children.Add(printTextBlock);
        }

        private void lisää_koriin4(object sender, RoutedEventArgs e)
        {
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = (string)Neljäs.Content;
            Paneli.Children.Add(printTextBlock);
        }

        private void lisää_koriin5(object sender, RoutedEventArgs e)
        {
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = (string)Viides.Content;
            Paneli.Children.Add(printTextBlock);

        }
    }
}
