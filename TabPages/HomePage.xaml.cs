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
using UWPStation.Wizards;

namespace UWPStation.TabPages
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }
        private async void CreateVM_Click(object sender, RoutedEventArgs e)
        {
            NewVMWizard dialog = new NewVMWizard();
            await dialog.ShowAsync();
        }
        private async void ConnectToRemoteServerButton_Click(object sender, RoutedEventArgs e)
        {
            ConnectToRemoteServer dialog = new ConnectToRemoteServer();
            await dialog.ShowAsync();
        }
        private async void OpenVM_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ConnectToUWPFamilyvCloudAir_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
    }
}
