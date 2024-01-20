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

namespace UWPStation.Dialogs
{
    public sealed partial class RestoreSnapshot : ContentDialog
    {
        public RestoreSnapshot()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
