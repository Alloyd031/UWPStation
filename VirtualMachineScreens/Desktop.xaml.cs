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

namespace UWPStation.VirtualMachineScreens
{
    public sealed partial class Desktop : Page
    {
        public Desktop()
        {
            this.InitializeComponent();
        }
        private async void WelcomeButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeInDialog dialog = new WelcomeInDialog();
            await dialog.ShowAsync();
        }
    }
}
