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
using Windows.Devices.Enumeration;
using UWPStation.Pages;
using UWPStation.Dialogs;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading.Tasks;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string FullString => ApplicationName + SeparatorType + PlaceholderString;
        public string PlaceholderString => "PREVIEW";
        public string SeparatorType => " - ";
        public string ApplicationName => "UWPStation";
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private async Task<bool> OpenPageAsWindowAsync(Type t)
        {
            var view = CoreApplication.CreateNewView();
            int id = 0;

            await view.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var frame = new Frame();
                frame.Navigate(t, null);
                Window.Current.Content = frame;
                Window.Current.Activate();
                id = ApplicationView.GetForCurrentView().Id;
            });

            return await ApplicationViewSwitcher.TryShowAsStandaloneAsync(id);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }
        private async void Preferences_Click(object sender, RoutedEventArgs e)
        {
            await OpenPageAsWindowAsync(typeof(PreferencesPage));
        }
        private async void About_Click(object sender, RoutedEventArgs e)
        {
            await OpenPageAsWindowAsync(typeof(AboutPage));
        }
        private void Button_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private async void MessageLog_Click(object sender, RoutedEventArgs e)
        {
            MessageLogDialog dialog = new MessageLogDialog();
            await dialog.ShowAsync();
        }
        private async void LicenseKey_Click(object sender, RoutedEventArgs e)
        {
            EnterKeyDialog dialog = new EnterKeyDialog();
            await dialog.ShowAsync();
        }
        private void StartMenu_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void ActionCenter_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private async void VirtualNetEditor_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private void HideLibrary_Click(object sender, RoutedEventArgs e)
        {
            this.LibraryPanel.Visibility = Visibility.Collapsed;
            this.TabsGrid.Margin = new Thickness (0, 0, 0, 0);
        }
        private void ShowHideLibrary_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.LibraryPanel.Visibility == Visibility.Visible)
            {
                this.LibraryPanel.Visibility = Visibility.Collapsed;
                this.TabsGrid.Margin = new Thickness(0, 0, 0, 0);
            }
            else
            {
                this.LibraryPanel.Visibility = Visibility.Visible;
                this.TabsGrid.Margin = new Thickness(200, 0, 0, 0);
            }
        }
        private async void CreateVM_Click(object sender, RoutedEventArgs e)
        {
            NewVMWizard dialog = new NewVMWizard();
            await dialog.ShowAsync();
        }
        private async void GoToTestVM_Click(object sender, RoutedEventArgs e)
        {
            await OpenPageAsWindowAsync(typeof(TestVMPage));
        }
        private async void SoftwareUpdates_Click(object sender, RoutedEventArgs e)
        {
            SoftwareUpdatesDialog dialog = new SoftwareUpdatesDialog();
            await dialog.ShowAsync();
        }
        private async void SnapshotManager_Click(object sender, RoutedEventArgs e)
        {
            SnapshotManagerDialog dialog = new SnapshotManagerDialog();
            await dialog.ShowAsync();
        }
        private async void TakeSnapshot_Click(object sender, RoutedEventArgs e)
        {
            TakeSnapshotDialog dialog = new TakeSnapshotDialog();
            await dialog.ShowAsync();
        }

        private async void ScanForVMs_Click(object sender, RoutedEventArgs e)
        {
            ScanForVMs dialog = new ScanForVMs();
            await dialog.ShowAsync();
        }

        private async void RestoreSnapshot_Click(object sender, RoutedEventArgs e)
        {
            RestoreSnapshot dialog = new RestoreSnapshot();
            await dialog.ShowAsync();
        }
    }
}
