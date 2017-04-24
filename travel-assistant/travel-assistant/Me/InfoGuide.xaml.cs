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
using travel_assistant.Model;
using Windows.UI.Xaml.Media.Imaging;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace travel_assistant.Me
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class InfoGuide : Page
    {
        private UserModel User = UserModel.User;
        public InfoGuide()
        {
            this.InitializeComponent();
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Me/background1.jpg", UriKind.Absolute));
            NameRP.Background = imageBrush;
            GuideFrame.Navigate(typeof(InfoPage));
        }

        private void BasicInfo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GuideFrame.Navigate(typeof(InfoPage));
        }

        private void DailyDraw_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GuideFrame.Navigate(typeof(PrizePage));
        }

        private void Orders_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GuideFrame.Navigate(typeof(OrderPage));
        }

        private void Invitations_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GuideFrame.Navigate(typeof(ShowInvitation));
        }
    }
}
