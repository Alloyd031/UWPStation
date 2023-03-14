using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPStation.Pages;
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

namespace UWPStation.Dialogs
{
    public sealed partial class AboutDialog : ContentDialog
    {
        public AboutDialog()
        {
            this.InitializeComponent();
        }
        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(InfoPage));
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void NavigationView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            FrameNavigationOptions navOptions = new FrameNavigationOptions();
            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
            navOptions.IsNavigationStackEnabled = false;

            Type pageType = null;
            if (args.SelectedItem == InfoItem)
            {
                pageType = typeof(InfoPage);
            }
            else if (args.SelectedItem == CreatorsItem)
            {
                pageType = typeof(CreatorsPage);
            }
            ContentFrame.NavigateToType(pageType, null, navOptions);
        }
    }
}
