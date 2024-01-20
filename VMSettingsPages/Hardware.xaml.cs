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
using Windows.UI.Xaml.Media.Animation;
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
            HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
        }
        private void HardwareNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            switch (args.SelectedItem)
            {
                case "General":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Power":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "SharedFolders":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Snapshots":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "NetworkAdapter":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "GuestIsolation":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "AccessControl":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "UWPTools":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "VNCConnections":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Unity":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "ApplianceView":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Autologin":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Advanced":
                    HardwareFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
            }
        }
    }
}
