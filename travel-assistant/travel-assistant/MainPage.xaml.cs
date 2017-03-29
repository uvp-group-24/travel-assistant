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
            mainframe.Navigate(typeof(AttractionsPage));
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (attractions.IsSelected) mainframe.Navigate(typeof(AttractionsPage));
            else if(moments.IsSelected) mainframe.Navigate(typeof(MomentsPage));
            else if (me.IsSelected) mainframe.Navigate(typeof(MePage));
            else if (settings.IsSelected) mainframe.Navigate(typeof(SettingsPage));
            splitview.IsPaneOpen = false;
        }

        private void Goback_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hamberger_Click(object sender, RoutedEventArgs e)
        {
            splitview.IsPaneOpen = !splitview.IsPaneOpen;
        }
    }
}
