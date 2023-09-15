using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPStation.VirtualMachineScreens;

namespace UWPStation
{
    public sealed partial class VMPage : Page
    {
        public VMPage()
        {
            this.InitializeComponent();
        }
        private async void WelcomeButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeInDialog dialog = new WelcomeInDialog();
            await dialog.ShowAsync();
        }
        private async void EditVMSettings_Click(object sender, RoutedEventArgs e)
        {
            VMSettings dialog = new VMSettings();
            await dialog.ShowAsync();
        }
        private void StartVM_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Starting));
        }
    }
}
