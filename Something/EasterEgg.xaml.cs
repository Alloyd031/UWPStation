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

// Документацию по шаблону элемента "Диалоговое окно содержимого" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPStation.Something
{
    public sealed partial class EasterEgg : ContentDialog
    {
        public EasterEgg()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void SayHiButton_Click(object sender, RoutedEventArgs e)
        {
            this.Text1.Text = "Hello there!";
            this.Text2.Text = "Nice weather today!";
            if (this.SayHiButton != null)
            {
                this.SayHiButton.IsEnabled = false;
            }
        }
    }
}
