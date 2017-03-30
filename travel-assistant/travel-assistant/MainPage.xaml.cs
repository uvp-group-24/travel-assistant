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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace travel_assistant
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            mainframe.Navigate(typeof(RecommendPage));
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (recommend_item.IsSelected) mainframe.Navigate(typeof(RecommendPage));
            else if (friends_item.IsSelected) mainframe.Navigate(typeof(FriendsPage));
            else if (discover_item.IsSelected) mainframe.Navigate(typeof(DiscoverPage));
            else if (me_item.IsSelected) mainframe.Navigate(typeof(MePage));
            else if (settings_item.IsSelected) mainframe.Navigate(typeof(SettingsPage));
            splitview.IsPaneOpen = false;
        }

        private void Goback_Click(object sender, RoutedEventArgs e)
        {
            if (mainframe.CanGoBack) mainframe.GoBack();
        }

        private void Hamberger_Click(object sender, RoutedEventArgs e)
        {
            splitview.IsPaneOpen = !splitview.IsPaneOpen;
        }
    }
}
