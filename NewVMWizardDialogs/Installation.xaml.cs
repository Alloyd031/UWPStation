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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation.NewVMWizardDialogs
{
    public sealed partial class Installation : ContentDialog
    {
        public Installation()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Main dialog = new Main();
            await dialog.ShowAsync();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NextButtonTip.IsOpen = true;
        }
        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpButtonTip.IsOpen = true;
        }
    }
}
