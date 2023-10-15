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
            this.HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());

            MemoryButton.IsChecked = true;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = true;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void MemoryButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = true;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void MemoryButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void ProcessorsButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = true;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void ProcessorsButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = true;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void ProcessorsButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void HardDiskButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = true;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void HardDiskButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = true;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void HardDiskButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void CDDVDButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = true;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void CDDVDButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = true;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void CDDVDButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void NetworkAdapterButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = true;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void NetworkAdapterButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = true;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void NetworkAdapterButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void USBControllerButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = true;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = false;
        }
        private void USBControllerButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = true;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = false;
            }
        }
        private void USBControllerButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void SoundCardButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = true;
            DisplayButton.IsChecked = false;
        }
        private void SoundCardButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = true;
                DisplayButton.IsChecked = false;
            }
        }
        private void SoundCardButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            MemoryButton.IsChecked = false;
            ProcessorsButton.IsChecked = false;
            HardDiskButton.IsChecked = false;
            CDDVDButton.IsChecked = false;
            NetworkAdapterButton.IsChecked = false;
            USBControllerButton.IsChecked = false;
            SoundCardButton.IsChecked = false;
            DisplayButton.IsChecked = true;
        }
        private void DisplayButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                MemoryButton.IsChecked = false;
                ProcessorsButton.IsChecked = false;
                HardDiskButton.IsChecked = false;
                CDDVDButton.IsChecked = false;
                NetworkAdapterButton.IsChecked = false;
                USBControllerButton.IsChecked = false;
                SoundCardButton.IsChecked = false;
                DisplayButton.IsChecked = true;
            }
        }
        private void DisplayButton_Checked(object sender, RoutedEventArgs e)
        {
            if (HardwareFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
    }
}
