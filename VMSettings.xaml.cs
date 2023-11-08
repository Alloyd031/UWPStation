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
using UWPStation.VMSettingsPages;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI;

namespace UWPStation
{
    public sealed partial class VMSettings : Page
    {
        public VMSettings()
        {
            this.InitializeComponent();

            Window.Current.SetTitleBar(SettingsWindowTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Close();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Close();
        }
        private void HardwareTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (ContentFrame.CurrentSourcePageType != typeof(Hardware) && typeof(Hardware) != null)
            {
                ContentFrame.Navigate(typeof(Hardware), null, new SuppressNavigationTransitionInfo());
                HardwareTab.IsChecked = true;
                OptionsTab.IsChecked = false;
            }
        }
        private void HardwareTab_Click(object sender, RoutedEventArgs e)
        {
            HardwareTab.IsChecked = true;
            OptionsTab.IsChecked = false;
        }
        private void HardwareTab_Checked(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.CurrentSourcePageType != typeof(Hardware))
            {
                ContentFrame.Navigate(typeof(Hardware), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void OptionsTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (ContentFrame.CurrentSourcePageType != typeof(Options) && typeof(Options) != null)
            {
                ContentFrame.Navigate(typeof(Options), null, new SuppressNavigationTransitionInfo());
                HardwareTab.IsChecked = false;
                OptionsTab.IsChecked = true;
            }
        }
        private void OptionsTab_Click(object sender, RoutedEventArgs e)
        {
            HardwareTab.IsChecked = false;
            OptionsTab.IsChecked = true;
        }
        private void OptionsTab_Checked(object sender, RoutedEventArgs e)
        {
            if (ContentFrame.CurrentSourcePageType != typeof(Options))
            {
                ContentFrame.Navigate(typeof(Options), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Hardware), null, new SuppressNavigationTransitionInfo());

            HardwareTab.IsChecked = true;
            OptionsTab.IsChecked = false;
        }
    }
}
