using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.Dialogs;
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
    public sealed partial class MoreApps : ContentDialog
    {
        public MoreApps()
        {
            this.InitializeComponent();
        }
        private async void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            AboutDialog dialog = new AboutDialog();
            await dialog.ShowAsync();
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
