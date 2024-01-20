using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.PreferencesPages;
using UWPStation.VMSettingsPages;
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
    public sealed partial class PreferencesDialog : ContentDialog
    {
        public PreferencesDialog()
        {
            this.InitializeComponent();
        }
        private void NavigationView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            switch (item.Name)
            {
                case "Workspace":
                    PreferencesFrame.Navigate(typeof(WorkspacePage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Input":
                    PreferencesFrame.Navigate(typeof(InputPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "HotKeys":
                    PreferencesFrame.Navigate(typeof(HotKeysPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Display":
                    PreferencesFrame.Navigate(typeof(DisplayPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Unity":
                    PreferencesFrame.Navigate(typeof(UnityPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "USB":
                    PreferencesFrame.Navigate(typeof(USBPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Updates":
                    PreferencesFrame.Navigate(typeof(UpdatesPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Feedback":
                    PreferencesFrame.Navigate(typeof(FeedbackPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Memory":
                    PreferencesFrame.Navigate(typeof(MemoryPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Priority":
                    PreferencesFrame.Navigate(typeof(PriorityPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "Devices":
                    PreferencesFrame.Navigate(typeof(DevicesPage), null, new SuppressNavigationTransitionInfo());
                    break;
                case "AppLanguage":
                    PreferencesFrame.Navigate(typeof(LanguagePage), null, new SuppressNavigationTransitionInfo());
                    break;
            }
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            PreferencesFrame.Navigate(typeof(WorkspacePage), null, new SuppressNavigationTransitionInfo());
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
