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
    public sealed partial class TakeSnapshot : ContentDialog
    {
        public TakeSnapshot()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void TakeSnapshotButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
    }
}
