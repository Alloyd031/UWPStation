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
        private void NavigationView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            FrameNavigationOptions navOptions = new FrameNavigationOptions();
            navOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
            navOptions.IsNavigationStackEnabled = false;

            Type pageType = null;
            if (args.SelectedItem == WorkspaceItem)
            {
                pageType = typeof(WorkspacePage);
            }
            else if (args.SelectedItem == InputItem)
            {
                pageType = typeof(InputPage);
            }
            else if (args.SelectedItem == HotKeysItem)
            {
                pageType = typeof(HotKeysPage);
            }
            else if (args.SelectedItem == DisplayItem)
            {
                pageType = typeof(DisplayPage);
            }
            else if (args.SelectedItem == UnityItem)
            {
                pageType = typeof(UnityPage);
            }
            else if (args.SelectedItem == USBItem)
            {
                pageType = typeof(USBPage);
            }
            else if (args.SelectedItem == UpdatesItem)
            {
                pageType = typeof(UpdatesPage);
            }
            else if (args.SelectedItem == FeedbackItem)
            {
                pageType = typeof(FeedbackPage);
            }
            else if (args.SelectedItem == MemoryItem)
            {
                pageType = typeof(MemoryPage);
            }
            else if (args.SelectedItem == PriorityItem)
            {
                pageType = typeof(PriorityPage);
            }
            else if (args.SelectedItem == DevicesItem)
            {
                pageType = typeof(DevicesPage);
            }
            ContentFrame.NavigateToType(pageType, null, navOptions);
        }
    }
}
