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
using Windows.Devices.Enumeration;
using UWPStation.PreferencesPages;
using UWPStation.Dialogs;
using UWPStation.Wizards;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading.Tasks;
using Windows.UI.Core;
using UWPStation.TabPages;
using Windows.UI.Xaml.Media.Animation;
using mux = Microsoft.UI.Xaml.Controls;
using Windows.Foundation.Metadata;
using Microsoft.UI.Xaml.Controls;

namespace UWPStation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.Transparent;
            titleBar.InactiveBackgroundColor = Colors.Transparent;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            ApplicationView.PreferredLaunchViewSize = new Size(1404, 916);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1173, 923));
        }
        public SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
            return myBrush;
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
            Preferences dialog = new Preferences();
            await dialog.ShowAsync();
        }
        private async void About_Click(object sender, RoutedEventArgs e)
        {
            AboutApp dialog = new AboutApp();
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
            MessageLog dialog = new MessageLog();
            await dialog.ShowAsync();
        }
        private async void LicenseKey_Click(object sender, RoutedEventArgs e)
        {
            EnterKey dialog = new EnterKey();
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
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private void HideLibrary_Click(object sender, RoutedEventArgs e)
        {
            this.LibraryPanel.Visibility = Visibility.Collapsed;
            this.Splitter.Visibility = Visibility.Collapsed;
            this.TabsGrid.Margin = new Thickness (0, 0, 0, 32);
            this.FolderView.Margin = new Thickness(0, 0, 0, 32);

            if (ShowHideLibrary.IsChecked == true)
            {
                ShowHideLibrary.IsChecked = false;
            }
        }
        private void ShowHideLibrary_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.LibraryPanel.Visibility == Visibility.Visible)
            {
                this.LibraryPanel.Visibility = Visibility.Collapsed;
                this.Splitter.Visibility = Visibility.Collapsed;
                this.TabsGrid.Margin = new Thickness(0, 0, 0, 32);
                this.FolderView.Margin = new Thickness(0, 0, 0, 32);
                ShowHideLibrary.IsChecked = false;
            }
            else
            {
                this.LibraryPanel.Visibility = Visibility.Visible;
                this.Splitter.Visibility = Visibility.Visible;
                this.TabsGrid.Margin = new Thickness(212, 0, 0, 32);
                this.FolderView.Margin = new Thickness(202, 0, 0, 32);
                ShowHideLibrary.IsChecked = true;
            }
        }
        private async void CreateVM_Click(object sender, RoutedEventArgs e)
        {
            NewVMWizard dialog = new NewVMWizard();
            await dialog.ShowAsync();
        }
        private async void SoftwareUpdates_Click(object sender, RoutedEventArgs e)
        {
            SoftwareUpdates dialog = new SoftwareUpdates();
            await dialog.ShowAsync();
        }
        private async void SnapshotManager_Click(object sender, RoutedEventArgs e)
        {
            SnapshotManager dialog = new SnapshotManager();
            await dialog.ShowAsync();
        }
        private async void TakeSnapshot_Click(object sender, RoutedEventArgs e)
        {
            TakeSnapshot dialog = new TakeSnapshot();
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
            NotAvailable dialog = new NotAvailable();
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
        private async void VirtualizePhysicalMachine_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ConnectToRemoteServer_Click(object sender, RoutedEventArgs e)
        {
            ConnectToRemoteServer dialog = new ConnectToRemoteServer();
            await dialog.ShowAsync();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsView.Margin = new Thickness(0, 0, 0, 0);

            if (ShowHideLibrary.IsChecked == false)
            {
                ShowHideLibrary.IsChecked = true;
            }
        }
        private void HideFolderView_Click(object sender, RoutedEventArgs e)
        {
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsView.Margin = new Thickness(0, 0, 0, 0);
            ShowHideFolderView.IsChecked = false;
        }
        private void ShowHideFolderView_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.FolderView.Visibility == Visibility.Visible)
            {
                this.FolderView.Visibility = Visibility.Collapsed;
                this.TabsView.Margin = new Thickness(0, 0, 0, 0);
                ShowHideFolderView.IsChecked = false;
            }
            else
            {
                this.FolderView.Visibility = Visibility.Visible;
                this.TabsView.Margin = new Thickness(0, 0, 0, 152);
                ShowHideFolderView.IsChecked = true;
            }
        }
        private void FolderViewOptions_Click(object sender, RoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
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
        private async void Open_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ConfigureAutoStartVMs_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void CloseTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ExportToOVF_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Cut_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Copy_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Paste_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void FullScreen_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Unity_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ConsoleView_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void FitGuestNow_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void FitWindowNow_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void StartUpGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ShutDownGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void SuspendGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void RestartGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void PowerOn_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void PowerOff_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Suspend_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Reset_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void PowerOnToFirmware_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Settings_Click(object sender, RoutedEventArgs e)
        {
            await OpenPageAsWindowAsync(typeof(VMSettings));
        }
        private async void Pause_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void SendCtrlAltDel_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void GrabInput_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void TakeVMSnapshot_Click(object sender, RoutedEventArgs e)
        {
            TakeSnapshot dialog = new TakeSnapshot();
            await dialog.ShowAsync();
        }

        private async void RevertToSnapshot_Click(object sender, RoutedEventArgs e)
        {
            RestoreSnapshot dialog = new RestoreSnapshot();
            await dialog.ShowAsync();
        }

        private async void VMSnapshotManager_Click(object sender, RoutedEventArgs e)
        {
            SnapshotManager dialog = new SnapshotManager();
            await dialog.ShowAsync();
        }
        private async void CaptureScreen_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ChangeHardwareCompatibility_Click(object sender, RoutedEventArgs e)
        {
            ChangeHardwareCompatibility dialog = new ChangeHardwareCompatibility();
            await dialog.ShowAsync();
        }
        private async void Clone_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Upload_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Download_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void CleanUpDisks_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void DeleteFromDisks_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void Permissions_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void VNCConnections_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void VMMessageLog_Click(object sender, RoutedEventArgs e)
        {
            MessageLog dialog = new MessageLog();
            await dialog.ShowAsync();
        }
        private async void InstallUWPTools_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void NextTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void PreviousTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void HelpTopics_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void OnlineDocumentation_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void OnlineCommunity_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://discord.gg/jDt9eCkaJc"));
        }
        private async void ProductSupportCenter_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void SubmitSupportRequest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void CollectSupportData_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void EnableAllHints_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void RegisterUWPStation_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private void VMTab_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private async void KeepAspectRatioStretch_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void FreeStretch_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
        private async void ClearMessages_Click(object sender, RoutedEventArgs e)
        {
            NotAvailable dialog = new NotAvailable();
            await dialog.ShowAsync();
        }
    }
}
