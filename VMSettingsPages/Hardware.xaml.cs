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

namespace UWPStation.VMSettingsPages
{
    public sealed partial class Hardware : Page
    {
        public Hardware()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void ProcessorsButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void HardDiskButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void CDDVDButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void NetworkAdapterButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void USBControllerButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void SoundCardButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable));
        }
    }
}
