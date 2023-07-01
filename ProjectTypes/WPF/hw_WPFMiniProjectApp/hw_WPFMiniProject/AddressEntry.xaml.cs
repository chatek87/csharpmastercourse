﻿using DemoLibrary;
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

namespace hw_WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _parent;

        //the ui is looking good. now wire it up!
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void saveAddress_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
