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
using UWPStation.TabPages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
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
            PreferencesDialog dialog = new PreferencesDialog();
            await dialog.ShowAsync();
        }
        private async void About_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            await dialog.ShowAsync();
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
        private async void CreateNewVM_Click(object sender, RoutedEventArgs e)
        {
            NewVMWizard dialog = new NewVMWizard();
            await dialog.ShowAsync();
        }
        private async void OpenVM_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            await OpenPageAsWindowAsync(typeof(MainPage));
        }
        private async void ConnectToRemoteServerButton_Click(object sender, RoutedEventArgs e)
        {
            ConnectToRemoteServer dialog = new ConnectToRemoteServer();
            await dialog.ShowAsync();
        }
        private async void ConnectToRemoteServer_Click(object sender, RoutedEventArgs e)
        {
            ConnectToRemoteServer dialog = new ConnectToRemoteServer();
            await dialog.ShowAsync();
        }
        private void HomeTab_Click(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(HomePage));
        }
        private void VMTab_Click(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(VMPage));
        }
        private void MyComputerTab_Click(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(MyComputerPage));
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(HomePage));
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsFrame.Margin = new Thickness(0, 69, 0, 0);
            this.MyComputerTab.Visibility = Visibility.Collapsed;
        }
        private void HideFolderView_Click(object sender, RoutedEventArgs e)
        {
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsFrame.Margin = new Thickness(0, 69, 0, 0);
        }
        private void ShowHideFolderView_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.FolderView.Visibility == Visibility.Visible)
            {
                this.FolderView.Visibility = Visibility.Collapsed;
                this.TabsFrame.Margin = new Thickness(0, 69, 0, 0);
            }
            else
            {
                this.FolderView.Visibility = Visibility.Visible;
                this.TabsFrame.Margin = new Thickness(0, 69, 0, 147);
            }
        }
        private void FolderViewOptions_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private void GoToHome_Click(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(HomePage));
        }
        private void UWPFamilyOS_Click(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(VMPage));
        }
        private async void VMSettings_Click(object sender, RoutedEventArgs e)
        {
            VMSettings dialog = new VMSettings();
            await dialog.ShowAsync();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private async void Changelog_Click(object sender, RoutedEventArgs e)
        {
            ChangelogDialog dialog = new ChangelogDialog();
            await dialog.ShowAsync();
        }
    }
}
