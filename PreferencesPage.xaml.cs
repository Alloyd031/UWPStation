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
using Windows.UI.Core;
using System.Security.AccessControl;
using System.Xml.Linq;
using UWPStation.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PreferencesPage : Page
    {
        public PreferencesPage()
        {
            this.InitializeComponent();

            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Window.Current.Content is Frame rootFrame && rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
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
