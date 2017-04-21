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
using travel_assistant.Friends;
using travel_assistant.Me;
using travel_assistant.Model;
using travel_assistant.Moments;
using travel_assistant.Recommend;
using travel_assistant.Settings;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace travel_assistant
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<MenuItem> MenuItems;
        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();
            MenuItems = MenuItemManager.GetMenuItems();
            MainFrame.Navigate(typeof(RecommendPage));
            Current = this;
        }
        private void Hamberger_Click(object sender, RoutedEventArgs e)
        {
            splitview.IsPaneOpen = !splitview.IsPaneOpen;
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var menuitem = (MenuItem)listbox.SelectedItem;

            if (menuitem.Name == "recommend_item") MainFrame.Navigate(typeof(RecommendPage));
            else if (menuitem.Name == "friends_item") MainFrame.Navigate(typeof(FriendsPage));
            else if (menuitem.Name == "moments_item") MainFrame.Navigate(typeof(MomentsPage));
            else if (menuitem.Name == "me_item") MainFrame.Navigate(typeof(MePage));
            else if (menuitem.Name == "settings_item") MainFrame.Navigate(typeof(SettingsPage));

            splitview.IsPaneOpen = false;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listbox.SelectedIndex = 0;
        }
    }
}
