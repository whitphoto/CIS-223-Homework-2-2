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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            string site = URL.Text;
            MiniBrowser.Navigate(new Uri(site, UriKind.Absolute));
        }

        private void MaristButton_Click(object sender, RoutedEventArgs e)
        {
            MiniBrowser.Navigate(new Uri("https://www.marist.edu/", UriKind.Absolute));
        }

        private void VassarButton_Click(object sender, RoutedEventArgs e)
        {
            MiniBrowser.Navigate(new Uri("https://www.vassar.edu/", UriKind.Absolute));
        }
    }
}
