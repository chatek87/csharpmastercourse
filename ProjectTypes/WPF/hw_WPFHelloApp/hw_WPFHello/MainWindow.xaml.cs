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

namespace hw_WPFHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var defaultMessage = $"Hello {firstNameBox.Text} {lastNameBox.Text}";
            /*if (firstNameBox.Text.ToLower().Contains("bub"))
            {
                MessageBox.Show($"Heyyyy BUBSIE BUBSIE!!!!", "Sweet Detected!!!!");
            }
            else
            {
                MessageBox.Show($"Hello {firstNameBox.Text} {lastNameBox.Text}");
            }*/

            displayBlock.Text = defaultMessage;
        }
    }
}
