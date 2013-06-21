using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

// contains the PhoneApplicationService class
using Microsoft.Phone.Shell;

namespace TestPhoneAppServState
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // we get the content from "Input"
            // casting is needed as everything in the PAS.Current.State is stored as "object"
            tbOutput.Text = PhoneApplicationService.Current.State["Input"] as string;
        }

        private void tbxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            // we store the content of the textbox
            PhoneApplicationService.Current.State["Input"] = tbxInput.Text;
        }
    }
}