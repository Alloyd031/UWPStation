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
    public sealed partial class BootScreen : Page
    {
        public BootScreen()
        {
            this.InitializeComponent();
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BootRing.IsActive = false;
            await Task.Delay(1000);
            if (this.BootRing != null)
            {
                BootRing.IsActive = true;
            }

            await Task.Delay(5000);
            this.Frame.Navigate(typeof(Preparing));
        }
    }
}
