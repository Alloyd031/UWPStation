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

namespace UWPStation.PreferencesDialogs
{
    public sealed partial class Unity : ContentDialog
    {
        public Unity()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PreferencesDialog dialog = new PreferencesDialog();
            await dialog.ShowAsync();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(UnityPage));
        }
    }
}
