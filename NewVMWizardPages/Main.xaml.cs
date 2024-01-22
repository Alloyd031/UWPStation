using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UWPStation.NewVMWizardPages
{
    public sealed partial class Main : Page
    {
        public static RadioButton TypeCustom { get; set; }
        public static RadioButton TypeTypical { get; set; }
        public Main()
        {
            this.InitializeComponent();
            TypeCustom = CustomRadioButton;
            TypeTypical = TypicalRadioButton;
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.TypicalRadioButton.IsChecked == true)
            {
                this.Frame.Navigate(typeof(Installation));
            }
            if (this.CustomRadioButton.IsChecked == true)
            {
                this.Frame.Navigate(typeof(Compatibility));
            }
        }
    }
}
