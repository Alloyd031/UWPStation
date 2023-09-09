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

namespace UWPStation.PreferencesPages
{
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }
        private void WorkspaceButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WorkspacePage));
        }
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InputPage));
        }
        private void HotKeysButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HotKeysPage));
        }
        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DisplayPage));
        }
        private void UnityButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnityPage));
        }
        private void USBButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(USBPage));
        }
        private void UpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UpdatesPage));
        }
        private void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FeedbackPage));
        }
        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MemoryPage));
        }
        private void PriorityButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PriorityPage));
        }
        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DevicesPage));
        }
    }
}
