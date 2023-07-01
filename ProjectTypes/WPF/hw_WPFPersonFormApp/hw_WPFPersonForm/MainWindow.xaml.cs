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
using DemoLibrary;

namespace hw_WPFPersonForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AddressModel> addresses = new List<AddressModel> ();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void addNewAddress_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
