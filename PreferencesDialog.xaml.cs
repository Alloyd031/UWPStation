using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.Pages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation
{
    public sealed partial class PreferencesDialog : ContentDialog
    {
        public PreferencesDialog()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(WorkspacePage));
        }
        private void WorkspaceButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(WorkspacePage));
        }
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(InputPage));
        }
        private void HotKeysButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(HotKeysPage));
        }
        private void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(DisplayPage));
        }
        private void UnityButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(UnityPage));
        }
        private void USBButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(USBPage));
        }
        private void UpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(UpdatesPage));
        }
        private void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(FeedbackPage));
        }
        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(MemoryPage));
        }
        private void PriorityButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(PriorityPage));
        }
        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(DevicesPage));
        }
    }
}
