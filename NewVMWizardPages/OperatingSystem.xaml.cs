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

namespace UWPStation.NewVMWizardPages
{
    public sealed partial class OperatingSystem : Page
    {
        public OperatingSystem()
        {
            this.InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (this.OSSelectionBox != null && this.WindowsOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = false;
            }
            if (this.OSSelectionBox != null && this.LinuxOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = false;
            }
            if (this.OSSelectionBox != null && this.OtherOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = true;
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.OtherOS.IsChecked == true)
            {
                this.Frame.Navigate(typeof(NameVirtualMachine));
            }           
        }
    }
}
