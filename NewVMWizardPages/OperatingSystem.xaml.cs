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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation.NewVMWizardPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
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
