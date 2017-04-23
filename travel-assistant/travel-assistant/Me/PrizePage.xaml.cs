using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using travel_assistant.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace travel_assistant.Me
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class PrizePage : Page
    {
        public PrizePage()
        {
            this.InitializeComponent();
        }

        private async void GoButton_Click(object sender, RoutedEventArgs e)
        {
            MyMedia.Source = new Uri(this.BaseUri, String.Format("/Assets/Me/BGM.mp3"));
            if ((bool)myCanvas.GetValue(StarBehavior.AttachStarFlakeProperty) == true)
                myCanvas.SetValue(StarBehavior.AttachStarFlakeProperty, false);
            if ((bool)myCanvas.GetValue(StarBehavior.AttachStarFlakeProperty) == false)
            {
                if (myCanvas.Children.Count > 3)
                {
                    await new MessageDialog("动画未完全结束").ShowAsync();
                    return;
                }
                myCanvas.SetValue(StarBehavior.AttachStarFlakeProperty, true);
            }
            MyStory.Begin();
        }
    }
}
