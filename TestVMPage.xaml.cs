﻿using System;
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
using UWPStation.Dialogs;
using Windows.Foundation.Metadata;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestVMPage : Page
    {
        public TestVMPage()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        private void ExitTestVM_Click(object sender, RoutedEventArgs e)
        {
            if (Window.Current.Content is Frame rootFrame && rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void VMSettings_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void ActionCenter_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void ShowHelloWindow_Click(object sender, RoutedEventArgs e)
        {
            this.HelloWindow.Visibility = Visibility.Visible;
            this.HelloWindowIcon.Visibility = Visibility.Visible;
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.HelloWindow.Visibility = Visibility.Collapsed;
            this.HelloWindowIcon.Visibility = Visibility.Collapsed;
        }

        private void MinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.HelloWindow.Visibility = Visibility.Collapsed;
            this.HelloWindowIcon.Visibility = Visibility.Visible;
        }

        private void ShowWindow_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.HelloWindow.Visibility == Visibility.Visible)
            {
                this.HelloWindow.Visibility = Visibility.Collapsed;
            }
            else
            {
                this.HelloWindow.Visibility = Visibility.Visible;
            }
        }

        private async void MaximizeWindow_Click(object sender, RoutedEventArgs e)
        {
            MaximizeWindowDialog dialog = new MaximizeWindowDialog();
            await dialog.ShowAsync();
        }
    }
}
