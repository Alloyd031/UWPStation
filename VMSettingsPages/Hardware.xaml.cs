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
using static System.Net.WebRequestMethods;

namespace UWPStation.VMSettingsPages
{
    public sealed partial class Hardware : Page
    {
        public Hardware()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
        }
        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            switch (item.Name)
            {
                case "Memory":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Processors":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "HardDisk":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "CDDVD":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "NetworkAdapter":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "USBController":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "SoundCard":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Display":
                    HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                    break;
            }
        }
    }
}
