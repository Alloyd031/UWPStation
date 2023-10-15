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
using UWPStation.PreferencesPages;
using UWPStation.Dialogs;
using UWPStation.Wizards;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading.Tasks;
using Windows.UI.Core;
using UWPStation.TabPages;
using UWPStation.Something;
using Windows.UI.Xaml.Media.Animation;

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
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
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
        private void CoreTitleBar_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            RightPaddingColumn.Width = new GridLength(coreTitleBar.SystemOverlayRightInset);
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
            this.TabsGrid.Margin = new Thickness (0, 88, 0, 0);
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
                this.TabsGrid.Margin = new Thickness(0, 88, 0, 32);
                this.FolderView.Margin = new Thickness(0, 0, 0, 32);
                ShowHideLibrary.IsChecked = false;
            }
            else
            {
                this.LibraryPanel.Visibility = Visibility.Visible;
                this.TabsGrid.Margin = new Thickness(200, 88, 0, 32);
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
        private async void VirtualizePhysicalMachine_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ConnectToRemoteServer_Click(object sender, RoutedEventArgs e)
        {
            ConnectToRemoteServer dialog = new ConnectToRemoteServer();
            await dialog.ShowAsync();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.TabsFrame.Navigate(typeof(HomePage));
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsFrame.Margin = new Thickness(0, 31, 0, 0);

            if (ShowHideLibrary.IsChecked == false)
            {
                ShowHideLibrary.IsChecked = true;
            }

            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = true;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void HideFolderView_Click(object sender, RoutedEventArgs e)
        {
            this.FolderView.Visibility = Visibility.Collapsed;
            this.TabsFrame.Margin = new Thickness(0, 31, 0, 0);
            ShowHideFolderView.IsChecked = false;
        }
        private void ShowHideFolderView_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.FolderView.Visibility == Visibility.Visible)
            {
                this.FolderView.Visibility = Visibility.Collapsed;
                this.TabsFrame.Margin = new Thickness(0, 31, 0, 0);
                ShowHideFolderView.IsChecked = false;
            }
            else
            {
                this.FolderView.Visibility = Visibility.Visible;
                this.TabsFrame.Margin = new Thickness(0, 31, 0, 152);
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
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ConfigureAutoStartVMs_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void CloseTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ExportToOVF_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Cut_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Copy_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Paste_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void FullScreen_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Unity_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ConsoleView_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void FitGuestNow_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void FitWindowNow_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void StartUpGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ShutDownGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void SuspendGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void RestartGuest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void PowerOn_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void PowerOff_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Suspend_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Reset_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void PowerOnToFirmware_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Settings_Click(object sender, RoutedEventArgs e)
        {
            VMSettings dialog = new VMSettings();
            await dialog.ShowAsync();
        }
        private async void Pause_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void SendCtrlAltDel_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void GrabInput_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void TakeVMSnapshot_Click(object sender, RoutedEventArgs e)
        {
            TakeSnapshotDialog dialog = new TakeSnapshotDialog();
            await dialog.ShowAsync();
        }

        private async void RevertToSnapshot_Click(object sender, RoutedEventArgs e)
        {
            RestoreSnapshot dialog = new RestoreSnapshot();
            await dialog.ShowAsync();
        }

        private async void VMSnapshotManager_Click(object sender, RoutedEventArgs e)
        {
            SnapshotManagerDialog dialog = new SnapshotManagerDialog();
            await dialog.ShowAsync();
        }
        private async void CaptureScreen_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ChangeHardwareCompatibility_Click(object sender, RoutedEventArgs e)
        {
            ChangeHardwareCompatibility dialog = new ChangeHardwareCompatibility();
            await dialog.ShowAsync();
        }
        private async void Clone_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Upload_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Download_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void CleanUpDisks_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void DeleteFromDisks_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Permissions_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void VNCConnections_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void VMMessageLog_Click(object sender, RoutedEventArgs e)
        {
            MessageLogDialog dialog = new MessageLogDialog();
            await dialog.ShowAsync();
        }
        private async void InstallUWPTools_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void NextTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void PreviousTab_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void HelpTopics_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void OnlineDocumentation_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void OnlineCommunity_Click(object sender, RoutedEventArgs e)
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("https://discord.gg/jDt9eCkaJc"));
        }
        private async void ProductSupportCenter_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void SubmitSupportRequest_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void CollectSupportData_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void EnableAllHints_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void RegisterUWPStation_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private void VMTab_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
        private async void KeepAspectRatioStretch_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void FreeStretch_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void Important_Click(object sender, RoutedEventArgs e)
        {
            Important dialog = new Important();
            await dialog.ShowAsync();
        }
        private async void EasterEgg_Click(object sender, RoutedEventArgs e)
        {
            EasterEgg dialog = new EasterEgg();
            await dialog.ShowAsync();
        }
        private async void ClearMessages_Click(object sender, RoutedEventArgs e)
        {
            NotAvailableDialog dialog = new NotAvailableDialog();
            await dialog.ShowAsync();
        }
        private async void ChangelogItem_Click(object sender, RoutedEventArgs e)
        {
            Changelog dialog = new Changelog();
            await dialog.ShowAsync();
        }
        private void MyComputer_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;           

            if (TabsFrame.CurrentSourcePageType != typeof(MyComputerPage) && typeof(MyComputerPage) != null)
            {
                TabsFrame.Navigate(typeof(MyComputerPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = true;
                MyComputer.IsChecked = true;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = false;
            }
        }
        private void MyComputer_Click(object sender, RoutedEventArgs e)
        {
            MyComputer.IsChecked = true;
            MyComputerTab.IsChecked = true;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void MyComputerTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(MyComputerPage) && typeof(MyComputerPage) != null)
            {
                TabsFrame.Navigate(typeof(MyComputerPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = true;
                MyComputer.IsChecked = true;
                UWPFamilyOS.IsChecked = false;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = false;
            }
        }
        private void MyComputerTab_Click(object sender, RoutedEventArgs e)
        {
            MyComputer.IsChecked = true;
            MyComputerTab.IsChecked = true;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void UWPFamilyOS_Click(object sender, RoutedEventArgs e)
        {
            MyComputer.IsChecked = false;
            MyComputerTab.IsChecked = false;
            UWPFamilyOS.IsChecked = true;
            VMTab.IsChecked = true;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }

        private void UWPFamilyOS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(VMPage) && typeof(VMPage) != null)
            {
                TabsFrame.Navigate(typeof(VMPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = true;
                VMTab.IsChecked = true;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = false;
            }
        }
        private void VMTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(VMPage) && typeof(VMPage) != null)
            {
                TabsFrame.Navigate(typeof(VMPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = true;
                VMTab.IsChecked = true;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = false;
            }
        }
        private void VMTab_Click(object sender, RoutedEventArgs e)
        {
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = true;
            VMTab.IsChecked = true;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void HomeTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(HomePage) && typeof(HomePage) != null)
            {
                TabsFrame.Navigate(typeof(HomePage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = false;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = true;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = false;
            }
        }
        private void HomeTab_Click(object sender, RoutedEventArgs e)
        {
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = true;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void SharedVMsTab_Click(object sender, RoutedEventArgs e)
        {
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = true;
            SharedVMs.IsChecked = true;
            TestPageTab.IsChecked = false;
        }
        private void SharedVMsTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(SharedVMsPage) && typeof(SharedVMsPage) != null)
            {
                TabsFrame.Navigate(typeof(SharedVMsPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = false;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = true;
                SharedVMs.IsChecked = true;
                TestPageTab.IsChecked = false;
            }
        }
        private void SharedVMs_Click(object sender, RoutedEventArgs e)
        {
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = true;
            SharedVMs.IsChecked = true;
            TestPageTab.IsChecked = false;
        }
        private void SharedVMs_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(SharedVMsPage) && typeof(SharedVMsPage) != null)
            {
                TabsFrame.Navigate(typeof(SharedVMsPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = false;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = true;
                SharedVMs.IsChecked = true;
                TestPageTab.IsChecked = false;
            }
        }
        private void TestTab_Click(object sender, RoutedEventArgs e)
        {
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = false;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = true;
        }
        private void TestPageTab_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (TabsFrame.CurrentSourcePageType != typeof(TestPage) && typeof(TestPage) != null)
            {
                TabsFrame.Navigate(typeof(TestPage), null, new SuppressNavigationTransitionInfo());
                MyComputerTab.IsChecked = false;
                MyComputer.IsChecked = false;
                UWPFamilyOS.IsChecked = false;
                VMTab.IsChecked = false;
                HomeTab.IsChecked = false;
                SharedVMsTab.IsChecked = false;
                SharedVMs.IsChecked = false;
                TestPageTab.IsChecked = true;
            }
        }
        private void GoToHome_Click(object sender, RoutedEventArgs e)
        {
            TabsFrame.Navigate(typeof(HomePage), null, new SuppressNavigationTransitionInfo());
            MyComputerTab.IsChecked = false;
            MyComputer.IsChecked = false;
            UWPFamilyOS.IsChecked = false;
            VMTab.IsChecked = false;
            HomeTab.IsChecked = true;
            SharedVMsTab.IsChecked = false;
            SharedVMs.IsChecked = false;
            TestPageTab.IsChecked = false;
        }
        private void HomeTab_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(HomePage))
            {
                TabsFrame.Navigate(typeof(HomePage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void SharedVMsTab_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(SharedVMsPage))
            {
                TabsFrame.Navigate(typeof(SharedVMsPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void VMTab_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(VMPage))
            {
                TabsFrame.Navigate(typeof(VMPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void TestPageTab_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(TestPage))
            {
                TabsFrame.Navigate(typeof(TestPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void MyComputerTab_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(MyComputerPage))
            {
                TabsFrame.Navigate(typeof(MyComputerPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void MyComputer_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(MyComputerPage))
            {
                TabsFrame.Navigate(typeof(MyComputerPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void UWPFamilyOS_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(VMPage))
            {
                TabsFrame.Navigate(typeof(VMPage), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void SharedVMs_Checked(object sender, RoutedEventArgs e)
        {
            if (TabsFrame.CurrentSourcePageType != typeof(SharedVMsPage))
            {
                TabsFrame.Navigate(typeof(SharedVMsPage), null, new SuppressNavigationTransitionInfo());
            }
        }
    }
}
