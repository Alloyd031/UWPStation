using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UWPStation.VirtualMachineScreens
{
    public sealed partial class BIOSBoot : Page
    {
        public BIOSBoot()
        {
            this.InitializeComponent();
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BootLogo.Visibility = Visibility.Collapsed;

            await Task.Delay(800);
            if (this.BootLogo  != null)
            {
                BootLogo.Visibility = Visibility.Visible;
            }
            await Task.Delay(2000);
            this.BootProgress.Value = 50;

            await Task.Delay(2000);
            this.BootProgress.Value = 100;

            if (BootProgress.Value == 100)
            {          
                await Task.Delay(1000);
                this.Frame.Navigate(typeof(BootScreen));
            }
        }
    }
}
