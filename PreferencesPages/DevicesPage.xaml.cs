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

namespace UWPStation.PreferencesPages
{
    public sealed partial class DevicesPage : Page
    {
        public DevicesPage()
        {
            this.InitializeComponent();
        }
        private void ChangeSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.EnablePrinters != null)
            {
                this.EnablePrinters.IsEnabled = true;
            }        
            if (this.ChangeSettingsButton != null)
            {
                this.ChangeSettingsButton.IsEnabled = false;
            }     
        }
    }
}
