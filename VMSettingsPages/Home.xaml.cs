using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPStation;

namespace UWPStation.VMSettingsPages
{
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }
        private void HardwareButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Hardware));     
        }
        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Options));
        }
    }
}
