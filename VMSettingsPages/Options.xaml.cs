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
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void GeneralButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void SharedFolderButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void SnapshotsButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AutoProtectButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void GuestIsolationButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AccessControlButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void UWPToolsButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void VNCConnectionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void UnityButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void ApplianceViewButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AutologinButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AdvancedButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
    }
}
