using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.ChangeHardwareCompatibilityPages;
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

namespace UWPStation.Wizards
{
    public sealed partial class ChangeHardwareCompatibility : ContentDialog
    {
        public ChangeHardwareCompatibility()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.GoBack();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(Main));
        }
    }
}
