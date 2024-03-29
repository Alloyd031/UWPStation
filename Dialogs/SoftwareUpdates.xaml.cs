﻿using System;
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

namespace UWPStation.Dialogs
{
    public sealed partial class SoftwareUpdates : ContentDialog
    {
        public SoftwareUpdates()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void CheckForUpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            CheckForUpdatesProgress.IsIndeterminate = true;
            PendingUpdatesText.Text = "UWPStation is connecting to the update server...";
            if (this.CheckForUpdatesButton != null && this.CloseButton != null)
            {
                CheckForUpdatesButton.IsEnabled = false;
                CloseButton.IsEnabled = false;
            }           
            await Task.Delay(5000);
            CheckForUpdatesProgress.IsIndeterminate = false;
            PendingUpdatesText.Text = "There are no software updates available at this time.";
            if (this.CheckForUpdatesButton != null)
            {
                CheckForUpdatesButton.IsEnabled = true;
                CloseButton.IsEnabled = true;
            }
        }
    }
}
