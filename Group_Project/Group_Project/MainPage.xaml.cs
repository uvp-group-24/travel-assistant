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

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace Group_Project
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Frame0.Navigate(typeof(SceneryFrame));
        }

        private void Hamberger_Click(object sender, RoutedEventArgs e)
        {
            Split1.IsPaneOpen = !Split1.IsPaneOpen;
        }

        private void List1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Me.IsSelected)
            {
                Frame.Navigate(typeof(MeFrame));
            }
            else if (Scenery.IsSelected)
            {
                Frame.Navigate(typeof(SceneryFrame));
            }
            else if (Moments.IsSelected)
            {
                Frame.Navigate(typeof(JournalFrame));
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack) Frame0.GoBack();
        }
    }
}
