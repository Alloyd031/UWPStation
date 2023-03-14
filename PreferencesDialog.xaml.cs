using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.PreferencesDialogs;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation
{
    public sealed partial class PreferencesDialog : ContentDialog
    {
        public PreferencesDialog()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private async void WorkspaceButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Workspace dialog = new Workspace();
            await dialog.ShowAsync();
        }
        private async void InputButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Input dialog = new Input();
            await dialog.ShowAsync();
        }
        private async void HotKeysButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            HotKeys dialog = new HotKeys();
            await dialog.ShowAsync();
        }
        private async void DisplayButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Display dialog = new Display();
            await dialog.ShowAsync();
        }
        private async void UnityButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Unity dialog = new Unity();
            await dialog.ShowAsync();
        }
        private async void USBButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            USB dialog = new USB();
            await dialog.ShowAsync();
        }
        private async void UpdatesButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Updates dialog = new Updates();
            await dialog.ShowAsync();
        }
        private async void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Feedback dialog = new Feedback();
            await dialog.ShowAsync();
        }
        private async void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Memory dialog = new Memory();
            await dialog.ShowAsync();
        }
        private async void PriorityButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Priority dialog = new Priority();
            await dialog.ShowAsync();
        }
        private async void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Devices dialog = new Devices();
            await dialog.ShowAsync();
        }
    }
}
