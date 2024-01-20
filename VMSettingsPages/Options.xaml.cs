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
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
        }
        private void OptionsNavView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            switch (args.SelectedItem)
            {
                case "General":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Power":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "SharedFolders":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Snapshots":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "NetworkAdapter":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "GuestIsolation":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "AccessControl":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "UWPTools":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "VNCConnections":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Unity":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "ApplianceView":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Autologin":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
                case "Advanced":
                    OptionsFrame.Navigate(typeof(NotAvailable), new SuppressNavigationTransitionInfo());
                    break;
            }
        }
    }
}