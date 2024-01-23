using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.TabPages;
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
using UWPStation.VMSettingsPages.VMSettingsHardware;

namespace UWPStation.VMSettingsPages
{
    public sealed partial class Hardware : Page
    {
        public Hardware()
        {
            this.InitializeComponent();
        }
        private void HardwareNavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            switch (item.Name)
            {
                    case "Memory":
                        HardwareFrame.Navigate(typeof(Memory));
                        break;
                    case "Processors":
                        HardwareFrame.Navigate(typeof(Processors));
                        break;
                    case "HardDisk":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
                    case "CDDVD":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
                    case "NetworkAdapter":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
                    case "USBController":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
                    case "SoundCard":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
                    case "Display":
                        HardwareFrame.Navigate(typeof(NotAvailable));
                        break;
            }
        }
        private void HardwareNavView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Microsoft.UI.Xaml.Controls.NavigationViewItemBase item in HardwareNavView.MenuItems)
            {
                if (item is Microsoft.UI.Xaml.Controls.NavigationViewItem && item.Tag?.ToString() == "Memory")
                {
                    HardwareNavView.SelectedItem = item;
                    break;
                }
            }
            HardwareFrame.Navigate(typeof(Memory));
        }
    }
}
