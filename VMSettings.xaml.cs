using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.VMSettingsPages;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Диалоговое окно содержимого" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation
{
    public sealed partial class VMSettings : ContentDialog
    {
        public VMSettings()
        {
            this.InitializeComponent();
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void HardwareTab_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(Hardware));
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(Hardware));
        }
        private void OptionsTab_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(Options));
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.GoBack();
        }
    }
}
