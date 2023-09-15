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

namespace UWPStation
{
    public sealed partial class Changelog : ContentDialog
    {
        public Changelog()
        {
            this.InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("Changelog.txt");
            ChangelogBox.Text = file.ReadToEnd();
            file.Close();
        }
    }
}
