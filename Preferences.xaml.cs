using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.PreferencesPages;
using UWPStation.VMSettingsPages;
using UWPStation.VMSettingsPages.VMSettingsHardware;
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

namespace UWPStation
{
    public sealed partial class Preferences : ContentDialog
    {
        public Preferences()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            switch (item.Name)
            {
                case "Workspace":
                    PreferencesFrame.Navigate(typeof(WorkspacePage));
                    break;
                case "Input":
                    PreferencesFrame.Navigate(typeof(InputPage));
                    break;
                case "HotKeys":
                    PreferencesFrame.Navigate(typeof(HotKeysPage));
                    break;
                case "Display":
                    PreferencesFrame.Navigate(typeof(DisplayPage));
                    break;
                case "Unity":
                    PreferencesFrame.Navigate(typeof(UnityPage));
                    break;
                case "USB":
                    PreferencesFrame.Navigate(typeof(USBPage));
                    break;
                case "Updates":
                    PreferencesFrame.Navigate(typeof(UpdatesPage));
                    break;
                case "Feedback":
                    PreferencesFrame.Navigate(typeof(FeedbackPage));
                    break;
                case "Memory":
                    PreferencesFrame.Navigate(typeof(MemoryPage));
                    break;
                case "Priority":
                    PreferencesFrame.Navigate(typeof(PriorityPage));
                    break;
                case "Devices":
                    PreferencesFrame.Navigate(typeof(DevicesPage));
                    break;
                case "AppLanguage":
                    PreferencesFrame.Navigate(typeof(LanguagePage));
                    break;
            }
        }
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Microsoft.UI.Xaml.Controls.NavigationViewItemBase item in PreferencesNavView.MenuItems)
            {
                if (item is Microsoft.UI.Xaml.Controls.NavigationViewItem && item.Tag?.ToString() == "Workspace")
                {
                    PreferencesNavView.SelectedItem = item;
                    break;
                }
            }
            PreferencesFrame.Navigate(typeof(WorkspacePage));
        }
    }
}
